namespace Winformversion {
  partial class RandomRole {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnReturnMain = new System.Windows.Forms.Button();
      this.lblrandomrole = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnReturnMain
      // 
      this.btnReturnMain.Location = new System.Drawing.Point(90, 118);
      this.btnReturnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnReturnMain.Name = "btnReturnMain";
      this.btnReturnMain.Size = new System.Drawing.Size(106, 36);
      this.btnReturnMain.TabIndex = 0;
      this.btnReturnMain.Text = "Return";
      this.btnReturnMain.UseVisualStyleBackColor = true;
      this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
      // 
      // lblrandomrole
      // 
      this.lblrandomrole.AutoSize = true;
      this.lblrandomrole.Location = new System.Drawing.Point(29, 49);
      this.lblrandomrole.Name = "lblrandomrole";
      this.lblrandomrole.Size = new System.Drawing.Size(226, 17);
      this.lblrandomrole.TabIndex = 1;
      this.lblrandomrole.Text = "Press here to select a random role";
      this.lblrandomrole.Click += new System.EventHandler(this.lblrandomrole_Click);
      // 
      // RandomRole
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(277, 198);
      this.Controls.Add(this.lblrandomrole);
      this.Controls.Add(this.btnReturnMain);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximumSize = new System.Drawing.Size(295, 245);
      this.MinimumSize = new System.Drawing.Size(295, 245);
      this.Name = "RandomRole";
      this.Text = "RandomRole";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnReturnMain;
    private System.Windows.Forms.Label lblrandomrole;
  }
}