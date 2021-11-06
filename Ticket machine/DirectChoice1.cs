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
    public partial class DirectChoice1 : Form
    {
        Form parent;

        public DirectChoice1(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            next.BackgroundImage = Ticket_machine.Properties.Resources.ArrowGreen;
            next.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Main.root.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void back_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
