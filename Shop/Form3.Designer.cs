namespace Shop
{
    partial class Form3
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
            iProdID = new Label();
            SDate = new Label();
            EDate = new Label();
            OfferPrice = new Label();
            iOfferId = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnAddOffer = new Button();
            SuspendLayout();
            // 
            // iProdID
            // 
            iProdID.AutoSize = true;
            iProdID.Location = new Point(181, 119);
            iProdID.Name = "iProdID";
            iProdID.Size = new Size(63, 15);
            iProdID.TabIndex = 0;
            iProdID.Text = "Product ID";
            // 
            // SDate
            // 
            SDate.AutoSize = true;
            SDate.Location = new Point(181, 152);
            SDate.Name = "SDate";
            SDate.Size = new Size(58, 15);
            SDate.TabIndex = 1;
            SDate.Text = "Start Date";
            // 
            // EDate
            // 
            EDate.AutoSize = true;
            EDate.Location = new Point(181, 186);
            EDate.Name = "EDate";
            EDate.Size = new Size(54, 15);
            EDate.TabIndex = 2;
            EDate.Text = "End Date";
            // 
            // OfferPrice
            // 
            OfferPrice.AutoSize = true;
            OfferPrice.Location = new Point(181, 223);
            OfferPrice.Name = "OfferPrice";
            OfferPrice.Size = new Size(63, 15);
            OfferPrice.TabIndex = 3;
            OfferPrice.Text = "Offer Price";
            // 
            // iOfferId
            // 
            iOfferId.AutoSize = true;
            iOfferId.Location = new Point(182, 81);
            iOfferId.Name = "iOfferId";
            iOfferId.Size = new Size(48, 15);
            iOfferId.TabIndex = 4;
            iOfferId.Text = "Offer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 81);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(270, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(270, 152);
            dateTimePicker1.MinDate = new DateTime(2024, 10, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.AllowDrop = true;
            dateTimePicker2.Location = new Point(271, 186);
            dateTimePicker2.MinDate = new DateTime(2024, 10, 4, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(119, 23);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.Value = new DateTime(2024, 10, 25, 23, 59, 59, 0);
            // 
            // btnAddOffer
            // 
            btnAddOffer.Location = new Point(182, 297);
            btnAddOffer.Name = "btnAddOffer";
            btnAddOffer.Size = new Size(77, 24);
            btnAddOffer.TabIndex = 14;
            btnAddOffer.Text = "Add Offer ";
            btnAddOffer.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 389);
            Controls.Add(btnAddOffer);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(iOfferId);
            Controls.Add(OfferPrice);
            Controls.Add(EDate);
            Controls.Add(SDate);
            Controls.Add(iProdID);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label iProdID;
        private Label SDate;
        private Label EDate;
        private Label OfferPrice;
        private Label iOfferId;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnAddOffer;
    }
}