namespace HotelReservationForm
{
    partial class AddEditRoom
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
            this.idRoomLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveChanges = new System.Windows.Forms.Button();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.tbRoomName = new System.Windows.Forms.TextBox();
            this.roomPriceLbl = new System.Windows.Forms.Label();
            this.roomNameLbl = new System.Windows.Forms.Label();
            this.tbPriceRoom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pageHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idRoomLbl
            // 
            this.idRoomLbl.AutoSize = true;
            this.idRoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRoomLbl.Location = new System.Drawing.Point(431, 64);
            this.idRoomLbl.Name = "idRoomLbl";
            this.idRoomLbl.Size = new System.Drawing.Size(29, 25);
            this.idRoomLbl.TabIndex = 4;
            this.idRoomLbl.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room id =";
            // 
            // saveChanges
            // 
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Location = new System.Drawing.Point(85, 182);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(236, 36);
            this.saveChanges.TabIndex = 1;
            this.saveChanges.Text = "SAVE";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChangesClick);
            // 
            // cancelChanges
            // 
            this.cancelChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelChanges.Location = new System.Drawing.Point(422, 182);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(236, 36);
            this.cancelChanges.TabIndex = 2;
            this.cancelChanges.Text = "CANCEL";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Click += new System.EventHandler(this.CancelChangesClick);
            // 
            // tbRoomName
            // 
            this.tbRoomName.Location = new System.Drawing.Point(147, 3);
            this.tbRoomName.Name = "tbRoomName";
            this.tbRoomName.Size = new System.Drawing.Size(573, 20);
            this.tbRoomName.TabIndex = 3;
            // 
            // roomPriceLbl
            // 
            this.roomPriceLbl.AutoSize = true;
            this.roomPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPriceLbl.Location = new System.Drawing.Point(3, 42);
            this.roomPriceLbl.Name = "roomPriceLbl";
            this.roomPriceLbl.Size = new System.Drawing.Size(61, 25);
            this.roomPriceLbl.TabIndex = 2;
            this.roomPriceLbl.Text = "Price";
            // 
            // roomNameLbl
            // 
            this.roomNameLbl.AutoSize = true;
            this.roomNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLbl.Location = new System.Drawing.Point(3, 0);
            this.roomNameLbl.Name = "roomNameLbl";
            this.roomNameLbl.Size = new System.Drawing.Size(68, 25);
            this.roomNameLbl.TabIndex = 0;
            this.roomNameLbl.Text = "Name";
            // 
            // tbPriceRoom
            // 
            this.tbPriceRoom.Location = new System.Drawing.Point(147, 45);
            this.tbPriceRoom.Name = "tbPriceRoom";
            this.tbPriceRoom.Size = new System.Drawing.Size(77, 20);
            this.tbPriceRoom.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tbPriceRoom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roomPriceLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbRoomName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pageHeader
            // 
            this.pageHeader.AutoSize = true;
            this.pageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader.Location = new System.Drawing.Point(229, 9);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.Size = new System.Drawing.Size(332, 55);
            this.pageHeader.TabIndex = 3;
            this.pageHeader.Text = "AddEditRoom";
            // 
            // AddEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idRoomLbl);
            this.Controls.Add(this.pageHeader);
            this.Controls.Add(this.cancelChanges);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditRoom";
            this.Text = "AddEditRoom";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idRoomLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.Label roomPriceLbl;
        private System.Windows.Forms.Label roomNameLbl;
        private System.Windows.Forms.TextBox tbPriceRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pageHeader;
    }
}