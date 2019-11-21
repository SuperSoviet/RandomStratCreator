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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomStrat));
      this.lblReturnMain = new System.Windows.Forms.Button();
      this.lblstrat = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblReturnMain
      // 
      this.lblReturnMain.Location = new System.Drawing.Point(310, 207);
      this.lblReturnMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.lblReturnMain.Name = "lblReturnMain";
      this.lblReturnMain.Size = new System.Drawing.Size(80, 29);
      this.lblReturnMain.TabIndex = 0;
      this.lblReturnMain.Text = "Return";
      this.lblReturnMain.UseVisualStyleBackColor = true;
      this.lblReturnMain.Click += new System.EventHandler(this.lblReturnMain_Click);
      // 
      // lblstrat
      // 
      this.lblstrat.AutoSize = true;
      this.lblstrat.Location = new System.Drawing.Point(0, 37);
      this.lblstrat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblstrat.Name = "lblstrat";
      this.lblstrat.Size = new System.Drawing.Size(170, 13);
      this.lblstrat.TabIndex = 1;
      this.lblstrat.Text = "Press here to select a random strat";
      this.lblstrat.Click += new System.EventHandler(this.lblstrat_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.ImageLocation = "";
      this.pictureBox1.Location = new System.Drawing.Point(-29, -15);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(451, 281);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // RandomStrat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(399, 246);
      this.Controls.Add(this.lblstrat);
      this.Controls.Add(this.lblReturnMain);
      this.Controls.Add(this.pictureBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximumSize = new System.Drawing.Size(416, 292);
      this.MinimumSize = new System.Drawing.Size(300, 226);
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