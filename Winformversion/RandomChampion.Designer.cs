using System.ComponentModel;

namespace Winformversion
{
    partial class RandomChampion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
      this.label1 = new System.Windows.Forms.Label();
      this.ReturnMain = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(278, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Press here to select a random champion";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // ReturnMain
      // 
      this.ReturnMain.Location = new System.Drawing.Point(414, 256);
      this.ReturnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ReturnMain.Name = "ReturnMain";
      this.ReturnMain.Size = new System.Drawing.Size(106, 36);
      this.ReturnMain.TabIndex = 1;
      this.ReturnMain.Text = "Return";
      this.ReturnMain.UseVisualStyleBackColor = true;
      this.ReturnMain.Click += new System.EventHandler(this.ReturnMain_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.ImageLocation = "https://media.giphy.com/media/l2Sq2Iw6xwrlzrLs4/giphy.gif";
      this.pictureBox1.Location = new System.Drawing.Point(27, -52);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(484, 357);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // RandomChampion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 303);
      this.Controls.Add(this.ReturnMain);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.MaximumSize = new System.Drawing.Size(550, 350);
      this.MinimumSize = new System.Drawing.Size(550, 350);
      this.Name = "RandomChampion";
      this.Text = "RandomChampion";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnMain;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}