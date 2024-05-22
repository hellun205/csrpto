using csrpto.Components;
using csrpto.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace csrpto.Core
{
  public abstract class SymbolBase<TVEC, TValue> : ISymbol
    where TVEC : SymbolVEC<TValue>, new()
    where TValue : struct, ISymbolValue
  {
    #region Properties
    private Point _viewPoint;
    public Point ViewPoint
    {
      get => _viewPoint;
      set
      {
        _viewPoint = value;
        VisualChanged();
      }
    }

    private Point _position;
    public Point Position
    {
      get => new Point(_position.X + ViewPoint.X, _position.Y + ViewPoint.Y);
      set
      {
        _position = value;
        VisualChanged();
      }
    }

    private Size _size = new Size(200, 100);
    public Size Size
    {
      get => _size;
      set
      {
        _size = value;
        VisualChanged();
      }
    }

    private bool _isSelected = false;
    public bool IsSelected
    {
      get => _isSelected;
      private set
      {
        _isSelected = value;
        VisualChanged();
      }
    }

    private bool _isExecuting = false;
    public bool IsExecuting
    {
      get => _isExecuting;
      set
      {
        _isExecuting = value;
        VisualChanged();
      }
    }



    private Font _font = new Font(new FontFamily("맑은 고딕"), 9);
    public Font Font
    {
      get => _font;
      set
      {
        _font = value;
        VisualChanged();
      }
    }

    private Brush _fontBrush = Brushes.Black;
    public Brush FontBrush
    {
      get => _fontBrush;
      set
      {
        _fontBrush = value;
        VisualChanged();
      }
    }

    private float _borderSize = 2f;
    public float BorderSize
    {
      get => _borderSize;
      set
      {
        _borderSize = value;
        VisualChanged();
      }
    }

    private Color _borderColor = NormalColor;
    public Color BorderColor
    {
      get => _borderColor;
      private set
      {
        _borderColor = value;
      }
    }

    public abstract string Text { get; }

    protected Pen BorderPen => new Pen(BorderColor, BorderSize);

    private TValue _value;
    protected TValue Value
    {
      get => _value;
      set
      {
        _value = value;
        VisualChanged();
      }
    }

    protected abstract string Descriptions { get; }
    

    #endregion

      #region Const
    public static readonly Color SelectedColor = Color.Blue;
    public static readonly Color ExecutedColor = Color.Yellow;
    public static readonly Color NormalColor = Color.Black;
    #endregion

    public event Action OnValidate;

    public SymbolBase()
    {
    }

    public void OnPaint(PaintEventArgs e)
    {
      OnPaintBorder(e);
      OnPaintText(e);
    }

    protected virtual void OnPaintBorder(PaintEventArgs e)
    {
      var rect = new Rectangle(Position.X, Position.Y, Size.Width, Size.Height);
      e.Graphics.DrawRectangle(BorderPen, rect);
    }

    protected virtual void OnPaintText(PaintEventArgs e)
    {
      var rect = new Rectangle(Position.X, Position.Y, Size.Width, Size.Height);
      var sf = new StringFormat()
      {
        Alignment = StringAlignment.Center,
        LineAlignment = StringAlignment.Center
      };
      e.Graphics.DrawString(Text, Font, FontBrush, rect, sf);
    }

    public abstract void OnExecute();

    public void Select()
    {
      if (IsSelected) return;

      IsSelected = true;
    }

    public void Deselect()
    {
      if (!IsSelected) return;

      IsSelected = false;
    }

    protected void VisualChanged()
    {
      if (IsExecuting)
        BorderColor = ExecutedColor;
      else
        BorderColor = IsSelected ? SelectedColor : NormalColor;

      OnValidate?.Invoke();
    }

    public void OnEdit()
    {
      var form = new SymbolEditForm<TVEC, TValue>()
      {
        Descriptions = Descriptions
      };
      form.OnConfirm += (v) =>
      {
        Value = v;
      };
      form.ShowDialog();
    }

    public bool CheckBounds(Point position)
    {
      return (position.X >= Position.X && position.X <= Position.X + Size.Width) &&
        (position.Y >= Position.Y && position.Y <= Position.Y + Size.Height);
    }
  }
}
