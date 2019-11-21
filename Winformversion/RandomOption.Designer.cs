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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomOption));
      this.lblReturnMain = new System.Windows.Forms.Button();
      this.lblRandomOption = new System.Windows.Forms.Label();
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
      // lblRandomOption
      // 
      this.lblRandomOption.AutoSize = true;
      this.lblRandomOption.Location = new System.Drawing.Point(9, 7);
      this.lblRandomOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblRandomOption.Name = "lblRandomOption";
      this.lblRandomOption.Size = new System.Drawing.Size(226, 13);
      this.lblRandomOption.TabIndex = 1;
      this.lblRandomOption.Text = "Press here to select one of the random options";
      this.lblRandomOption.Click += new System.EventHandler(this.lblRandomOption_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.ImageLocation = "";
      this.pictureBox1.Location = new System.Drawing.Point(-21, -33);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(476, 353);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // RandomOption
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(438, 293);
      this.Controls.Add(this.lblRandomOption);
      this.Controls.Add(this.lblReturnMain);
      this.Controls.Add(this.pictureBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximumSize = new System.Drawing.Size(454, 332);
      this.MinimumSize = new System.Drawing.Size(454, 332);
      this.Name = "RandomOption";
      this.Text = "RandomOption";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button lblReturnMain;
    private System.Windows.Forms.Label lblRandomOption;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}