using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Simplex : Form {
    public Simplex() {
      InitializeComponent();
    }

    private void Simplex_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      var s = new SimplexSolver();
      var r = s.Solve();
      double[] results = r.Item1;

      copperResult.Text   = "" + Math.Round(results[0], 2);
      silverResult.Text   = "" + Math.Round(results[1], 2);
      goldResult.Text     = "" + Math.Round(results[2], 2);
      platinumResult.Text = "" + Math.Round(results[3], 2);

      maxResults.Text     = "" + Math.Round(r.Item2, 2);

    }
  }
}
