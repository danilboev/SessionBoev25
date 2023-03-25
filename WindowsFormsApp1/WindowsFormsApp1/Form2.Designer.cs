namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boevExDataSet = new WindowsFormsApp1.boevExDataSet();
            this.transportBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportBTableAdapter = new WindowsFormsApp1.boevExDataSetTableAdapters.TransportBTableAdapter();
            this.transportmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.boevExDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boevExDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boevExDataSet1 = new WindowsFormsApp1.boevExDataSet1();
            this.transportBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transportBTableAdapter1 = new WindowsFormsApp1.boevExDataSet1TableAdapters.TransportBTableAdapter();
            this.datamanufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 339);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportmodelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportBBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(141, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // boevExDataSet
            // 
            this.boevExDataSet.DataSetName = "boevExDataSet";
            this.boevExDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBBindingSource
            // 
            this.transportBBindingSource.DataMember = "TransportB";
            this.transportBBindingSource.DataSource = this.boevExDataSet;
            // 
            // transportBTableAdapter
            // 
            this.transportBTableAdapter.ClearBeforeFill = true;
            // 
            // transportmodelDataGridViewTextBoxColumn
            // 
            this.transportmodelDataGridViewTextBoxColumn.DataPropertyName = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.HeaderText = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.Name = "transportmodelDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datamanufactureDataGridViewTextBoxColumn,
            this.transportcolorDataGridViewTextBoxColumn,
            this.currentpointlocationnumberDataGridViewTextBoxColumn,
            this.currentpointlocationaddressDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.transportBBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(138, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(183, 339);
            this.dataGridView2.TabIndex = 1;
            // 
            // boevExDataSetBindingSource
            // 
            this.boevExDataSetBindingSource.DataSource = this.boevExDataSet;
            this.boevExDataSetBindingSource.Position = 0;
            // 
            // transportBBindingSource1
            // 
            this.transportBBindingSource1.DataMember = "TransportB";
            this.transportBBindingSource1.DataSource = this.boevExDataSetBindingSource;
            // 
            // boevExDataSetBindingSource1
            // 
            this.boevExDataSetBindingSource1.DataSource = this.boevExDataSet;
            this.boevExDataSetBindingSource1.Position = 0;
            // 
            // boevExDataSet1
            // 
            this.boevExDataSet1.DataSetName = "boevExDataSet1";
            this.boevExDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBBindingSource2
            // 
            this.transportBBindingSource2.DataMember = "TransportB";
            this.transportBBindingSource2.DataSource = this.boevExDataSet1;
            // 
            // transportBTableAdapter1
            // 
            this.transportBTableAdapter1.ClearBeforeFill = true;
            // 
            // datamanufactureDataGridViewTextBoxColumn
            // 
            this.datamanufactureDataGridViewTextBoxColumn.DataPropertyName = "Data_manufacture";
            this.datamanufactureDataGridViewTextBoxColumn.HeaderText = "Data_manufacture";
            this.datamanufactureDataGridViewTextBoxColumn.Name = "datamanufactureDataGridViewTextBoxColumn";
            // 
            // transportcolorDataGridViewTextBoxColumn
            // 
            this.transportcolorDataGridViewTextBoxColumn.DataPropertyName = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.HeaderText = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.Name = "transportcolorDataGridViewTextBoxColumn";
            // 
            // currentpointlocationnumberDataGridViewTextBoxColumn
            // 
            this.currentpointlocationnumberDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.HeaderText = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.Name = "currentpointlocationnumberDataGridViewTextBoxColumn";
            // 
            // currentpointlocationaddressDataGridViewTextBoxColumn
            // 
            this.currentpointlocationaddressDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.HeaderText = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.Name = "currentpointlocationaddressDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.логотип;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мегадрайв";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boevExDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private boevExDataSet boevExDataSet;
        private System.Windows.Forms.BindingSource transportBBindingSource;
        private boevExDataSetTableAdapters.TransportBTableAdapter transportBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource boevExDataSetBindingSource1;
        private System.Windows.Forms.BindingSource boevExDataSetBindingSource;
        private System.Windows.Forms.BindingSource transportBBindingSource1;
        private boevExDataSet1 boevExDataSet1;
        private System.Windows.Forms.BindingSource transportBBindingSource2;
        private boevExDataSet1TableAdapters.TransportBTableAdapter transportBTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamanufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}