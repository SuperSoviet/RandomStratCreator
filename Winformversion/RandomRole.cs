using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winformversion {
  public partial class RandomRole : Form {
    public RandomRole() {
      InitializeComponent();
    }
    public override string Text {
      get; set;
    }


    private void btnReturnMain_Click(object sender, EventArgs e) {
      Hide();
    }

    private void lblrandomrole_Click(object sender, EventArgs e) {
      var random = new Random();
      var rolelist = new List<string> { "Top", "Jungle", "Mid", "Bot", "Support" };
      var index = random.Next(rolelist.Count);
      lblrandomrole.Text = rolelist[index];
    }
  }
}
