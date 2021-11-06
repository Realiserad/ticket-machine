namespace Ticket_machine
{
    partial class ManualChoice1
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
            this.student = new System.Windows.Forms.Button();
            this.senior = new System.Windows.Forms.Button();
            this.adult = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.youth = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.container.Controls.Add(this.student);
            this.container.Controls.Add(this.senior);
            this.container.Controls.Add(this.adult);
            this.container.Controls.Add(this.title);
            this.container.Controls.Add(this.button6);
            this.container.Controls.Add(this.button3);
            this.container.Controls.Add(this.button2);
            this.container.Controls.Add(this.back);
            this.container.Controls.Add(this.button4);
            this.container.Controls.Add(this.youth);
            this.container.Controls.Add(this.next);
            this.container.Controls.Add(this.infoBox);
            this.container.Location = new System.Drawing.Point(58, 12);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1158, 829);
            this.container.TabIndex = 5;
            // 
            // student
            // 
            this.student.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGrey;
            this.student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student.FlatAppearance.BorderSize = 0;
            this.student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(39, 526);
            this.student.Name = "student";
            this.student.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.student.Size = new System.Drawing.Size(272, 131);
            this.student.TabIndex = 16;
            this.student.Text = "Student fyllda 20";
            this.student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // senior
            // 
            this.senior.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGrey;
            this.senior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.senior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.senior.FlatAppearance.BorderSize = 0;
            this.senior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.senior.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senior.Location = new System.Drawing.Point(39, 391);
            this.senior.Name = "senior";
            this.senior.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.senior.Size = new System.Drawing.Size(263, 131);
            this.senior.TabIndex = 15;
            this.senior.Text = "Pensionär";
            this.senior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.senior.UseVisualStyleBackColor = true;
            this.senior.Click += new System.EventHandler(this.senior_Click);
            // 
            // adult
            // 
            this.adult.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGrey;
            this.adult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adult.FlatAppearance.BorderSize = 0;
            this.adult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adult.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult.Location = new System.Drawing.Point(39, 254);
            this.adult.Name = "adult";
            this.adult.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.adult.Size = new System.Drawing.Size(263, 131);
            this.adult.TabIndex = 14;
            this.adult.Text = "Vuxen";
            this.adult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adult.UseVisualStyleBackColor = true;
            this.adult.Click += new System.EventHandler(this.adult_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(26, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(228, 77);
            this.title.TabIndex = 13;
            this.title.Text = "Jag är";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Ticket_machine.Properties.Resources.step;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(717, 677);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 131);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Ticket_machine.Properties.Resources.step;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(580, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 131);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Ticket_machine.Properties.Resources.step;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(443, 677);
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
            this.back.Location = new System.Drawing.Point(39, 677);
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
            this.button4.Location = new System.Drawing.Point(308, 677);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 131);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // youth
            // 
            this.youth.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGreen;
            this.youth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.youth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youth.FlatAppearance.BorderSize = 0;
            this.youth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youth.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youth.Location = new System.Drawing.Point(39, 117);
            this.youth.Name = "youth";
            this.youth.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.youth.Size = new System.Drawing.Size(263, 131);
            this.youth.TabIndex = 5;
            this.youth.Text = "Under 20";
            this.youth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.youth.UseVisualStyleBackColor = true;
            this.youth.Click += new System.EventHandler(this.youth_Click);
            // 
            // next
            // 
            this.next.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGreen;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(854, 677);
            this.next.Name = "next";
            this.next.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.next.Size = new System.Drawing.Size(263, 131);
            this.next.TabIndex = 4;
            this.next.Text = "Framåt";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.Location = new System.Drawing.Point(329, 117);
            this.infoBox.Margin = new System.Windows.Forms.Padding(0);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(788, 540);
            this.infoBox.TabIndex = 3;
            this.infoBox.Text = "\n";
            // 
            // ManualChoice1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 853);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManualChoice1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualChoice1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Button youth;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button adult;
        private System.Windows.Forms.Button senior;
        private System.Windows.Forms.Button student;


    }
}