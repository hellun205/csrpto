using csrpto.Components.Symbols;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csrpto.Core.Symbols
{
  public class TestSymbol : SymbolBase<TestSymbolVEC, TestSymbolValue>
  {
   
    
    public override string Text => $"TEST! 1: {Value.Value1}, 2: {Value.Value2}";

    protected override string Descriptions => "\n\n\n\n\n";

    public override void OnExecute()
    {
      MessageBox.Show($"Executing Test Symbol\n{Value.Value1}\n{Value.Value2}");
    }


  }
}
