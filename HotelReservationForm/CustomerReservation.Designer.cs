namespace HotelReservationForm
{
    partial class CustomerReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.dtInitialLabel = new System.Windows.Forms.Label();
            this.dtInitial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFinalLabel = new System.Windows.Forms.Label();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.typeRoom = new System.Windows.Forms.ComboBox();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cool Hotel";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(26, 119);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(124, 20);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(30, 143);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(282, 20);
            this.tbCustomer.TabIndex = 2;
            // 
            // dtInitialLabel
            // 
            this.dtInitialLabel.AutoSize = true;
            this.dtInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInitialLabel.Location = new System.Drawing.Point(27, 208);
            this.dtInitialLabel.Name = "dtInitialLabel";
            this.dtInitialLabel.Size = new System.Drawing.Size(65, 15);
            this.dtInitialLabel.TabIndex = 3;
            this.dtInitialLabel.Text = "Initial Date";
            // 
            // dtInitial
            // 
            this.dtInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInitial.Location = new System.Drawing.Point(30, 226);
            this.dtInitial.Name = "dtInitial";
            this.dtInitial.Size = new System.Drawing.Size(96, 20);
            this.dtInitial.TabIndex = 4;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(216, 226);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(96, 20);
            this.dtFinal.TabIndex = 5;
            // 
            // dtFinalLabel
            // 
            this.dtFinalLabel.AutoSize = true;
            this.dtFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinalLabel.Location = new System.Drawing.Point(213, 208);
            this.dtFinalLabel.Name = "dtFinalLabel";
            this.dtFinalLabel.Size = new System.Drawing.Size(63, 15);
            this.dtFinalLabel.TabIndex = 6;
            this.dtFinalLabel.Text = "Final Date";
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationLabel.Location = new System.Drawing.Point(26, 190);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(94, 20);
            this.reservationLabel.TabIndex = 7;
            this.reservationLabel.Text = "Reservation";
            // 
            // typeRoom
            // 
            this.typeRoom.FormattingEnabled = true;
            this.typeRoom.Location = new System.Drawing.Point(30, 326);
            this.typeRoom.Name = "typeRoom";
            this.typeRoom.Size = new System.Drawing.Size(282, 21);
            this.typeRoom.TabIndex = 8;
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(26, 303);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(108, 20);
            this.roomTypeLabel.TabIndex = 9;
            this.roomTypeLabel.Text = "Type of Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(27, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "[DD-MM-YYYY]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(213, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "[DD-MM-YYYY]";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(95, 368);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 60);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservationForm.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(431, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 320);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.typeRoom);
            this.Controls.Add(this.reservationLabel);
            this.Controls.Add(this.dtFinalLabel);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInitial);
            this.Controls.Add(this.dtInitialLabel);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "CustomerReservation";
            this.Text = "Make your reservation today!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label dtInitialLabel;
        private System.Windows.Forms.DateTimePicker dtInitial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label dtFinalLabel;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.ComboBox typeRoom;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

