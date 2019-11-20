namespace Winformversion {
  partial class RandomOption {
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
      this.lblReturnMain = new System.Windows.Forms.Button();
      this.lblRandomOption = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblReturnMain
      // 
      this.lblReturnMain.Location = new System.Drawing.Point(414, 255);
      this.lblReturnMain.Name = "lblReturnMain";
      this.lblReturnMain.Size = new System.Drawing.Size(106, 36);
      this.lblReturnMain.TabIndex = 0;
      this.lblReturnMain.Text = "Return";
      this.lblReturnMain.UseVisualStyleBackColor = true;
      this.lblReturnMain.Click += new System.EventHandler(this.lblReturnMain_Click);
      // 
      // lblRandomOption
      // 
      this.lblRandomOption.AutoSize = true;
      this.lblRandomOption.Location = new System.Drawing.Point(12, 9);
      this.lblRandomOption.Name = "lblRandomOption";
      this.lblRandomOption.Size = new System.Drawing.Size(304, 17);
      this.lblRandomOption.TabIndex = 1;
      this.lblRandomOption.Text = "Press here to select one of the random options";
      this.lblRandomOption.Click += new System.EventHandler(this.lblRandomOption_Click);
      // 
      // RandomOption
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 303);
      this.Controls.Add(this.lblRandomOption);
      this.Controls.Add(this.lblReturnMain);
      this.MaximumSize = new System.Drawing.Size(550, 350);
      this.MinimumSize = new System.Drawing.Size(550, 350);
      this.Name = "RandomOption";
      this.Text = "RandomOption";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button lblReturnMain;
    private System.Windows.Forms.Label lblRandomOption;
  }
}