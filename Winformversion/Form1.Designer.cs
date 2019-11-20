namespace Winformversion {
  partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    private void InitializeComponent()
    {
      this.fillin = new System.Windows.Forms.TextBox();
      this.Exit = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnRandomChampion = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.pbMainmenu = new System.Windows.Forms.PictureBox();
      this.lblLinkGithub = new System.Windows.Forms.LinkLabel();
      ((System.ComponentModel.ISupportInitialize)(this.pbMainmenu)).BeginInit();
      this.SuspendLayout();
      // 
      // fillin
      // 
      this.fillin.Location = new System.Drawing.Point(306, 418);
      this.fillin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.fillin.Name = "fillin";
      this.fillin.Size = new System.Drawing.Size(259, 22);
      this.fillin.TabIndex = 0;
      // 
      // Exit
      // 
      this.Exit.Location = new System.Drawing.Point(713, 418);
      this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(75, 27);
      this.Exit.TabIndex = 2;
      this.Exit.Text = "exit";
      this.Exit.UseVisualStyleBackColor = true;
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(330, 244);
      this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(117, 30);
      this.btnExit.TabIndex = 4;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(30, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(401, 18);
      this.label1.TabIndex = 5;
      this.label1.Text = "Welcome to the league of legends random strat generator!";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(194, 17);
      this.label2.TabIndex = 6;
      this.label2.Text = "Select a random champion :\r\n";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(167, 22);
      this.label3.TabIndex = 7;
      this.label3.Text = "Select a random role :\r\n";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(12, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(174, 18);
      this.label4.TabIndex = 8;
      this.label4.Text = "Select  a random strat :\r\n";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(12, 114);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(284, 22);
      this.label5.TabIndex = 9;
      this.label5.Text = "Randomly gives you one of the options :\r\n";
      // 
      // btnRandomChampion
      // 
      this.btnRandomChampion.Location = new System.Drawing.Point(330, 32);
      this.btnRandomChampion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnRandomChampion.Name = "btnRandomChampion";
      this.btnRandomChampion.Size = new System.Drawing.Size(63, 23);
      this.btnRandomChampion.TabIndex = 10;
      this.btnRandomChampion.Tag = "wad";
      this.btnRandomChampion.Text = "Select\r\n";
      this.btnRandomChampion.UseVisualStyleBackColor = true;
      this.btnRandomChampion.Click += new System.EventHandler(this.btnRandomChampion_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(330, 61);
      this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(63, 25);
      this.button4.TabIndex = 11;
      this.button4.Text = "Select";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // pbMainmenu
      // 
      this.pbMainmenu.ImageLocation = "https://thumbs.gfycat.com/CostlyBriefFieldspaniel-small.gif";
      this.pbMainmenu.Location = new System.Drawing.Point(102, -15);
      this.pbMainmenu.Name = "pbMainmenu";
      this.pbMainmenu.Size = new System.Drawing.Size(688, 737);
      this.pbMainmenu.TabIndex = 12;
      this.pbMainmenu.TabStop = false;
      // 
      // lblLinkGithub
      // 
      this.lblLinkGithub.AutoSize = true;
      this.lblLinkGithub.Location = new System.Drawing.Point(12, 244);
      this.lblLinkGithub.Name = "lblLinkGithub";
      this.lblLinkGithub.Size = new System.Drawing.Size(72, 17);
      this.lblLinkGithub.TabIndex = 13;
      this.lblLinkGithub.TabStop = true;
      this.lblLinkGithub.Text = "My Github";
      this.lblLinkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGithub_LinkClicked);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(459, 283);
      this.Controls.Add(this.lblLinkGithub);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.btnRandomChampion);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.Exit);
      this.Controls.Add(this.fillin);
      this.Controls.Add(this.pbMainmenu);
      this.Location = new System.Drawing.Point(19, 19);
      this.MaximumSize = new System.Drawing.Size(477, 330);
      this.MinimumSize = new System.Drawing.Size(477, 330);
      this.Name = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pbMainmenu)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Exit;
    private System.Windows.Forms.TextBox fillin;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnRandomChampion;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.PictureBox pbMainmenu;
    private System.Windows.Forms.LinkLabel lblLinkGithub;
  }
}

