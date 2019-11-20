namespace Winformversion {
  partial class RandomStrat {
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
      this.lblstrat = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
      // lblstrat
      // 
      this.lblstrat.AutoSize = true;
      this.lblstrat.Location = new System.Drawing.Point(0, 46);
      this.lblstrat.Name = "lblstrat";
      this.lblstrat.Size = new System.Drawing.Size(230, 17);
      this.lblstrat.TabIndex = 1;
      this.lblstrat.Text = "Press here to select a random strat";
      this.lblstrat.Click += new System.EventHandler(this.lblstrat_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.ImageLocation = "https://media3.giphy.com/media/L1KQ5Wyuf4jEGW7KEU/giphy.gif";
      this.pictureBox1.Location = new System.Drawing.Point(12, 66);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(539, 236);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // RandomStrat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 303);
      this.Controls.Add(this.lblstrat);
      this.Controls.Add(this.lblReturnMain);
      this.Controls.Add(this.pictureBox1);
      this.MaximumSize = new System.Drawing.Size(550, 350);
      this.MinimumSize = new System.Drawing.Size(395, 269);
      this.Name = "RandomStrat";
      this.Text = "RandomStrat";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button lblReturnMain;
    private System.Windows.Forms.Label lblstrat;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}