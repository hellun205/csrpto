using csrpto.Components;
using csrpto.Core;
using System;
using System.Windows.Forms;

namespace csrpto.Forms
{
  public partial class SymbolEditForm<TVEC, TValue> : Form
    where TVEC : SymbolVEC<TValue>, new()
    where TValue : struct, ISymbolValue
  {
    public event Action<TValue> OnConfirm;
    public event Action OnCancel;

    public TVEC VEC { get; private set; }
    private TValue? _value;
    public string Descriptions
    {
      get => lbText.Text;
      set => lbText.Text = value;
    }

    public SymbolEditForm()
    {
      InitializeComponent();
    }

    public SymbolEditForm(TValue defalutValue) : this()
    {
      _value = defalutValue;
    }

    public TValue InputValue => VEC.Value;

    private void btnConfirm_Click(object sender, EventArgs e)
    {
      OnConfirm?.Invoke(InputValue);
    }

    private void SymbolVEC_Load(object sender, EventArgs e)
    {
      VEC = new TVEC
      {
        Dock = DockStyle.Fill
      };

      if (_value.HasValue)
        VEC.Value = _value.Value;

      panel.Controls.Add(VEC);
    }
  }
}
