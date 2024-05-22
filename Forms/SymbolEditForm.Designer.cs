using csrpto.Components;
using csrpto.Core;

namespace csrpto.Forms
{
  partial class SymbolEditForm<TVEC,TValue>
    where TVEC : SymbolVEC<TValue>, new()
    where TValue : struct, ISymbolValue
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
    protected virtual void InitializeComponent()
    {
      this.btnConfirm = new System.Windows.Forms.Button();
      this.flpButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lbText = new System.Windows.Forms.Label();
      this.panel = new System.Windows.Forms.Panel();
      this.flpButtonPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnConfirm
      // 
      this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnConfirm.Location = new System.Drawing.Point(196, 8);
      this.btnConfirm.Name = "btnConfirm";
      this.btnConfirm.Size = new System.Drawing.Size(75, 23);
      this.btnConfirm.TabIndex = 0;
      this.btnConfirm.Text = "확인";
      this.btnConfirm.UseVisualStyleBackColor = true;
      this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
      // 
      // flpButtonPanel
      // 
      this.flpButtonPanel.AutoSize = true;
      this.flpButtonPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.flpButtonPanel.Controls.Add(this.btnConfirm);
      this.flpButtonPanel.Controls.Add(this.btnCancel);
      this.flpButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.flpButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.flpButtonPanel.Location = new System.Drawing.Point(0, 122);
      this.flpButtonPanel.Name = "flpButtonPanel";
      this.flpButtonPanel.Padding = new System.Windows.Forms.Padding(5);
      this.flpButtonPanel.Size = new System.Drawing.Size(284, 39);
      this.flpButtonPanel.TabIndex = 2;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(115, 8);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "취소";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // lbText
      // 
      this.lbText.AutoSize = true;
      this.lbText.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbText.Location = new System.Drawing.Point(0, 0);
      this.lbText.MinimumSize = new System.Drawing.Size(284, 20);
      this.lbText.Name = "lbText";
      this.lbText.Size = new System.Drawing.Size(284, 20);
      this.lbText.TabIndex = 5;
      this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel
      // 
      this.panel.AutoSize = true;
      this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel.Location = new System.Drawing.Point(0, 20);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(284, 102);
      this.panel.TabIndex = 6;
      // 
      // SymbolEditForm
      // 
      this.AcceptButton = this.btnConfirm;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(284, 161);
      this.Controls.Add(this.panel);
      this.Controls.Add(this.lbText);
      this.Controls.Add(this.flpButtonPanel);
      this.Font = new System.Drawing.Font("돋움", 9F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(400, 1024);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(300, 200);
      this.Name = "SymbolEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Edit Symbol Value";
      this.Load += new System.EventHandler(this.SymbolVEC_Load);
      this.flpButtonPanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    protected System.Windows.Forms.Button btnConfirm;
    protected System.Windows.Forms.FlowLayoutPanel flpButtonPanel;
    protected System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lbText;
    private System.Windows.Forms.Panel panel;
  }
}
