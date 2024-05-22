using csrpto.Core;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using csrpto.Core.Symbols;

namespace csrpto.Components
{
  public partial class SymbolContainer : UserControl
  {
    #region View
    private bool isDragging;
    private Point downPos, originalPos;

    private Point _viewPosition;
    public Point ViewPosition
    {
      get => _viewPosition;
      set
      {
        _viewPosition = value;
        foreach (var symbol in Symbols)
          symbol.ViewPoint = value;
      }
    }

    private void SymbolContainer_MouseDown(object sender, MouseEventArgs e)
    {
      var isClicked = false;
      foreach (var symbol in Symbols)
      {
        if (symbol.CheckBounds(e.Location))
        {
          symbol.Select();
          isClicked = true;
        }
        else
          symbol.Deselect();
      }


      if (!isClicked)
      {
        downPos = e.Location;
        originalPos = ViewPosition;
        isDragging = true;
      }

    }

    private void SymbolContainer_MouseUp(object sender, MouseEventArgs e)
    {
      isDragging = false;
    }

    private void SymbolContainer_MouseMove(object sender, MouseEventArgs e)
    {
      if (!isDragging) return;

      ViewPosition = new Point(originalPos.X + (e.Location.X - downPos.X), originalPos.Y + (e.Location.Y - downPos.Y));
    }
    #endregion

    public const int SpacingSize = 20;

    public List<ISymbol> Symbols = new List<ISymbol>();

    public SymbolContainer()
    {
      InitializeComponent();
    }

    private void SymbolContainer_Paint(object sender, PaintEventArgs e)
    {
      foreach (var symbol in Symbols)
        symbol.OnPaint(e);
    }
    public void AddSymbol(ISymbol symbol, int line = -1)
    {
      symbol.OnValidate += Invalidate;

      if (line == -1)
        Symbols.Add(symbol);
      else
        Symbols.Insert(line, symbol);

      var totalHeight = 0;

      foreach(var s in Symbols)
      {
        s.Position = new Point(0 - (s.Size.Width / 2), totalHeight);
        totalHeight += s.Size.Height + SpacingSize;
      }

      RefreshViewPoint();
    }

    public Rectangle GetSymbolWrapper()
    {
      var minX = Symbols.Min(x => x.Position.X);
      var maxX = Symbols.Max(x => x.Size.Width);
      var minY = Symbols.Min(y => y.Position.Y);
      var maxY = Symbols.Max(y => y.Size.Height);

      return new Rectangle(minX, minY, maxX, maxY);
    }

    private void SymbolContainer_Resize(object sender, System.EventArgs e)
    {
      RefreshViewPoint();
    }

    private void SymbolContainer_Load(object sender, System.EventArgs e)
    {
      AddSymbol(new TestSymbol());
      AddSymbol(new TestSymbol()
      {
        Position = new Point(300, 300)
      });
    }

    private void SymbolContainer_DoubleClick(object sender, System.EventArgs e)
    {
      var symbol = Symbols.SingleOrDefault(x => x.CheckBounds((e as MouseEventArgs).Location));
      symbol?.OnEdit();
    }

    public void RefreshViewPoint(int index = -1)
    {
      if (Symbols.Count == 0)
      {
        ViewPosition = Point.Empty;
        return;
      }

      ISymbol s;
      if (index == -1)
      {
        var selectedSymbol = Symbols.SingleOrDefault(x => x.IsSelected);
        s = selectedSymbol ?? Symbols[0];
      }
      else
        s = Symbols[index];
      
      
      var wrapper = GetSymbolWrapper();

      ViewPosition = new Point(Size.Width / 2, (s.Size.Height / 2) - (s.Position.Y / 2) + (Size.Height / 2));
    }
  }
}
