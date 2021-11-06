namespace Ticket_machine
{
    partial class ManualChoice4
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
            this.summary = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.ticketCountPanel = new System.Windows.Forms.Panel();
            this.ticketCount = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.payWithSMS = new System.Windows.Forms.Button();
            this.payWithCard = new System.Windows.Forms.Button();
            this.ticketTypePanel = new System.Windows.Forms.Panel();
            this.ticketType = new System.Windows.Forms.Label();
            this.paper = new System.Windows.Forms.Button();
            this.access = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.addAnotherTicket = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.ticketCountPanel.SuspendLayout();
            this.paymentPanel.SuspendLayout();
            this.ticketTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.container.Controls.Add(this.addAnotherTicket);
            this.container.Controls.Add(this.summary);
            this.container.Controls.Add(this.infoBox);
            this.container.Controls.Add(this.ticketCountPanel);
            this.container.Controls.Add(this.paymentPanel);
            this.container.Controls.Add(this.ticketTypePanel);
            this.container.Controls.Add(this.button6);
            this.container.Controls.Add(this.button3);
            this.container.Controls.Add(this.button2);
            this.container.Controls.Add(this.back);
            this.container.Controls.Add(this.button4);
            this.container.Controls.Add(this.next);
            this.container.Location = new System.Drawing.Point(58, 12);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1158, 777);
            this.container.TabIndex = 8;
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary.ForeColor = System.Drawing.Color.Black;
            this.summary.Location = new System.Drawing.Point(697, 80);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(306, 41);
            this.summary.TabIndex = 22;
            this.summary.Text = "Sammanställning";
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.White;
            this.infoBox.Location = new System.Drawing.Point(704, 135);
            this.infoBox.Margin = new System.Windows.Forms.Padding(0);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(413, 332);
            this.infoBox.TabIndex = 28;
            this.infoBox.Text = "\n";
            // 
            // ticketCountPanel
            // 
            this.ticketCountPanel.Controls.Add(this.ticketCount);
            this.ticketCountPanel.Controls.Add(this.plus);
            this.ticketCountPanel.Controls.Add(this.button1);
            this.ticketCountPanel.Location = new System.Drawing.Point(14, 448);
            this.ticketCountPanel.Name = "ticketCountPanel";
            this.ticketCountPanel.Size = new System.Drawing.Size(674, 151);
            this.ticketCountPanel.TabIndex = 27;
            this.ticketCountPanel.Visible = false;
            // 
            // ticketCount
            // 
            this.ticketCount.AutoSize = true;
            this.ticketCount.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketCount.ForeColor = System.Drawing.Color.Black;
            this.ticketCount.Location = new System.Drawing.Point(18, 54);
            this.ticketCount.Name = "ticketCount";
            this.ticketCount.Size = new System.Drawing.Size(314, 41);
            this.ticketCount.TabIndex = 22;
            this.ticketCount.Text = "Antal biljetter: 1 st";
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.plus.BackgroundImage = global::Ticket_machine.Properties.Resources.plus;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(419, 21);
            this.plus.Name = "plus";
            this.plus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.plus.Size = new System.Drawing.Size(107, 107);
            this.plus.TabIndex = 23;
            this.plus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.button1.BackgroundImage = global::Ticket_machine.Properties.Resources.minus;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 21);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(107, 107);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymentPanel
            // 
            this.paymentPanel.Controls.Add(this.label1);
            this.paymentPanel.Controls.Add(this.payWithSMS);
            this.paymentPanel.Controls.Add(this.payWithCard);
            this.paymentPanel.Location = new System.Drawing.Point(14, 80);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(674, 171);
            this.paymentPanel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Betala med";
            // 
            // payWithSMS
            // 
            this.payWithSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.payWithSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payWithSMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payWithSMS.FlatAppearance.BorderSize = 0;
            this.payWithSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payWithSMS.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payWithSMS.Location = new System.Drawing.Point(335, 55);
            this.payWithSMS.Name = "payWithSMS";
            this.payWithSMS.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.payWithSMS.Size = new System.Drawing.Size(304, 96);
            this.payWithSMS.TabIndex = 15;
            this.payWithSMS.Text = "SMS";
            this.payWithSMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payWithSMS.UseVisualStyleBackColor = false;
            this.payWithSMS.Click += new System.EventHandler(this.payWithSMS_Click);
            // 
            // payWithCard
            // 
            this.payWithCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.payWithCard.BackgroundImage = global::Ticket_machine.Properties.Resources.cards;
            this.payWithCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payWithCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payWithCard.FlatAppearance.BorderSize = 0;
            this.payWithCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payWithCard.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payWithCard.Location = new System.Drawing.Point(25, 55);
            this.payWithCard.Name = "payWithCard";
            this.payWithCard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.payWithCard.Size = new System.Drawing.Size(304, 96);
            this.payWithCard.TabIndex = 21;
            this.payWithCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payWithCard.UseVisualStyleBackColor = false;
            this.payWithCard.Click += new System.EventHandler(this.payWithCard_Click);
            // 
            // ticketTypePanel
            // 
            this.ticketTypePanel.Controls.Add(this.ticketType);
            this.ticketTypePanel.Controls.Add(this.paper);
            this.ticketTypePanel.Controls.Add(this.access);
            this.ticketTypePanel.Location = new System.Drawing.Point(14, 257);
            this.ticketTypePanel.Name = "ticketTypePanel";
            this.ticketTypePanel.Size = new System.Drawing.Size(674, 185);
            this.ticketTypePanel.TabIndex = 25;
            this.ticketTypePanel.Visible = false;
            // 
            // ticketType
            // 
            this.ticketType.AutoSize = true;
            this.ticketType.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketType.ForeColor = System.Drawing.Color.Black;
            this.ticketType.Location = new System.Drawing.Point(18, 0);
            this.ticketType.Name = "ticketType";
            this.ticketType.Size = new System.Drawing.Size(229, 41);
            this.ticketType.TabIndex = 18;
            this.ticketType.Text = "Typ av biljett";
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paper.FlatAppearance.BorderSize = 0;
            this.paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paper.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper.Location = new System.Drawing.Point(25, 58);
            this.paper.Name = "paper";
            this.paper.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.paper.Size = new System.Drawing.Size(304, 96);
            this.paper.TabIndex = 19;
            this.paper.Text = "Papper";
            this.paper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paper.UseVisualStyleBackColor = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // access
            // 
            this.access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.access.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.access.Cursor = System.Windows.Forms.Cursors.Hand;
            this.access.FlatAppearance.BorderSize = 0;
            this.access.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.access.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access.Location = new System.Drawing.Point(335, 58);
            this.access.Name = "access";
            this.access.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.access.Size = new System.Drawing.Size(304, 96);
            this.access.TabIndex = 20;
            this.access.Text = "Accesskort";
            this.access.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.access.UseVisualStyleBackColor = false;
            this.access.Click += new System.EventHandler(this.access_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Ticket_machine.Properties.Resources.stepDone;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(582, 630);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 131);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Ticket_machine.Properties.Resources.stepDone;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(445, 630);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 131);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Ticket_machine.Properties.Resources.stepDone;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(308, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 131);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
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
            this.button4.Location = new System.Drawing.Point(717, 630);
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
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(854, 630);
            this.next.Name = "next";
            this.next.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.next.Size = new System.Drawing.Size(263, 131);
            this.next.TabIndex = 4;
            this.next.Text = "Slutför";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.next.UseVisualStyleBackColor = true;
            // 
            // addAnotherTicket
            // 
            this.addAnotherTicket.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGrey;
            this.addAnotherTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAnotherTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAnotherTicket.FlatAppearance.BorderSize = 0;
            this.addAnotherTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnotherTicket.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnotherTicket.Location = new System.Drawing.Point(854, 493);
            this.addAnotherTicket.Name = "addAnotherTicket";
            this.addAnotherTicket.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addAnotherTicket.Size = new System.Drawing.Size(263, 131);
            this.addAnotherTicket.TabIndex = 29;
            this.addAnotherTicket.Text = "Lägg till biljett";
            this.addAnotherTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAnotherTicket.UseVisualStyleBackColor = true;
            // 
            // ManualChoice4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 815);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManualChoice4";
            this.ShowInTaskbar = false;
            this.Text = "ManualChoice4";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ticketCountPanel.ResumeLayout(false);
            this.ticketCountPanel.PerformLayout();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.ticketTypePanel.ResumeLayout(false);
            this.ticketTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button payWithSMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label ticketCount;
        private System.Windows.Forms.Button payWithCard;
        private System.Windows.Forms.Button access;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Label ticketType;
        private System.Windows.Forms.Panel ticketCountPanel;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Panel ticketTypePanel;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Button addAnotherTicket;
    }
}