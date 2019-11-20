using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Winformversion
{
    public partial class RandomChampion : Form
    {
        public RandomChampion()
        {
            InitializeComponent();
        
        
    }
    public override string Text {
      get; set;
    }
      

    private void ReturnMain_Click(object sender, EventArgs e)
        {
           Hide();
        }

    private void label1_Click(object sender, EventArgs e) {
      var random = new Random();
      var championList = new List<string> { "Aatrox", "Ahri", "Akali", "Alistar", "Amumu", "Anivia", "Annie" };
      var index = random.Next(championList.Count);
      label1.Text = championList[index];
    }
  }
}