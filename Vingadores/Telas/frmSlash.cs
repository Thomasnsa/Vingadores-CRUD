using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vingadores.Telas
{
    public partial class frmSlash : Form
    {
        public frmSlash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmVingadores tela = new frmVingadores();
            tela.Show();

            timer1.Stop();
            Hide();
        }
    }
}
