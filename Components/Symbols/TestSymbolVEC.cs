using csrpto.Core;
using csrpto.Core.Symbols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace csrpto.Components.Symbols
{
  public partial class TestSymbolVEC : SymbolVEC<TestSymbolValue>
  {
    public override TestSymbolValue Value
    {
      get => new TestSymbolValue()
      {
        Value1 = textBox1.Text,
        Value2 = textBox2.Text
      };
      set
      {
        textBox1.Text = value.Value1;
        textBox2.Text = value.Value2;
      }
    }

    public TestSymbolVEC() : base()
    {
      InitializeComponent();
    }
  }
}
