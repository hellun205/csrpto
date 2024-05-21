
namespace csrpto.Forms
{
  partial class Main
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.symbolContainer1 = new csrpto.Components.SymbolContainer();
      this.symbolContainer2 = new csrpto.Components.SymbolContainer();
      this.SuspendLayout();
      // 
      // symbolContainer1
      // 
      this.symbolContainer1.BackColor = System.Drawing.Color.Transparent;
      this.symbolContainer1.Location = new System.Drawing.Point(0, 0);
      this.symbolContainer1.Name = "symbolContainer1";
      this.symbolContainer1.Size = new System.Drawing.Size(508, 484);
      this.symbolContainer1.TabIndex = 0;
      this.symbolContainer1.ViewPosition = new System.Drawing.Point(254, 146);
      // 
      // symbolContainer2
      // 
      this.symbolContainer2.BackColor = System.Drawing.Color.Transparent;
      this.symbolContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.symbolContainer2.Location = new System.Drawing.Point(0, 0);
      this.symbolContainer2.Name = "symbolContainer2";
      this.symbolContainer2.Size = new System.Drawing.Size(945, 522);
      this.symbolContainer2.TabIndex = 0;
      this.symbolContainer2.ViewPosition = new System.Drawing.Point(472, 217);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(945, 522);
      this.Controls.Add(this.symbolContainer2);
      this.Name = "Main";
      this.Text = "Main";
      this.ResumeLayout(false);

    }

    #endregion

    private Components.SymbolContainer symbolContainer1;
    private Components.SymbolContainer symbolContainer2;
  }
}