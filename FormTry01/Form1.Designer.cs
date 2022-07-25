namespace FormTry01
{
    partial class HotelReservation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelReservation));
            this.hotelName = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInitial = new System.Windows.Forms.DateTimePicker();
            this.dtInitialLabel = new System.Windows.Forms.Label();
            this.dtFinalLabel = new System.Windows.Forms.Label();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.dtUntil = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.typeRoom = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.hotelPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelName
            // 
            this.hotelName.AutoSize = true;
            this.hotelName.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelName.Location = new System.Drawing.Point(181, 9);
            this.hotelName.Name = "hotelName";
            this.hotelName.Size = new System.Drawing.Size(432, 59);
            this.hotelName.TabIndex = 0;
            this.hotelName.Text = "Super Cool Hotel";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(12, 123);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(314, 23);
            this.tbCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // dtInitial
            // 
            this.dtInitial.CustomFormat = "dd/MM/yyyy";
            this.dtInitial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInitial.Location = new System.Drawing.Point(12, 203);
            this.dtInitial.Name = "dtInitial";
            this.dtInitial.Size = new System.Drawing.Size(105, 23);
            this.dtInitial.TabIndex = 3;
            // 
            // dtInitialLabel
            // 
            this.dtInitialLabel.AutoSize = true;
            this.dtInitialLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInitialLabel.Location = new System.Drawing.Point(12, 186);
            this.dtInitialLabel.Name = "dtInitialLabel";
            this.dtInitialLabel.Size = new System.Drawing.Size(76, 14);
            this.dtInitialLabel.TabIndex = 4;
            this.dtInitialLabel.Text = "Initial Date";
            // 
            // dtFinalLabel
            // 
            this.dtFinalLabel.AutoSize = true;
            this.dtFinalLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalLabel.Location = new System.Drawing.Point(221, 186);
            this.dtFinalLabel.Name = "dtFinalLabel";
            this.dtFinalLabel.Size = new System.Drawing.Size(70, 14);
            this.dtFinalLabel.TabIndex = 6;
            this.dtFinalLabel.Text = "Final Date";
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reservationLabel.Location = new System.Drawing.Point(12, 159);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(105, 18);
            this.reservationLabel.TabIndex = 8;
            this.reservationLabel.Text = "Reservation";
            // 
            // dtUntil
            // 
            this.dtUntil.AutoSize = true;
            this.dtUntil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtUntil.Location = new System.Drawing.Point(155, 210);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(31, 13);
            this.dtUntil.TabIndex = 9;
            this.dtUntil.Text = "until";
            // 
            // dtFinal
            // 
            this.dtFinal.CustomFormat = "dd/MM/yyyy";
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinal.Location = new System.Drawing.Point(221, 203);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(105, 23);
            this.dtFinal.TabIndex = 10;
            // 
            // typeRoom
            // 
            this.typeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeRoom.FormattingEnabled = true;
            this.typeRoom.Items.AddRange(new object[] {
            "Luxurius and expensive with diamonds and gold",
            "Kinda cool and with some caviar snacks",
            "Cool but no expensive things (who needs it anyways)",
            "Cool, but kinda lame :(",
            "No room just leave me at the corridor",
            "I dunno what is a room"});
            this.typeRoom.Location = new System.Drawing.Point(12, 268);
            this.typeRoom.Name = "typeRoom";
            this.typeRoom.Size = new System.Drawing.Size(314, 23);
            this.typeRoom.TabIndex = 11;
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomLabel.Location = new System.Drawing.Point(12, 247);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(119, 18);
            this.roomLabel.TabIndex = 12;
            this.roomLabel.Text = "Type of Room";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(80, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 55);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // hotelPic
            // 
            this.hotelPic.Image = ((System.Drawing.Image)(resources.GetObject("hotelPic.Image")));
            this.hotelPic.Location = new System.Drawing.Point(410, 82);
            this.hotelPic.Name = "hotelPic";
            this.hotelPic.Size = new System.Drawing.Size(360, 324);
            this.hotelPic.TabIndex = 14;
            this.hotelPic.TabStop = false;
            // 
            // HotelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hotelPic);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.typeRoom);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtUntil);
            this.Controls.Add(this.reservationLabel);
            this.Controls.Add(this.dtFinalLabel);
            this.Controls.Add(this.dtInitialLabel);
            this.Controls.Add(this.dtInitial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.hotelName);
            this.Name = "HotelReservation";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hotelPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hotelName;
        private TextBox tbCustomer;
        private Label label2;
        private DateTimePicker dtInitial;
        private Label dtInitialLabel;
        private Label dtFinalLabel;
        private Label reservationLabel;
        private Label dtUntil;
        private DateTimePicker dtFinal;
        private ComboBox typeRoom;
        private Label roomLabel;
        private Button btnSubmit;
        private PictureBox hotelPic;
    }
}