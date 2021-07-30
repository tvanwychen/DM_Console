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

namespace DM_Console
{
    public partial class FrmConsole : Form
    {
        public FrmConsole()
        {
            InitializeComponent();

            using (Entities dc = new Entities())
            {
                DbContextTransaction transaction = null;

            }
        }
    }
}
