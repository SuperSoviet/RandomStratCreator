using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Winformversion {
  public partial class MyGithub : Form {
    public ChromiumWebBrowser chromebrowser;
    public MyGithub() {
      InitializeComponent();
      //at the initializer start chromium
      if (DesignMode) return;
      InitializeChromium();
    }
    private void InitializeChromium() {
      CefSettings settings = new CefSettings();
      //initialize Cef with the provided settings
      Cef.Initialize(settings);
      //create a browser component
      //and provide a start web url
      chromebrowser = new ChromiumWebBrowser("https://github.com/SuperSoviet");
      //add the browser to the form
      chromebrowser.Dock = DockStyle.Fill;
      Controls.Add(chromebrowser);
      // make the browser fill the form
    }
    private void Opgg_FormClosing(object sender, FormClosingEventArgs e) {
      Cef.Shutdown();
    }
  }
}
