﻿using System;
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
        public FrmConsole()
        {
            InitializeComponent();

            //Pulling datafrom database
            using (Entities dc = new Entities())
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

            //Displaying character names on UI listboxes
            lbxPlayers.DataSource = playername;
            lbxEnemies.DataSource = enemyname;
            lbxFriendlies.DataSource = friedlyname;
            lbxBosses.DataSource = bossname;
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
    }
}
