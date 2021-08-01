using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DM_Console.PL;
using System.Data.Entity;
using System.IO;

namespace DM_Console
{
    public partial class FrmConsole : Form
    {
        string filepath;
        public FrmConsole()
        {
            InitializeComponent();
            using (Entities dc = new Entities())
            {
                DbContextTransaction transaction = null;               
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabNote)
            {
                MessageBox.Show("Notes");
            }
            else
            {
                Form charCard = new CharCardCreator();
                charCard.ShowDialog();
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabNote)
            {
                MessageBox.Show("Notes");
            }
            else
            {
                MessageBox.Show("Else");
            }
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            Form filePath = new NewNote();
            filePath.ShowDialog();
        }
    }
}
