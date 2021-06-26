namespace PHP_SRaPS
{
    partial class DeleteRecord
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
            this.TextBox_RecordID = new System.Windows.Forms.TextBox();
            this.Label_RecordID = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Label_DeletionError = new System.Windows.Forms.Label();
            this.Label_DeletionSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_RecordID
            // 
            this.TextBox_RecordID.Location = new System.Drawing.Point(78, 10);
            this.TextBox_RecordID.Name = "TextBox_RecordID";
            this.TextBox_RecordID.Size = new System.Drawing.Size(101, 20);
            this.TextBox_RecordID.TabIndex = 1;
            this.TextBox_RecordID.TextChanged += new System.EventHandler(this.TextBox_RecordID_TextChanged);
            // 
            // Label_RecordID
            // 
            this.Label_RecordID.AutoSize = true;
            this.Label_RecordID.Location = new System.Drawing.Point(12, 13);
            this.Label_RecordID.Name = "Label_RecordID";
            this.Label_RecordID.Size = new System.Drawing.Size(59, 13);
            this.Label_RecordID.TabIndex = 2;
            this.Label_RecordID.Text = "Record ID:";
            this.Label_RecordID.Click += new System.EventHandler(this.Label_RecordID_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(91, 36);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Label_DeletionError
            // 
            this.Label_DeletionError.AutoSize = true;
            this.Label_DeletionError.Location = new System.Drawing.Point(13, 63);
            this.Label_DeletionError.Name = "Label_DeletionError";
            this.Label_DeletionError.Size = new System.Drawing.Size(0, 13);
            this.Label_DeletionError.TabIndex = 4;
            // 
            // Label_DeletionSuccess
            // 
            this.Label_DeletionSuccess.AutoSize = true;
            this.Label_DeletionSuccess.Location = new System.Drawing.Point(13, 76);
            this.Label_DeletionSuccess.Name = "Label_DeletionSuccess";
            this.Label_DeletionSuccess.Size = new System.Drawing.Size(0, 13);
            this.Label_DeletionSuccess.TabIndex = 5;
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 226);
            this.Controls.Add(this.Label_DeletionSuccess);
            this.Controls.Add(this.Label_DeletionError);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Label_RecordID);
            this.Controls.Add(this.TextBox_RecordID);
            this.Name = "DeleteRecord";
            this.Text = "DeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_RecordID;
        private System.Windows.Forms.Label Label_RecordID;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label Label_DeletionError;
        private System.Windows.Forms.Label Label_DeletionSuccess;
    }
}