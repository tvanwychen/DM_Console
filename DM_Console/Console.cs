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
using DM_Console.BL.Models;
using System.Data.Entity;
using System.IO;

namespace DM_Console
{
    public partial class FrmConsole : Form
    {
        //Creating lists to store infromation from database
        List<Character> players = new List<Character>();
        List<Character> enemies = new List<Character>();
        List<Character> friendlies = new List<Character>();
        List<Character> bosses = new List<Character>();
        List<Note> notes = new List<Note>();
        Note displaynote = new Note();
        string notename;
        public FrmConsole()
        {
            InitializeComponent();
            UpdateNotesBox();
        }

        public void UpdateNotesBox()
        {
            //Pulling datafrom database
            using (Entities1 dc = new Entities1())
            {                              
                dc.tblPlayers.ToList().ForEach(x => players.Add(
                    new Character { Id = x.Id, Type = x.Type, Name = x.Name, Strength = x.Strength, Dexterity = x.Dexterity, Constitution = x.Constitution, 
                        Intelligence = x.Intelligence, Wisdon = x.Wisdom, Charisma = x.Charisma, HitPoints = x.HitPoints, ArmorClass = x.ArmorClass, 
                        Initiative = x.Initiative, Speed = x.Speed, STSuccessCount = (int)x.STSuccessCount, STFailCount = (int)x.STFailCount, AdditionDetails = x.AdditionalDetails}));

                dc.tblEnemys.ToList().ForEach(x => enemies.Add(
                    new Character { Id = x.Id, Type = x.Type, Name = x.Name, Strength = x.Strength, Dexterity = x.Dexterity, Constitution = x.Constitution, 
                        Intelligence = x.Intelligence, Wisdon = x.Wisdom, Charisma = x.Charisma, HitPoints = x.HitPoints, ArmorClass = x.ArmorClass, 
                        Initiative = x.Initiative, Speed = x.Speed, STSuccessCount = (int)x.STSuccessCount, STFailCount = (int)x.STFailCount, AdditionDetails = x.AdditionalDetails}));

                dc.tblFriendlys.ToList().ForEach(x => friendlies.Add(
                    new Character { Id = x.Id, Type = x.Type, Name = x.Name, Strength = x.Strength, Dexterity = x.Dexterity, Constitution = x.Constitution, 
                        Intelligence = x.Intelligence, Wisdon = x.Wisdom, Charisma = x.Charisma, HitPoints = x.HitPoints, ArmorClass = x.ArmorClass, 
                        Initiative = x.Initiative, Speed = x.Speed, STSuccessCount = (int)x.STSuccessCount, STFailCount = (int)x.STFailCount, AdditionDetails = x.AdditionalDetails}));

                dc.tblBosses.ToList().ForEach(x => bosses.Add(
                    new Character { Id = x.Id, Type = x.Type, Name = x.Name, Strength = x.Strength, Dexterity = x.Dexterity, Constitution = x.Constitution, 
                        Intelligence = x.Intelligence, Wisdon = x.Wisdom, Charisma = x.Charisma, HitPoints = x.HitPoints, ArmorClass = x.ArmorClass, 
                        Initiative = x.Initiative, Speed = x.Speed, STSuccessCount = (int)x.STSuccessCount, STFailCount = (int)x.STFailCount, AdditionDetails = x.AdditionalDetails}));

                dc.tblNotes.ToList().ForEach(x => notes.Add(new Note { Id = x.Id, Name = x.Name, Description = x.Description }));
            }

            //Filtering names from Character objects to be displayed on UI listboxes
            List<string> playername = new List<string>();
            foreach (Character player in players)
            {
                playername.Add(player.Name);
            }
            List<string> enemyname = new List<string>();
            foreach (Character enemy in enemies)
            {
                enemyname.Add(enemy.Name);
            }
            List<string> friedlyname = new List<string>();
            foreach (Character friend in friendlies)
            {
                friedlyname.Add(friend.Name);
            }
            List<string> bossname = new List<string>();
            foreach (Character boss in bosses)
            {
                bossname.Add(boss.Name);
            }
            List<string> notename = new List<string>();
            foreach (Note note in notes)
            {
                notename.Add(note.Name);
            }

            //Displaying character names on UI listboxes
            lbxPlayers.DataSource = playername;
            lbxEnemies.DataSource = enemyname;
            lbxFriendlies.DataSource = friedlyname;
            lbxBosses.DataSource = bossname;
            lbxNotes.DataSource = notename;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Generates new form depending on what tab you are on currently on to correspond with creation
            if (tabControl.SelectedTab == tabNote)
            {
                //Shows create form for Notes
                Form newNote = new NewNote();
                newNote.ShowDialog();
            }
            else
            {
                //Shows create from for Charactoers
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

        private void lbxNotes_DoubleClick(object sender, EventArgs e)
        {
            notename = lbxNotes.SelectedValue.ToString();
            displaynote = notes.Find(x => x.Name == notename);
            txtNotes.Text = displaynote.Description;
        }

        private void txtNotes_Leave(object sender, EventArgs e)
        {
            using (Entities1 dc = new Entities1())
            {
                tblNote row = dc.tblNotes.FirstOrDefault(x => x.Name == notename);
                row.Description = txtNotes.Text;
                dc.SaveChanges();
                UpdateNotesBox();
            }
        }
    }
}
