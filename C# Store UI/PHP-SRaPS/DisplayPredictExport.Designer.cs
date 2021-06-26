namespace PHP_SRaPS
{
    partial class DisplayPredictExport
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
            this.components = new System.ComponentModel.Container();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.dataGrid_display = new System.Windows.Forms.DataGridView();
            this.salesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.newPHPDatabaseDataSet = new PHP_SRaPS.newPHPDatabaseDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHPDatabaseDataSet = new PHP_SRaPS.PHPDatabaseDataSet();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new PHP_SRaPS.PHPDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.label_predictions = new System.Windows.Forms.Label();
            this.label_predictionsBuy = new System.Windows.Forms.Label();
            this.label_buyProduct1 = new System.Windows.Forms.Label();
            this.label_buyProduct2 = new System.Windows.Forms.Label();
            this.label_buyProduct3 = new System.Windows.Forms.Label();
            this.label_notBuyProduct1 = new System.Windows.Forms.Label();
            this.label_notBuyProduct2 = new System.Windows.Forms.Label();
            this.label_notBuyProduct3 = new System.Windows.Forms.Label();
            this.button_exportToCSV = new System.Windows.Forms.Button();
            this.button_predict = new System.Windows.Forms.Button();
            this.salesTableAdapter1 = new PHP_SRaPS.newPHPDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.label_predictionsNotBought = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startDate.Location = new System.Drawing.Point(27, 30);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(105, 25);
            this.label_startDate.TabIndex = 0;
            this.label_startDate.Text = "Start Date:";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endDate.Location = new System.Drawing.Point(327, 30);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(99, 25);
            this.label_endDate.TabIndex = 1;
            this.label_endDate.Text = "End Date:";
            // 
            // dataGrid_display
            // 
            this.dataGrid_display.AllowUserToAddRows = false;
            this.dataGrid_display.AllowUserToDeleteRows = false;
            this.dataGrid_display.AutoGenerateColumns = false;
            this.dataGrid_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.salesdateDataGridViewTextBoxColumn});
            this.dataGrid_display.DataSource = this.salesBindingSource2;
            this.dataGrid_display.EnableHeadersVisualStyles = false;
            this.dataGrid_display.Location = new System.Drawing.Point(32, 91);
            this.dataGrid_display.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGrid_display.Name = "dataGrid_display";
            this.dataGrid_display.RowHeadersWidth = 51;
            this.dataGrid_display.RowTemplate.Height = 24;
            this.dataGrid_display.Size = new System.Drawing.Size(370, 213);
            this.dataGrid_display.TabIndex = 6;
            this.dataGrid_display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_display_CellContentClick);
            // 
            // salesidDataGridViewTextBoxColumn
            // 
            this.salesidDataGridViewTextBoxColumn.DataPropertyName = "salesid";
            this.salesidDataGridViewTextBoxColumn.HeaderText = "salesid";
            this.salesidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salesidDataGridViewTextBoxColumn.Name = "salesidDataGridViewTextBoxColumn";
            this.salesidDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesdateDataGridViewTextBoxColumn
            // 
            this.salesdateDataGridViewTextBoxColumn.DataPropertyName = "salesdate";
            this.salesdateDataGridViewTextBoxColumn.HeaderText = "salesdate";
            this.salesdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salesdateDataGridViewTextBoxColumn.Name = "salesdateDataGridViewTextBoxColumn";
            this.salesdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesBindingSource2
            // 
            this.salesBindingSource2.DataMember = "Sales";
            this.salesBindingSource2.DataSource = this.newPHPDatabaseDataSet;
            // 
            // newPHPDatabaseDataSet
            // 
            this.newPHPDatabaseDataSet.DataSetName = "newPHPDatabaseDataSet";
            this.newPHPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // pHPDatabaseDataSet
            // 
            this.pHPDatabaseDataSet.DataSetName = "PHPDatabaseDataSet";
            this.pHPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.pHPDatabaseDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // label_predictions
            // 
            this.label_predictions.AutoSize = true;
            this.label_predictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_predictions.Location = new System.Drawing.Point(482, 91);
            this.label_predictions.Name = "label_predictions";
            this.label_predictions.Size = new System.Drawing.Size(108, 25);
            this.label_predictions.TabIndex = 7;
            this.label_predictions.Text = "Predictions";
            // 
            // label_predictionsBuy
            // 
            this.label_predictionsBuy.AutoSize = true;
            this.label_predictionsBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_predictionsBuy.Location = new System.Drawing.Point(429, 126);
            this.label_predictionsBuy.Name = "label_predictionsBuy";
            this.label_predictionsBuy.Size = new System.Drawing.Size(221, 17);
            this.label_predictionsBuy.TabIndex = 8;
            this.label_predictionsBuy.Text = "Products most likely to be bought:";
            // 
            // label_buyProduct1
            // 
            this.label_buyProduct1.AutoSize = true;
            this.label_buyProduct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buyProduct1.Location = new System.Drawing.Point(461, 157);
            this.label_buyProduct1.Name = "label_buyProduct1";
            this.label_buyProduct1.Size = new System.Drawing.Size(77, 17);
            this.label_buyProduct1.TabIndex = 10;
            this.label_buyProduct1.Text = "Product #1";
            // 
            // label_buyProduct2
            // 
            this.label_buyProduct2.AutoSize = true;
            this.label_buyProduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buyProduct2.Location = new System.Drawing.Point(461, 174);
            this.label_buyProduct2.Name = "label_buyProduct2";
            this.label_buyProduct2.Size = new System.Drawing.Size(77, 17);
            this.label_buyProduct2.TabIndex = 11;
            this.label_buyProduct2.Text = "Product #2";
            // 
            // label_buyProduct3
            // 
            this.label_buyProduct3.AutoSize = true;
            this.label_buyProduct3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buyProduct3.Location = new System.Drawing.Point(461, 191);
            this.label_buyProduct3.Name = "label_buyProduct3";
            this.label_buyProduct3.Size = new System.Drawing.Size(77, 17);
            this.label_buyProduct3.TabIndex = 12;
            this.label_buyProduct3.Text = "Product #3";
            // 
            // label_notBuyProduct1
            // 
            this.label_notBuyProduct1.AutoSize = true;
            this.label_notBuyProduct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notBuyProduct1.Location = new System.Drawing.Point(461, 257);
            this.label_notBuyProduct1.Name = "label_notBuyProduct1";
            this.label_notBuyProduct1.Size = new System.Drawing.Size(77, 17);
            this.label_notBuyProduct1.TabIndex = 13;
            this.label_notBuyProduct1.Text = "Product #1";
            // 
            // label_notBuyProduct2
            // 
            this.label_notBuyProduct2.AutoSize = true;
            this.label_notBuyProduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notBuyProduct2.Location = new System.Drawing.Point(461, 274);
            this.label_notBuyProduct2.Name = "label_notBuyProduct2";
            this.label_notBuyProduct2.Size = new System.Drawing.Size(77, 17);
            this.label_notBuyProduct2.TabIndex = 14;
            this.label_notBuyProduct2.Text = "Product #2";
            // 
            // label_notBuyProduct3
            // 
            this.label_notBuyProduct3.AutoSize = true;
            this.label_notBuyProduct3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notBuyProduct3.Location = new System.Drawing.Point(461, 291);
            this.label_notBuyProduct3.Name = "label_notBuyProduct3";
            this.label_notBuyProduct3.Size = new System.Drawing.Size(77, 17);
            this.label_notBuyProduct3.TabIndex = 15;
            this.label_notBuyProduct3.Text = "Product #3";
            // 
            // button_exportToCSV
            // 
            this.button_exportToCSV.Location = new System.Drawing.Point(32, 323);
            this.button_exportToCSV.Name = "button_exportToCSV";
            this.button_exportToCSV.Size = new System.Drawing.Size(173, 44);
            this.button_exportToCSV.TabIndex = 16;
            this.button_exportToCSV.Text = "Export to CSV";
            this.button_exportToCSV.UseVisualStyleBackColor = true;
            this.button_exportToCSV.Click += new System.EventHandler(this.button_exportToCSV_Click);
            // 
            // button_predict
            // 
            this.button_predict.Location = new System.Drawing.Point(622, 23);
            this.button_predict.Name = "button_predict";
            this.button_predict.Size = new System.Drawing.Size(121, 41);
            this.button_predict.TabIndex = 20;
            this.button_predict.Text = "Predict";
            this.button_predict.UseVisualStyleBackColor = true;
            this.button_predict.Click += new System.EventHandler(this.button_predict_Click_1);
            // 
            // salesTableAdapter1
            // 
            this.salesTableAdapter1.ClearBeforeFill = true;
            // 
            // date_start
            // 
            this.date_start.CustomFormat = "DD-MM-YYYY";
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(134, 33);
            this.date_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(147, 20);
            this.date_start.TabIndex = 21;
            // 
            // date_end
            // 
            this.date_end.CustomFormat = "DD-MM-YYYY";
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(429, 33);
            this.date_end.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(135, 20);
            this.date_end.TabIndex = 22;
            // 
            // label_predictionsNotBought
            // 
            this.label_predictionsNotBought.AutoSize = true;
            this.label_predictionsNotBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_predictionsNotBought.Location = new System.Drawing.Point(418, 224);
            this.label_predictionsNotBought.Name = "label_predictionsNotBought";
            this.label_predictionsNotBought.Size = new System.Drawing.Size(245, 17);
            this.label_predictionsNotBought.TabIndex = 9;
            this.label_predictionsNotBought.Text = "Products most likely to not be bought:";
            // 
            // DisplayPredictExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.button_predict);
            this.Controls.Add(this.button_exportToCSV);
            this.Controls.Add(this.label_notBuyProduct3);
            this.Controls.Add(this.label_notBuyProduct2);
            this.Controls.Add(this.label_notBuyProduct1);
            this.Controls.Add(this.label_buyProduct3);
            this.Controls.Add(this.label_buyProduct2);
            this.Controls.Add(this.label_buyProduct1);
            this.Controls.Add(this.label_predictionsNotBought);
            this.Controls.Add(this.label_predictionsBuy);
            this.Controls.Add(this.label_predictions);
            this.Controls.Add(this.dataGrid_display);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Name = "DisplayPredictExport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DisplayPredictExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.DataGridView dataGrid_display;
        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private PHPDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_predictions;
        private System.Windows.Forms.Label label_predictionsBuy;
        private System.Windows.Forms.Label label_buyProduct1;
        private System.Windows.Forms.Label label_buyProduct2;
        private System.Windows.Forms.Label label_buyProduct3;
        private System.Windows.Forms.Label label_notBuyProduct1;
        private System.Windows.Forms.Label label_notBuyProduct2;
        private System.Windows.Forms.Label label_notBuyProduct3;
        private System.Windows.Forms.Button button_exportToCSV;
        private System.Windows.Forms.Button button_predict;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private newPHPDatabaseDataSet newPHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource2;
        private newPHPDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter1;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label label_predictionsNotBought;
    }
}