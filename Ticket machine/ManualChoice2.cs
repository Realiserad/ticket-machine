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
    public partial class ManualChoice2 : Form
    {
        private Button selected;
        private Form parent;
        private List<Object> data;

        public ManualChoice2(Form parent, List<Object> data)
        {
            InitializeComponent();
            this.parent = parent;
            selected = oneWayTicket;
            this.data = data;
            infoBox.Text = Ticket_machine.Properties.Resources.oneWayTicket_info_sv;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Main.root.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void oneWayTicket_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            selected.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGrey;
            selected = button;
            infoBox.Text = Ticket_machine.Properties.Resources.oneWayTicket_info_sv;
        }

        private void twoWayTicket_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            selected.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGrey;
            selected = button;
            infoBox.Text = Ticket_machine.Properties.Resources.twoWayTicket_info_sv;
        }

        private void back_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            data.Add(selected);
            if (selected == oneWayTicket)
            {
                ManualChoice3 manualChoice3 = new ManualChoice3(this, data);
                manualChoice3.Show();
                this.Hide();
            }
        }
    }
}
