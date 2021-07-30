using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Console
{
    public partial class FrmConsole : Form
    {
        public FrmConsole()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form CharCard = new CharCardCreator();
            CharCard.ShowDialog();
        }

        private void btnCreatNote_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletNote_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
