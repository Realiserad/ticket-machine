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
    public partial class ManualChoice4 : Form
    {
        private Form parent;
        private Button paymentMethod;
        private Button ticketFormat;
        private int numberOfTickets;
        private List<Object> data;

        public ManualChoice4(Form parent, List<Object> data)
        {
            InitializeComponent();
            numberOfTickets = 1;
            this.parent = parent;
            this.data = data;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Main.root.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void payWithCard_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = null;
            button.BackColor = Color.FromArgb(56, 192, 49);
            payWithSMS.BackColor = Color.FromArgb(164, 164, 163);
            button.Text = Ticket_machine.Properties.Resources.creditCard_title_sv;
            paymentMethod = button;
            ticketTypePanel.Visible = true;
        }

        private void payWithSMS_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(56, 192, 49);
            payWithCard.BackColor = Color.FromArgb(84, 84, 84);
            paymentMethod = button;
            ticketTypePanel.Visible = true;
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ticketFormat = button;
            button.BackColor = Color.FromArgb(56, 192, 49);
            access.BackColor = Color.FromArgb(164, 164, 163);
            ticketCountPanel.Visible = true;
            next.Enabled = true;
            next.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            createSummary();
        }

        private void access_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ticketFormat = button;
            button.BackColor = Color.FromArgb(56, 192, 49);
            paper.BackColor = Color.FromArgb(164, 164, 163);
            ticketCountPanel.Visible = true;
            next.Enabled = true;
            next.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            createSummary();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            numberOfTickets++;
            ticketCount.Text = Ticket_machine.Properties.Resources.ticketCount_title1_sv + " " + numberOfTickets +
                " " + Ticket_machine.Properties.Resources.ticketCount_title2_sv;
            createSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numberOfTickets > 1)
            {
                numberOfTickets--;
                ticketCount.Text = Ticket_machine.Properties.Resources.ticketCount_title1_sv + " " + numberOfTickets +
                    " " + Ticket_machine.Properties.Resources.ticketCount_title2_sv;
                createSummary();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void createSummary()
        {
            string summary = "";
            // Ticket type
            summary += Ticket_machine.Properties.Resources.ticketType_title_sv +
                " " + Ticket_machine.Properties.Resources.adultOneWayTicket_desc_sv + "\n\n";
            // Zones
            summary += Ticket_machine.Properties.Resources.zones_title_sv + 
                " " + "A" + "\n\n";
            // Expiration time
            summary += Ticket_machine.Properties.Resources.expirationTime_title_sv +
                " " + Ticket_machine.Properties.Resources.expirationTime_oneWayTicket_desc_sv + "\n\n";
            // Total price
            summary += Ticket_machine.Properties.Resources.totalPrice_title_sv +
                " " + numberOfTickets * 25 + "\n\n";
            // Ticket format
            if (ticketFormat == access)
            {
                summary += Ticket_machine.Properties.Resources.accessTicket_desc_sv;
            } 
            else 
            {
                summary += Ticket_machine.Properties.Resources.paperTicket_desc_sv;
            }

            infoBox.Text = summary;
        }
    }
}
