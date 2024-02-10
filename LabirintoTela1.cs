using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirintoComTelas
{
    public partial class LabirintoTela1 : Form
    {
        public LabirintoTela1()
        {
            InitializeComponent();
        }

        private void LabirintoTela1_Load(object sender, EventArgs e)
        {

        }

        private void btnTela1_Click(object sender, EventArgs e)
        {
            LabirintoTela2 labirintoTela2 = new LabirintoTela2();

            this.Hide();

            labirintoTela2.Show();

            labirintoTela2.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void btnBTela1_Click(object sender, EventArgs e)
        {

        }

        private void btnDTela1_Click(object sender, EventArgs e)
        {

        }
    }
}
