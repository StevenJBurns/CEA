using System;
using System.Windows.Forms;

namespace CEA.WindowsForms.UI
  {
  public partial class FormMain : Form
    {
    public FormMain()
      {
      InitializeComponent();
      }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
          {
          Application.Exit();
          }
    }
  }
