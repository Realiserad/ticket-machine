using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_machine
{
    public partial class Main : Form
    {
        public static Form root;
        private Button selected;
        // 0 = swedish, 1 = english
        private int lang;

        public Main()
        {
            InitializeComponent();
            root = this;
            selected = manualChoice;
            infoBox.Text = Ticket_machine.Properties.Resources.manualChoice_info_sv;
            lang = 0;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                root.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cardContents_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selected.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGrey;
            button.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            selected = button;
            if (lang == 0)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.cardContents_info_sv;
            }
            if (lang == 1)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.cardContents_info_en;
            }
        }

        private void manualChoice_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selected.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGrey;
            button.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            selected = button;
            if (lang == 0)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.manualChoice_info_sv;
            }
            if (lang == 1)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.manualChoice_info_en;
            }
        }

        private void directChoice_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selected.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGrey;
            button.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            selected = button;
            if (lang == 0)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.directChoice_info_sv;
            }
            if (lang == 1)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.directChoice_info_en;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (selected == manualChoice)
            {
                ManualChoice1 manualChoice1 = new ManualChoice1(this);
                manualChoice1.Show();
                this.Hide();
            }
            else if (selected == directChoice)
            {
                DirectChoice1 directChoice1 = new DirectChoice1(this);
                directChoice1.Show();
                this.Hide();
            }
        }

        private void english_Click(object sender, EventArgs e)
        {
            manualChoice.Text = Ticket_machine.Properties.Resources.manualChoice_title_en;
            directChoice.Text = Ticket_machine.Properties.Resources.directChoice_title_en;
            cardContents.Text = Ticket_machine.Properties.Resources.cardContents_title_en;
            next.Text = Ticket_machine.Properties.Resources.next_title_en;
            if (selected == manualChoice)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.manualChoice_info_en;
            }
            if (selected == directChoice)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.directChoice_info_en;
            }
            if (selected == cardContents)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.cardContents_info_en;
            }
            lang = 1;
        }

        private void swedish_Click(object sender, EventArgs e)
        {
            manualChoice.Text = Ticket_machine.Properties.Resources.manualChoice_title_sv;
            directChoice.Text = Ticket_machine.Properties.Resources.directChoice_title_sv;
            cardContents.Text = Ticket_machine.Properties.Resources.cardContents_title_sv;
            next.Text = Ticket_machine.Properties.Resources.next_title_sv;
            if (selected == manualChoice)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.manualChoice_info_sv;
            }
            if (selected == directChoice)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.directChoice_info_sv;
            }
            if (selected == cardContents)
            {
                infoBox.Text = Ticket_machine.Properties.Resources.cardContents_info_sv;
            }
            lang = 0;
        }
    }
}
