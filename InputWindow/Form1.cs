using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace InputWindow
{
    public partial class Form1 : Form
    {
        string RaffleName = "AttackOnKitten";
        Raffle currentRaffle;

        public Form1()
        {
            InitializeComponent();
            string s = Environment.CurrentDirectory + "\\SavedFiles\\" + RaffleName + ".xml";

            if (File.Exists(s))
            {
                string path = Environment.CurrentDirectory + "\\SavedFiles\\";
                var relay = Directory.GetFiles(path);

                foreach(var v in relay)
                {
                    if(v.ToString() == s)
                    {
                        currentRaffle = Utilities.Serializer.DeserializeXML<Raffle>(RaffleName + ".xml");
                        WinnerButton.Visible = true;
                    }
                }
            }
            else
            {
                currentRaffle = new Raffle();
            }
        }

        public void SaveRaffle()
        {
            Utilities.Serializer.SerializeXML(RaffleName, currentRaffle);
        }

        public void AddToRaffle(object sender, EventArgs e)
        {
            Winner.Visible = false;
            if(EntryName.Text != "" && NumberEntries.Value != 0)
            {
                InputError.Visible = false;
                currentRaffle.AddCandidate(EntryName.Text, (int)NumberEntries.Value);
                EntryName.Text = "";
                NumberEntries.Value = 0;
                SaveRaffle();
                WinnerButton.Visible = true;
            }
            else
            {
                InputError.Visible = true;
            }

            
        }

        public void PickWinner(object sender, EventArgs e)
        {
            Winner.Visible = true;
            Winner.Text = "Winner is: " + currentRaffle.PickWinner().Name;
        }
    }
}
