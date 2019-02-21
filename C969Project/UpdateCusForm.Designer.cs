namespace C969Project
{
    partial class UpdateCusForm
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
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pCodeText = new System.Windows.Forms.TextBox();
            this.currentCusID = new System.Windows.Forms.TextBox();
            this.currentAddressID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Customer";
            // 
            // CityListBox
            // 
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Houston",
            "Salt Lake City",
            "Lancaster",
            "London",
            "Glasgow",
            "Toronto",
            "Vancouver",
            "Ottawa",
            "Oslo",
            "Bergen",
            "Trondheim"});
            this.CityListBox.Location = new System.Drawing.Point(35, 327);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(120, 95);
            this.CityListBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "City:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(301, 346);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancBtn
            // 
            this.cancBtn.Location = new System.Drawing.Point(301, 399);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 9;
            this.cancBtn.Text = "Cancel";
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Name:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(207, 111);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer Address:";
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(207, 161);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(100, 20);
            this.addText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone Number:";
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(207, 211);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(100, 20);
            this.numText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Postal Code:";
            // 
            // pCodeText
            // 
            this.pCodeText.Location = new System.Drawing.Point(207, 265);
            this.pCodeText.Name = "pCodeText";
            this.pCodeText.Size = new System.Drawing.Size(100, 20);
            this.pCodeText.TabIndex = 17;
            // 
            // currentCusID
            // 
            this.currentCusID.Enabled = false;
            this.currentCusID.Location = new System.Drawing.Point(12, 39);
            this.currentCusID.Name = "currentCusID";
            this.currentCusID.Size = new System.Drawing.Size(27, 20);
            this.currentCusID.TabIndex = 18;
            // 
            // currentAddressID
            // 
            this.currentAddressID.Enabled = false;
            this.currentAddressID.Location = new System.Drawing.Point(12, 65);
            this.currentAddressID.Name = "currentAddressID";
            this.currentAddressID.Size = new System.Drawing.Size(27, 20);
            this.currentAddressID.TabIndex = 19;
            // 
            // UpdateCusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.currentAddressID);
            this.Controls.Add(this.currentCusID);
            this.Controls.Add(this.pCodeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CityListBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCusForm";
            this.Text = "Appointment Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox CityListBox;
        public System.Windows.Forms.TextBox nameText;
        public System.Windows.Forms.TextBox addText;
        public System.Windows.Forms.TextBox numText;
        public System.Windows.Forms.TextBox pCodeText;
        public System.Windows.Forms.TextBox currentCusID;
        public System.Windows.Forms.TextBox currentAddressID;
    }
}