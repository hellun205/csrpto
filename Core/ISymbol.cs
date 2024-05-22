using System;
using System.Drawing;
using System.Windows.Forms;

namespace csrpto.Core
{
  public interface ISymbol
  {
    Point ViewPoint { get; set; }
    Point Position { get; set; }
    Size Size { get; set; }
    bool IsSelected { get; }
    bool IsExecuting { get; }
    Font Font { get; set; }
    Brush FontBrush { get; set; }
    float BorderSize { get; set; }
    Color BorderColor { get; }
    string Text { get; }

    void OnPaint(PaintEventArgs e);
    void OnExecute();
    void Select();
    void Deselect();
    void OnEdit();

    bool CheckBounds(Point position);
    event Action OnValidate;
  }
}