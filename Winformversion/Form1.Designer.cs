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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
      this.lblStrat = new System.Windows.Forms.Button();
      this.lblRandomOption = new System.Windows.Forms.Button();
      this.lblSecret = new System.Windows.Forms.Label();
      this.btnMyProfile = new System.Windows.Forms.Button();
      this.btnDiscord = new System.Windows.Forms.Button();
      this.lblGithub = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pbMainmenu)).BeginInit();
      this.SuspendLayout();
      // 
      // fillin
      // 
      this.fillin.Location = new System.Drawing.Point(230, 340);
      this.fillin.Margin = new System.Windows.Forms.Padding(2);
      this.fillin.Name = "fillin";
      this.fillin.Size = new System.Drawing.Size(195, 20);
      this.fillin.TabIndex = 0;
      // 
      // Exit
      // 
      this.Exit.Location = new System.Drawing.Point(535, 340);
      this.Exit.Margin = new System.Windows.Forms.Padding(2);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(56, 22);
      this.Exit.TabIndex = 2;
      this.Exit.Text = "exit";
      this.Exit.UseVisualStyleBackColor = true;
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(435, 276);
      this.btnExit.Margin = new System.Windows.Forms.Padding(2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(88, 24);
      this.btnExit.TabIndex = 4;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(8, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(301, 15);
      this.label1.TabIndex = 5;
      this.label1.Text = "Welcome to the league of legends random strat generator!";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(9, 31);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(146, 14);
      this.label2.TabIndex = 6;
      this.label2.Text = "Select a random champion :\r\n";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(9, 53);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(125, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Select a random role :\r\n";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(9, 82);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(130, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Select  a random strat :\r\n";
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.SystemColors.Control;
      this.label5.Location = new System.Drawing.Point(9, 110);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(213, 18);
      this.label5.TabIndex = 9;
      this.label5.Text = "Randomly gives you one of the options :\r\n";
      // 
      // btnRandomChampion
      // 
      this.btnRandomChampion.Location = new System.Drawing.Point(326, 31);
      this.btnRandomChampion.Margin = new System.Windows.Forms.Padding(2);
      this.btnRandomChampion.Name = "btnRandomChampion";
      this.btnRandomChampion.Size = new System.Drawing.Size(47, 19);
      this.btnRandomChampion.TabIndex = 10;
      this.btnRandomChampion.Tag = "wad";
      this.btnRandomChampion.Text = "Select\r\n";
      this.btnRandomChampion.UseVisualStyleBackColor = true;
      this.btnRandomChampion.Click += new System.EventHandler(this.btnRandomChampion_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(326, 82);
      this.button4.Margin = new System.Windows.Forms.Padding(2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(47, 20);
      this.button4.TabIndex = 11;
      this.button4.Text = "Select";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.btnRoleSelector_Click);
      // 
      // pbMainmenu
      // 
      this.pbMainmenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMainmenu.Image")));
      this.pbMainmenu.ImageLocation = "";
      this.pbMainmenu.Location = new System.Drawing.Point(52, 26);
      this.pbMainmenu.Margin = new System.Windows.Forms.Padding(2);
      this.pbMainmenu.Name = "pbMainmenu";
      this.pbMainmenu.Size = new System.Drawing.Size(379, 288);
      this.pbMainmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbMainmenu.TabIndex = 12;
      this.pbMainmenu.TabStop = false;
      // 
      // lblStrat
      // 
      this.lblStrat.Location = new System.Drawing.Point(326, 54);
      this.lblStrat.Margin = new System.Windows.Forms.Padding(2);
      this.lblStrat.Name = "lblStrat";
      this.lblStrat.Size = new System.Drawing.Size(47, 23);
      this.lblStrat.TabIndex = 14;
      this.lblStrat.Text = "Select";
      this.lblStrat.UseVisualStyleBackColor = true;
      this.lblStrat.Click += new System.EventHandler(this.btnStrat_Click);
      // 
      // lblRandomOption
      // 
      this.lblRandomOption.Location = new System.Drawing.Point(326, 106);
      this.lblRandomOption.Margin = new System.Windows.Forms.Padding(2);
      this.lblRandomOption.Name = "lblRandomOption";
      this.lblRandomOption.Size = new System.Drawing.Size(47, 20);
      this.lblRandomOption.TabIndex = 15;
      this.lblRandomOption.Text = "Select";
      this.lblRandomOption.UseVisualStyleBackColor = true;
      this.lblRandomOption.Click += new System.EventHandler(this.btnRandomOption_Click);
      // 
      // lblSecret
      // 
      this.lblSecret.BackColor = System.Drawing.Color.Transparent;
      this.lblSecret.ForeColor = System.Drawing.Color.Transparent;
      this.lblSecret.Location = new System.Drawing.Point(493, 1);
      this.lblSecret.Name = "lblSecret";
      this.lblSecret.Size = new System.Drawing.Size(100, 23);
      this.lblSecret.TabIndex = 16;
      this.lblSecret.Click += new System.EventHandler(this.lblSecret_Click_1);
      // 
      // btnMyProfile
      // 
      this.btnMyProfile.Location = new System.Drawing.Point(422, 248);
      this.btnMyProfile.Name = "btnMyProfile";
      this.btnMyProfile.Size = new System.Drawing.Size(100, 23);
      this.btnMyProfile.TabIndex = 17;
      this.btnMyProfile.Text = "My league profile";
      this.btnMyProfile.UseVisualStyleBackColor = true;
      this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
      // 
      // btnDiscord
      // 
      this.btnDiscord.BackColor = System.Drawing.Color.Transparent;
      this.btnDiscord.Location = new System.Drawing.Point(435, 219);
      this.btnDiscord.Name = "btnDiscord";
      this.btnDiscord.Size = new System.Drawing.Size(88, 23);
      this.btnDiscord.TabIndex = 18;
      this.btnDiscord.Text = "Join my discord";
      this.btnDiscord.UseVisualStyleBackColor = false;
      this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
      // 
      // lblGithub
      // 
      this.lblGithub.Location = new System.Drawing.Point(11, 277);
      this.lblGithub.Name = "lblGithub";
      this.lblGithub.Size = new System.Drawing.Size(75, 23);
      this.lblGithub.TabIndex = 19;
      this.lblGithub.Text = "My github";
      this.lblGithub.UseVisualStyleBackColor = true;
      this.lblGithub.Click += new System.EventHandler(this.lblGithub_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(534, 311);
      this.Controls.Add(this.lblGithub);
      this.Controls.Add(this.btnDiscord);
      this.Controls.Add(this.btnMyProfile);
      this.Controls.Add(this.lblRandomOption);
      this.Controls.Add(this.lblStrat);
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
      this.Controls.Add(this.lblSecret);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(19, 19);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximumSize = new System.Drawing.Size(550, 350);
      this.MinimumSize = new System.Drawing.Size(550, 350);
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
    private System.Windows.Forms.Button lblStrat;
    private System.Windows.Forms.Button lblRandomOption;
    private System.Windows.Forms.Label lblSecret;
    private System.Windows.Forms.Button btnMyProfile;
    private System.Windows.Forms.Button btnDiscord;
    private System.Windows.Forms.Button lblGithub;
  }
}

