namespace Ticket_machine
{
    partial class DirectChoice1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.title2 = new System.Windows.Forms.Label();
            this.tickets = new System.Windows.Forms.ListBox();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.container.Controls.Add(this.title2);
            this.container.Controls.Add(this.tickets);
            this.container.Controls.Add(this.infoBox);
            this.container.Controls.Add(this.title);
            this.container.Controls.Add(this.button6);
            this.container.Controls.Add(this.back);
            this.container.Controls.Add(this.button4);
            this.container.Controls.Add(this.next);
            this.container.Location = new System.Drawing.Point(58, 12);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1158, 777);
            this.container.TabIndex = 8;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.Black;
            this.title2.Location = new System.Drawing.Point(743, 95);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(334, 77);
            this.title2.TabIndex = 16;
            this.title2.Text = "Förklaring";
            // 
            // tickets
            // 
            this.tickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.tickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tickets.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets.ForeColor = System.Drawing.Color.Black;
            this.tickets.FormattingEnabled = true;
            this.tickets.ItemHeight = 56;
            this.tickets.Items.AddRange(new object[] {
            "Enkelbiljett reducerat pris",
            "Enkelbiljett fullt pris",
            "1-dagarskort reducerat pris",
            "1-dagarskort fullt pris",
            "3-dagarskort reducerat pris",
            "3-dagarskort fullt pris",
            "7-dagarskort reducerat pris",
            "7-dagarskort fullt pris",
            "30-dagarsbiljett reducerat pris",
            "30-dagarskort fullt pris",
            "60-dagarskort reducerat pris",
            "60-dagarskort fullt pris",
            "90-dagarskort reducerat pris",
            "90-dagarskort fullt pris",
            "Terminskort Skola",
            "Terminskort Skola + Fritid"});
            this.tickets.Location = new System.Drawing.Point(39, 197);
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(703, 394);
            this.tickets.TabIndex = 15;
            this.tickets.SelectedIndexChanged += new System.EventHandler(this.tickets_SelectedIndexChanged);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.Black;
            this.infoBox.Location = new System.Drawing.Point(756, 197);
            this.infoBox.Margin = new System.Windows.Forms.Padding(0);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(361, 394);
            this.infoBox.TabIndex = 14;
            this.infoBox.Text = "Homer gillar donuts.";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(26, 95);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(338, 77);
            this.title.TabIndex = 13;
            this.title.Text = "Välj biljett";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Ticket_machine.Properties.Resources.step;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(583, 630);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 131);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGreenBack;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(39, 630);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.back.Size = new System.Drawing.Size(263, 131);
            this.back.TabIndex = 9;
            this.back.Text = "Bakåt";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Ticket_machine.Properties.Resources.stepSelected;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(446, 630);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 131);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGrey;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Enabled = false;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(854, 630);
            this.next.Name = "next";
            this.next.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.next.Size = new System.Drawing.Size(263, 131);
            this.next.TabIndex = 4;
            this.next.Text = "Framåt";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.next.UseVisualStyleBackColor = true;
            // 
            // DirectChoice1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 777);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectChoice1";
            this.Text = "DirectChoice1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.ListBox tickets;
    }
}