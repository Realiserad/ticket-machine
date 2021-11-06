using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ticket_machine
{
    public partial class SelectStation : Form
    {
        public string selectedStation;
        private string[] allStations;
        Form parent;

        public SelectStation(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            allStations = new string[]
            {
                "Abrahamsberg",
                "Bergshamra",
                "Enskede gård",
                "Fittja",
                "Hammarbyhöjden",
                "Karlaplan",
                "Mörby centrum",
                "Odenplan",
                "Rådhuset",
                "Stureby",
                "Tekniska högskolan",
                "Universitetet",
                "Vårby gård",
                "Västra skogen",
                "Östermalmstorg",
            };
            foreach (string item in allStations)
            {
                stations.Items.Add(item);
            }
        }

        private void stations_Click(object sender, EventArgs e)
        {
            selectedStation = stations.SelectedItem.ToString();
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int f = filterBox.SelectedIndex;
            if (f == 0)
            {
                Regex regex = new Regex("[ABCD]");
                stations.Items.Clear();
                foreach (string item in allStations)
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        stations.Items.Add(item);
                    }
                }
            }
            else if (f == 1)
            {
                Regex regex = new Regex("[EFGH]");
                stations.Items.Clear();
                foreach (string item in allStations)
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        stations.Items.Add(item);
                    }
                }
            }
            else if (f == 2)
            {
                Regex regex = new Regex("[JKLM]");
                stations.Items.Clear();
                foreach (string item in allStations)
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        stations.Items.Add(item);
                    }
                }
            }
            else if (f == 3)
            {
                Regex regex = new Regex("[NOPR]");
                stations.Items.Clear();
                foreach (string item in allStations)
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        stations.Items.Add(item);
                    }
                }
            }
            else if (f == 4)
            {
                Regex regex = new Regex("[STUV]");
                stations.Items.Clear();
                foreach (string item in allStations)
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        stations.Items.Add(item);
                    }
                }
            }
            else if (f == 5)
            {
                Regex regex = new Regex("[YÅÄÖ]");
                stations.Items.Clear();
                foreach (string item in allStations)
                {
                    if (regex.IsMatch(item[0].ToString()))
                    {
                        stations.Items.Add(item);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // We only hide beacause our parent needs to know which station was selected
            parent.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Main.root.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
