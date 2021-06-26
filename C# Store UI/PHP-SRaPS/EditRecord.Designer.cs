namespace PHP_SRaPS
{
    partial class EditRecord
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
            this.button_searchRecord = new System.Windows.Forms.Button();
            this.text_searchRecordID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_recordNumber = new System.Windows.Forms.Label();
            this.label_productID = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_dateBought = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.text_productID = new System.Windows.Forms.TextBox();
            this.text_productName = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.button_updateRecord = new System.Windows.Forms.Button();
            this.label_recordNum = new System.Windows.Forms.Label();
            this.text_dateBought = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_searchRecord
            // 
            this.button_searchRecord.Location = new System.Drawing.Point(275, 37);
            this.button_searchRecord.Margin = new System.Windows.Forms.Padding(2);
            this.button_searchRecord.Name = "button_searchRecord";
            this.button_searchRecord.Size = new System.Drawing.Size(61, 32);
            this.button_searchRecord.TabIndex = 8;
            this.button_searchRecord.Text = "SEARCH";
            this.button_searchRecord.UseVisualStyleBackColor = true;
            this.button_searchRecord.Click += new System.EventHandler(this.button_searchRecord_Click);
            // 
            // text_searchRecordID
            // 
            this.text_searchRecordID.Location = new System.Drawing.Point(110, 42);
            this.text_searchRecordID.Margin = new System.Windows.Forms.Padding(2);
            this.text_searchRecordID.Name = "text_searchRecordID";
            this.text_searchRecordID.Size = new System.Drawing.Size(138, 20);
            this.text_searchRecordID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Record ID";
            // 
            // label_recordNumber
            // 
            this.label_recordNumber.AutoSize = true;
            this.label_recordNumber.Location = new System.Drawing.Point(41, 114);
            this.label_recordNumber.Name = "label_recordNumber";
            this.label_recordNumber.Size = new System.Drawing.Size(85, 13);
            this.label_recordNumber.TabIndex = 9;
            this.label_recordNumber.Text = "Record Number:";
            // 
            // label_productID
            // 
            this.label_productID.AutoSize = true;
            this.label_productID.Location = new System.Drawing.Point(41, 145);
            this.label_productID.Name = "label_productID";
            this.label_productID.Size = new System.Drawing.Size(61, 13);
            this.label_productID.TabIndex = 10;
            this.label_productID.Text = "Product ID:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(41, 207);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(34, 13);
            this.label_price.TabIndex = 11;
            this.label_price.Text = "Price:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(41, 235);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(49, 13);
            this.label_quantity.TabIndex = 12;
            this.label_quantity.Text = "Quantity:";
            // 
            // label_dateBought
            // 
            this.label_dateBought.AutoSize = true;
            this.label_dateBought.Location = new System.Drawing.Point(41, 269);
            this.label_dateBought.Name = "label_dateBought";
            this.label_dateBought.Size = new System.Drawing.Size(70, 13);
            this.label_dateBought.TabIndex = 13;
            this.label_dateBought.Text = "Date Bought:";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(41, 176);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(78, 13);
            this.label_productName.TabIndex = 14;
            this.label_productName.Text = "Product Name:";
            // 
            // text_productID
            // 
            this.text_productID.Location = new System.Drawing.Point(166, 142);
            this.text_productID.Margin = new System.Windows.Forms.Padding(2);
            this.text_productID.Name = "text_productID";
            this.text_productID.Size = new System.Drawing.Size(138, 20);
            this.text_productID.TabIndex = 16;
            // 
            // text_productName
            // 
            this.text_productName.Location = new System.Drawing.Point(166, 173);
            this.text_productName.Margin = new System.Windows.Forms.Padding(2);
            this.text_productName.Name = "text_productName";
            this.text_productName.Size = new System.Drawing.Size(138, 20);
            this.text_productName.TabIndex = 17;
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(166, 204);
            this.text_price.Margin = new System.Windows.Forms.Padding(2);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(138, 20);
            this.text_price.TabIndex = 18;
            // 
            // text_quantity
            // 
            this.text_quantity.Location = new System.Drawing.Point(166, 232);
            this.text_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.Size = new System.Drawing.Size(138, 20);
            this.text_quantity.TabIndex = 19;
            // 
            // button_updateRecord
            // 
            this.button_updateRecord.Location = new System.Drawing.Point(275, 304);
            this.button_updateRecord.Margin = new System.Windows.Forms.Padding(2);
            this.button_updateRecord.Name = "button_updateRecord";
            this.button_updateRecord.Size = new System.Drawing.Size(61, 32);
            this.button_updateRecord.TabIndex = 21;
            this.button_updateRecord.Text = "UPDATE";
            this.button_updateRecord.UseVisualStyleBackColor = true;
            this.button_updateRecord.Click += new System.EventHandler(this.button_updateRecord_Click);
            // 
            // label_recordNum
            // 
            this.label_recordNum.AutoSize = true;
            this.label_recordNum.Location = new System.Drawing.Point(166, 113);
            this.label_recordNum.Name = "label_recordNum";
            this.label_recordNum.Size = new System.Drawing.Size(35, 13);
            this.label_recordNum.TabIndex = 22;
            this.label_recordNum.Text = "label2";
            // 
            // text_dateBought
            // 
            this.text_dateBought.Location = new System.Drawing.Point(166, 263);
            this.text_dateBought.Name = "text_dateBought";
            this.text_dateBought.Size = new System.Drawing.Size(200, 20);
            this.text_dateBought.TabIndex = 23;
            // 
            // EditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_dateBought);
            this.Controls.Add(this.label_recordNum);
            this.Controls.Add(this.button_updateRecord);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_productName);
            this.Controls.Add(this.text_productID);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.label_dateBought);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_productID);
            this.Controls.Add(this.label_recordNumber);
            this.Controls.Add(this.button_searchRecord);
            this.Controls.Add(this.text_searchRecordID);
            this.Controls.Add(this.label1);
            this.Name = "EditRecord";
            this.Text = "EditRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_searchRecord;
        private System.Windows.Forms.TextBox text_searchRecordID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_recordNumber;
        private System.Windows.Forms.Label label_productID;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_dateBought;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.TextBox text_productID;
        private System.Windows.Forms.TextBox text_productName;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.Button button_updateRecord;
        private System.Windows.Forms.Label label_recordNum;
        private System.Windows.Forms.DateTimePicker text_dateBought;
    }
}