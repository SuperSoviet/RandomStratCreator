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
      var championList = new List<string> { "Aatrox", "Ahri", "Akali", 
        "Alistar", "Amumu", "Anivia", "Annie","Ashe", "Aurelion Sol", 
        "Azir", "Bard", "Blitzcrank", "Brand", "Braum", "Caitlyn", "Camille", 
        "Cassiopia", "Cho'Gath", "Corki", "Darius", "Diana", "Dr.Mundo", 
        "Draven", "Ekko", "Elise", "Evelynn", "Ezreal", "Fiddlesticks", 
        "Fiora", "Fizz", "Galio", "Gangplank", "Garen", "Gnar", "Gragas", 
        "Graves", "Hecarim", "Heimerdinger", "Illaoi", "Irelia", "Ivern", 
        "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx", "Kai'Sa", 
        "Kalista", "Karma", "Karthus", "Kassadin", "Katarina", "Kayle", 
        "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled", "Kog'Maw", 
        "LeBlanc", "Lee Sin", "Leona", "Lissandra", "Lucian", "Lulu", "Lux", 
        "Malphite", "Malzahar", "Maokai", "Master Yi", "Miss Fortune", 
        "Mordekaiser", "Morgana", "Nami", "Nasus", "Nautiles", "Neeko", 
        "Nidalee", "Nocturne", "Nunu&Willump", "Olaf", "Orianna", "Ornn", 
        "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn", "Rakan", "Rammus", 
        "Rek'Sai", "Renekton", "Rengar", "Riven", "Rumble", "Ryze", "Sejuani", 
        "Senna", "Shaco", "Shen", "Shyvana", "Singed", "Sion", "Sivir", 
        "Skarner", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tahm Kench", 
        "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana", "Trundle", 
        "Tryndamere", "Twister Fate", "Twitch", "Udyr", "Urgot", "Varus", 
        "Vayne", "Veigar", "Vel'koz", "Vi", "Viktor", "Vladimir", "Volibear", 
        "Warwick", "Wukong", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yorick", 
        "Yuumi", "Zac", "Zed", "Ziggs", "Zilean", "Zoe", "Zyra" };
      var index = random.Next(championList.Count);
      label1.Text = championList[index];
    }
  }
}