using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CEA
  {
  public partial class frmSplash : Form
    {
    public frmSplash ()
      {
      InitializeComponent ();
      }

    private void timer1_Tick (object sender, EventArgs e)
      {		
      timer1.Enabled = false;
      timer2.Enabled = true;

      this.Owner.Visible = true;
      }

    private void timer2_Tick (object sender, EventArgs e)
      {
      this.Opacity -= 0.025;

      if (this.Opacity == 0) this.Dispose();
      }
    }
  }
