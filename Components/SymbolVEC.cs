using csrpto.Core;
using System.Windows.Forms;

namespace csrpto.Components
{
  public abstract class SymbolVEC<T> : UserControl, ISymbolVEC where T : struct, ISymbolValue
  {
    public abstract T Value { get; set; }

  
    protected SymbolVEC()
    {
      this.AutoSize = true;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    }
  }
}