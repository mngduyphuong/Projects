namespace PHP_SRaPS
{
    partial class GUI
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
            this.welcome = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.Label();
            this.addRecord = new System.Windows.Forms.Button();
            this.displayRecord = new System.Windows.Forms.Button();
            this.editRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.searchRecord = new System.Windows.Forms.Button();
            this.button_predictions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(75, 68);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(500, 58);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to PHP.inc";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Location = new System.Drawing.Point(86, 180);
            this.choose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(207, 29);
            this.choose.TabIndex = 1;
            this.choose.Text = "Choose an Option";
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // addRecord
            // 
            this.addRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord.Location = new System.Drawing.Point(86, 271);
            this.addRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(228, 48);
            this.addRecord.TabIndex = 2;
            this.addRecord.Text = "Add a Record";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // displayRecord
            // 
            this.displayRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRecord.Location = new System.Drawing.Point(86, 328);
            this.displayRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayRecord.Name = "displayRecord";
            this.displayRecord.Size = new System.Drawing.Size(228, 48);
            this.displayRecord.TabIndex = 3;
            this.displayRecord.Text = "Display a Record";
            this.displayRecord.UseVisualStyleBackColor = true;
            this.displayRecord.Click += new System.EventHandler(this.displayRecord_Click);
            // 
            // editRecord
            // 
            this.editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRecord.Location = new System.Drawing.Point(86, 385);
            this.editRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editRecord.Name = "editRecord";
            this.editRecord.Size = new System.Drawing.Size(228, 48);
            this.editRecord.TabIndex = 4;
            this.editRecord.Text = "Edit a Record";
            this.editRecord.UseVisualStyleBackColor = true;
            this.editRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(86, 442);
            this.deleteRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(228, 48);
            this.deleteRecord.TabIndex = 5;
            this.deleteRecord.Text = "Delete a Record";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // searchRecord
            // 
            this.searchRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRecord.Location = new System.Drawing.Point(84, 498);
            this.searchRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchRecord.Name = "searchRecord";
            this.searchRecord.Size = new System.Drawing.Size(228, 48);
            this.searchRecord.TabIndex = 6;
            this.searchRecord.Text = "Search a Record";
            this.searchRecord.UseVisualStyleBackColor = true;
            this.searchRecord.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // button_predictions
            // 
            this.button_predictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_predictions.Location = new System.Drawing.Point(86, 556);
            this.button_predictions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_predictions.Name = "button_predictions";
            this.button_predictions.Size = new System.Drawing.Size(226, 49);
            this.button_predictions.TabIndex = 7;
            this.button_predictions.Text = "Predictions";
            this.button_predictions.UseVisualStyleBackColor = true;
            this.button_predictions.Click += new System.EventHandler(this.button_predictions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "DP2 - Group 4 project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sales Reporting and Prediction System ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PHP_SRaPS.Properties.Resources.drugs_pharmacy_istock1;
            this.pictureBox1.Location = new System.Drawing.Point(585, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 310);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_predictions);
            this.Controls.Add(this.searchRecord);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.editRecord);
            this.Controls.Add(this.displayRecord);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.welcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI";
            this.Text = "PHP-SRaPS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Button displayRecord;
        private System.Windows.Forms.Button editRecord;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button searchRecord;
        private System.Windows.Forms.Button button_predictions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

