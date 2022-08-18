namespace HotelReservationForm
{
    partial class AddEditRecord
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtInitial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInitialLabel = new System.Windows.Forms.Label();
            this.dtFinalLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.typeRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleAddEdit = new System.Windows.Forms.Label();
            this.saveChanges = new System.Windows.Forms.Button();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.customerNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtInitial, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtFinal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtInitialLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtFinalLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roomTypeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeRoom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 135);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(3, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(51, 20);
            this.customerNameLabel.TabIndex = 6;
            this.customerNameLabel.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(457, 20);
            this.tbName.TabIndex = 7;
            // 
            // dtInitial
            // 
            this.dtInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInitial.Location = new System.Drawing.Point(126, 30);
            this.dtInitial.Name = "dtInitial";
            this.dtInitial.Size = new System.Drawing.Size(96, 20);
            this.dtInitial.TabIndex = 5;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(126, 57);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(96, 20);
            this.dtFinal.TabIndex = 9;
            // 
            // dtInitialLabel
            // 
            this.dtInitialLabel.AutoSize = true;
            this.dtInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInitialLabel.Location = new System.Drawing.Point(3, 27);
            this.dtInitialLabel.Name = "dtInitialLabel";
            this.dtInitialLabel.Size = new System.Drawing.Size(85, 20);
            this.dtInitialLabel.TabIndex = 10;
            this.dtInitialLabel.Text = "Initial Date";
            // 
            // dtFinalLabel
            // 
            this.dtFinalLabel.AutoSize = true;
            this.dtFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinalLabel.Location = new System.Drawing.Point(3, 54);
            this.dtFinalLabel.Name = "dtFinalLabel";
            this.dtFinalLabel.Size = new System.Drawing.Size(82, 20);
            this.dtFinalLabel.TabIndex = 11;
            this.dtFinalLabel.Text = "Final Date";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(3, 81);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(108, 20);
            this.roomTypeLabel.TabIndex = 12;
            this.roomTypeLabel.Text = "Type of Room";
            // 
            // typeRoom
            // 
            this.typeRoom.FormattingEnabled = true;
            this.typeRoom.Location = new System.Drawing.Point(126, 84);
            this.typeRoom.Name = "typeRoom";
            this.typeRoom.Size = new System.Drawing.Size(282, 21);
            this.typeRoom.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Final price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(126, 111);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(96, 20);
            this.tbPrice.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "RECORD";
            // 
            // titleAddEdit
            // 
            this.titleAddEdit.AutoSize = true;
            this.titleAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddEdit.Location = new System.Drawing.Point(666, 5);
            this.titleAddEdit.Name = "titleAddEdit";
            this.titleAddEdit.Size = new System.Drawing.Size(72, 31);
            this.titleAddEdit.TabIndex = 3;
            this.titleAddEdit.Text = "ADD";
            // 
            // saveChanges
            // 
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Location = new System.Drawing.Point(642, 70);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(111, 30);
            this.saveChanges.TabIndex = 4;
            this.saveChanges.Text = "SAVE";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.SaveChangesClick);
            // 
            // cancelChanges
            // 
            this.cancelChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelChanges.Location = new System.Drawing.Point(642, 102);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(111, 31);
            this.cancelChanges.TabIndex = 5;
            this.cancelChanges.Text = "CANCEL";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Click += new System.EventHandler(this.CancelChangesClick);
            // 
            // tbId
            // 
            this.tbId.AutoSize = true;
            this.tbId.Location = new System.Drawing.Point(744, 5);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(0, 13);
            this.tbId.TabIndex = 6;
            this.tbId.Visible = false;
            // 
            // AddEditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 139);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.cancelChanges);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.titleAddEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditRecord";
            this.Text = "Add Record";
            this.Load += new System.EventHandler(this.AddEditRecordOnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label dtInitialLabel;
        private System.Windows.Forms.Label dtFinalLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtInitial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.ComboBox typeRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleAddEdit;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Label tbId;
    }
}