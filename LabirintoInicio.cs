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
    public partial class LabirintoInicio : Form
    {
        public LabirintoInicio()
        {
            InitializeComponent();
        }

        private void btnInicioLabirinto_Click(object sender, EventArgs e)
        {
            LabirintoTela1 labirintoTela1 = new LabirintoTela1();

            this.Hide();

            labirintoTela1.Show();

            labirintoTela1.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}
