﻿using csrpto.Core;

namespace csrpto.Components.Symbols
{
  partial class TestSymbolVEC
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;


    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();

      this.tlp = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.tlp.SuspendLayout();
      this.SuspendLayout();
      // 
      // tlp
      // 
      this.tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tlp.ColumnCount = 2;
      this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlp.Controls.Add(this.textBox2, 1, 1);
      this.tlp.Controls.Add(this.label2, 0, 1);
      this.tlp.Controls.Add(this.label1, 0, 0);
      this.tlp.Controls.Add(this.textBox1, 1, 0);
      this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlp.Location = new System.Drawing.Point(0, 0);
      this.tlp.Name = "tlp";
      this.tlp.Padding = new System.Windows.Forms.Padding(5);
      this.tlp.RowCount = 2;
      this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlp.Size = new System.Drawing.Size(324, 69);
      this.tlp.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(9, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "Test Value 1";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(110, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(205, 21);
      this.textBox1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(9, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 28);
      this.label2.TabIndex = 2;
      this.label2.Text = "Test Value 2";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox2
      // 
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox2.Location = new System.Drawing.Point(110, 38);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(205, 21);
      this.textBox2.TabIndex = 3;

      // 
      // SymbolContainer1
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add(this.tlp);
      this.Name = "TestSymbolVEC";
      this.tlp.ResumeLayout(false);
      this.tlp.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tlp;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
  }
}
