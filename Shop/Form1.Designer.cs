namespace Shop
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dgvProd = new DataGridView();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvProd
            // 
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Dock = DockStyle.Fill;
            dgvProd.Location = new Point(0, 0);
            dgvProd.MultiSelect = false;
            dgvProd.Name = "dgvProd";
            dgvProd.Size = new Size(800, 450);
            dgvProd.TabIndex = 0;
            //dgvProd.CellContentClick += dgvProd_CellContentClick;
            // 
            // sqlDataAdapter1
            // 
            sqlDataAdapter1.RowUpdated += sqlDataAdapter1_RowUpdated;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProd;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private BindingSource bindingSource1;
    }
}
