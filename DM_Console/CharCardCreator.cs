using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DM_Console.PL;

namespace DM_Console
{
    public partial class CharCardCreator : Form
    {
        public CharCardCreator()
        {
            InitializeComponent();
            List<string> types = new List<string>();
            types.Add("Player");
            types.Add("Friendly");
            types.Add("Enemy");
            types.Add("Boss");

            cmbBxType.DataSource = types;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbBxType.Text != "" && txtBxName.Text != "")
            {
                using (Entities dc = new Entities())
                { 
                    if (cmbBxType.SelectedItem == "Player")
                    {
                        tblPlayer newplayer = new tblPlayer();
                        newplayer.Id = dc.tblPlayers.Any() ? dc.tblPlayers.Max(x => x.Id) + 1 : 1;
                        newplayer.Type = "Player";
                        newplayer.Name = txtBxName.Text;
                        newplayer.Strength = txtBxStr.Text;
                        newplayer.Dexterity = txtBxDex.Text;
                        newplayer.Constitution = txtBxCon.Text;
                        newplayer.Intelligence = txtBxInt.Text;
                        newplayer.Wisdom = txtBxWis.Text;
                        newplayer.Charisma = txtBxCha.Text;
                        newplayer.HitPoints = txtBxHP.Text;
                        newplayer.ArmorClass = txtBxAC.Text;
                        newplayer.Initiative = string.Empty;
                        newplayer.Speed = txtBxSpd.Text;
                        newplayer.STSuccessCount = 0;
                        newplayer.STFailCount = 0;
                        newplayer.AdditionalDetails = txtBxDetail.Text;

                        dc.tblPlayers.Add(newplayer);
                        dc.SaveChanges();

                    }
                    else if (cmbBxType.SelectedItem == "Friendly")
                    {
                        tblFriendly newfriendly = new tblFriendly();
                        newfriendly.Id = dc.tblPlayers.Any() ? dc.tblPlayers.Max(x => x.Id) + 1 : 1;
                        newfriendly.Type = "Friendly";
                        newfriendly.Name = txtBxName.Text;
                        newfriendly.Strength = txtBxStr.Text;
                        newfriendly.Dexterity = txtBxDex.Text;
                        newfriendly.Constitution = txtBxCon.Text;
                        newfriendly.Intelligence = txtBxInt.Text;
                        newfriendly.Wisdom = txtBxWis.Text;
                        newfriendly.Charisma = txtBxCha.Text;
                        newfriendly.HitPoints = txtBxHP.Text;
                        newfriendly.ArmorClass = txtBxAC.Text;
                        newfriendly.Initiative = string.Empty;
                        newfriendly.Speed = txtBxSpd.Text;
                        newfriendly.STSuccessCount = 0;
                        newfriendly.STFailCount = 0;
                        newfriendly.AdditionalDetails = txtBxDetail.Text;

                        dc.tblFriendlys.Add(newfriendly);
                        dc.SaveChanges();
                    }
                    else if (cmbBxType.SelectedItem == "Enemy")
                    {
                        tblEnemy newenemy = new tblEnemy();
                        newenemy.Id = dc.tblPlayers.Any() ? dc.tblPlayers.Max(x => x.Id) + 1 : 1;
                        newenemy.Type = "Enemy";
                        newenemy.Name = txtBxName.Text;
                        newenemy.Strength = txtBxStr.Text;
                        newenemy.Dexterity = txtBxDex.Text;
                        newenemy.Constitution = txtBxCon.Text;
                        newenemy.Intelligence = txtBxInt.Text;
                        newenemy.Wisdom = txtBxWis.Text;
                        newenemy.Charisma = txtBxCha.Text;
                        newenemy.HitPoints = txtBxHP.Text;
                        newenemy.ArmorClass = txtBxAC.Text;
                        newenemy.Initiative = string.Empty;
                        newenemy.Speed = txtBxSpd.Text;
                        newenemy.STSuccessCount = 0;
                        newenemy.STFailCount = 0;
                        newenemy.AdditionalDetails = txtBxDetail.Text;

                        dc.tblEnemys.Add(newenemy);
                        dc.SaveChanges();
                    }
                    else
                    {
                        tblBoss newboss = new tblBoss();
                        newboss.Id = dc.tblPlayers.Any() ? dc.tblPlayers.Max(x => x.Id) + 1 : 1;
                        newboss.Type = "Boss";
                        newboss.Name = txtBxName.Text;
                        newboss.Strength = txtBxStr.Text;
                        newboss.Dexterity = txtBxDex.Text;
                        newboss.Constitution = txtBxCon.Text;
                        newboss.Intelligence = txtBxInt.Text;
                        newboss.Wisdom = txtBxWis.Text;
                        newboss.Charisma = txtBxCha.Text;
                        newboss.HitPoints = txtBxHP.Text;
                        newboss.ArmorClass = txtBxAC.Text;
                        newboss.Initiative = string.Empty;
                        newboss.Speed = txtBxSpd.Text;
                        newboss.STSuccessCount = 0;
                        newboss.STFailCount = 0;
                        newboss.AdditionalDetails = txtBxDetail.Text;

                        dc.tblBosses.Add(newboss);
                        dc.SaveChanges();
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("A type and a Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
