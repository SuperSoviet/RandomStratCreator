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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnReturnMain
      // 
      this.btnReturnMain.Location = new System.Drawing.Point(364, 256);
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
      this.lblrandomrole.Location = new System.Drawing.Point(12, 27);
      this.lblrandomrole.Name = "lblrandomrole";
      this.lblrandomrole.Size = new System.Drawing.Size(226, 17);
      this.lblrandomrole.TabIndex = 1;
      this.lblrandomrole.Text = "Press here to select a random role";
      this.lblrandomrole.Click += new System.EventHandler(this.lblrandomrole_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.ImageLocation = "http://pa1.narvii.com/5788/b05a6474bd765787a4bc0d6870e4175049910f06_00.gif";
      this.pictureBox1.Location = new System.Drawing.Point(85, 27);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(468, 285);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // RandomRole
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(482, 303);
      this.Controls.Add(this.lblrandomrole);
      this.Controls.Add(this.btnReturnMain);
      this.Controls.Add(this.pictureBox1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximumSize = new System.Drawing.Size(550, 350);
      this.MinimumSize = new System.Drawing.Size(500, 350);
      this.Name = "RandomRole";
      this.Text = "RandomRole";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnReturnMain;
    private System.Windows.Forms.Label lblrandomrole;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}