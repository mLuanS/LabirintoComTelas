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
    public partial class LabirintoTela2 : Form
    {
        public LabirintoTela2()
        {
            InitializeComponent();
        }

        private void btnETela_Click(object sender, EventArgs e)
        {
            DialogResult userChoice = MessageBox.Show("Você perdeu\n Quer jogar de novo?","Information", MessageBoxButtons.YesNo );
                if (userChoice == DialogResult.Yes)
                {
                    this.Close();
                LabirintoInicio labirintoInicio = new LabirintoInicio();



                labirintoInicio.Show();

                labirintoInicio.Closed += (object s, EventArgs ev) => this.Show();
            }
                else
                {
                    Environment.Exit(1);
                }

        }

        private void btnBTela2_Click(object sender, EventArgs e)
        {
            LabirintoTela3 labirintoTela3 = new LabirintoTela3();

            this.Hide();

            labirintoTela3.Show();

            labirintoTela3.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void btnDTela2_Click(object sender, EventArgs e)
        {

        }
    }
}
