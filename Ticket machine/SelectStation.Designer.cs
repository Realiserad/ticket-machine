namespace Ticket_machine
{
    partial class SelectStation
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
            this.filterBox = new System.Windows.Forms.ListBox();
            this.stations = new System.Windows.Forms.ListBox();
            this.filter = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.container.Controls.Add(this.filterBox);
            this.container.Controls.Add(this.stations);
            this.container.Controls.Add(this.filter);
            this.container.Controls.Add(this.title);
            this.container.Controls.Add(this.back);
            this.container.Location = new System.Drawing.Point(50, 38);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1158, 777);
            this.container.TabIndex = 6;
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.filterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterBox.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.ForeColor = System.Drawing.Color.Black;
            this.filterBox.FormattingEnabled = true;
            this.filterBox.ItemHeight = 56;
            this.filterBox.Items.AddRange(new object[] {
            "ABCD",
            "EFGH",
            "JKLM",
            "NOPR",
            "STUV",
            "YÅÄÖ"});
            this.filterBox.Location = new System.Drawing.Point(906, 186);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(202, 394);
            this.filterBox.Sorted = true;
            this.filterBox.TabIndex = 16;
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // stations
            // 
            this.stations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.stations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stations.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stations.ForeColor = System.Drawing.Color.Black;
            this.stations.FormattingEnabled = true;
            this.stations.ItemHeight = 56;
            this.stations.Location = new System.Drawing.Point(39, 186);
            this.stations.Name = "stations";
            this.stations.Size = new System.Drawing.Size(751, 562);
            this.stations.Sorted = true;
            this.stations.TabIndex = 15;
            this.stations.Click += new System.EventHandler(this.stations_Click);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.Black;
            this.filter.Location = new System.Drawing.Point(893, 106);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(236, 77);
            this.filter.TabIndex = 14;
            this.filter.Text = "Filtrera";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(26, 106);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(372, 77);
            this.title.TabIndex = 13;
            this.title.Text = "Välj station";
            // 
            // back
            // 
            this.back.BackgroundImage = global::Ticket_machine.Properties.Resources.ArrowGreen;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(866, 617);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.back.Size = new System.Drawing.Size(263, 131);
            this.back.TabIndex = 9;
            this.back.Text = "Klar";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SelectStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 853);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectStation";
            this.ShowInTaskbar = false;
            this.Text = "SelectStation";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox filterBox;
        private System.Windows.Forms.ListBox stations;
        private System.Windows.Forms.Label filter;
    }
}