namespace HotelReservationForm
{
    partial class Navigation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAReservationToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // makeAReservationToolStripMenuItem
            // 
            this.makeAReservationToolStripMenuItem.Name = "makeAReservationToolStripMenuItem";
            this.makeAReservationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.makeAReservationToolStripMenuItem.Text = "Make a reservation";
            this.makeAReservationToolStripMenuItem.Click += new System.EventHandler(this.MakeAReservationClick);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageReservationsToolStripMenuItem,
            this.viewArchiveToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // manageReservationsToolStripMenuItem
            // 
            this.manageReservationsToolStripMenuItem.Name = "manageReservationsToolStripMenuItem";
            this.manageReservationsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.manageReservationsToolStripMenuItem.Text = "Manage Reservations";
            this.manageReservationsToolStripMenuItem.Click += new System.EventHandler(this.ManageReservationsClick);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            this.viewArchiveToolStripMenuItem.Click += new System.EventHandler(this.ViewArchiveClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugReportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bugReportToolStripMenuItem
            // 
            this.bugReportToolStripMenuItem.Name = "bugReportToolStripMenuItem";
            this.bugReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bugReportToolStripMenuItem.Text = "Bug report";
            this.bugReportToolStripMenuItem.Click += new System.EventHandler(this.BugReportClick);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 612);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Navigation";
            this.Text = "Welcome to Cool Hotel!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
    }
}