namespace C969Project
{
    partial class MainForm
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
            this.title = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.appLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delCusButton = new System.Windows.Forms.Button();
            this.upCusButton = new System.Windows.Forms.Button();
            this.addCusButton = new System.Windows.Forms.Button();
            this.cusDataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delAppButton = new System.Windows.Forms.Button();
            this.upAppButton = new System.Windows.Forms.Button();
            this.addAppButton = new System.Windows.Forms.Button();
            this.appDataGridView = new System.Windows.Forms.DataGridView();
            this.calDataView = new System.Windows.Forms.DataGridView();
            this.calLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calDataView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(485, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(462, 37);
            this.title.TabIndex = 0;
            this.title.Text = "Omni Appointment Scheduler";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(65, 146);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(118, 26);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customers";
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.Location = new System.Drawing.Point(65, 531);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(146, 26);
            this.appLabel.TabIndex = 3;
            this.appLabel.Text = "Appointments";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delCusButton);
            this.panel1.Controls.Add(this.upCusButton);
            this.panel1.Controls.Add(this.addCusButton);
            this.panel1.Controls.Add(this.cusDataView);
            this.panel1.Location = new System.Drawing.Point(70, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 263);
            this.panel1.TabIndex = 4;
            // 
            // delCusButton
            // 
            this.delCusButton.Location = new System.Drawing.Point(439, 204);
            this.delCusButton.Name = "delCusButton";
            this.delCusButton.Size = new System.Drawing.Size(75, 23);
            this.delCusButton.TabIndex = 3;
            this.delCusButton.Text = "Delete";
            this.delCusButton.UseVisualStyleBackColor = true;
            this.delCusButton.Click += new System.EventHandler(this.delCusButton_Click);
            // 
            // upCusButton
            // 
            this.upCusButton.Location = new System.Drawing.Point(337, 203);
            this.upCusButton.Name = "upCusButton";
            this.upCusButton.Size = new System.Drawing.Size(75, 23);
            this.upCusButton.TabIndex = 2;
            this.upCusButton.Text = "Update";
            this.upCusButton.UseVisualStyleBackColor = true;
            this.upCusButton.Click += new System.EventHandler(this.upCusButton_Click);
            // 
            // addCusButton
            // 
            this.addCusButton.Location = new System.Drawing.Point(238, 204);
            this.addCusButton.Name = "addCusButton";
            this.addCusButton.Size = new System.Drawing.Size(75, 23);
            this.addCusButton.TabIndex = 1;
            this.addCusButton.Text = "Add";
            this.addCusButton.UseVisualStyleBackColor = true;
            this.addCusButton.Click += new System.EventHandler(this.addCusButton_Click);
            // 
            // cusDataView
            // 
            this.cusDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusDataView.Location = new System.Drawing.Point(32, 47);
            this.cusDataView.Name = "cusDataView";
            this.cusDataView.Size = new System.Drawing.Size(509, 150);
            this.cusDataView.TabIndex = 0;
            this.cusDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cusDataView_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delAppButton);
            this.panel2.Controls.Add(this.upAppButton);
            this.panel2.Controls.Add(this.addAppButton);
            this.panel2.Controls.Add(this.appDataGridView);
            this.panel2.Location = new System.Drawing.Point(70, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 271);
            this.panel2.TabIndex = 5;
            // 
            // delAppButton
            // 
            this.delAppButton.Location = new System.Drawing.Point(439, 200);
            this.delAppButton.Name = "delAppButton";
            this.delAppButton.Size = new System.Drawing.Size(75, 23);
            this.delAppButton.TabIndex = 5;
            this.delAppButton.Text = "Delete";
            this.delAppButton.UseVisualStyleBackColor = true;
            // 
            // upAppButton
            // 
            this.upAppButton.Location = new System.Drawing.Point(337, 200);
            this.upAppButton.Name = "upAppButton";
            this.upAppButton.Size = new System.Drawing.Size(75, 23);
            this.upAppButton.TabIndex = 4;
            this.upAppButton.Text = "Update";
            this.upAppButton.UseVisualStyleBackColor = true;
            // 
            // addAppButton
            // 
            this.addAppButton.Location = new System.Drawing.Point(238, 200);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(75, 23);
            this.addAppButton.TabIndex = 2;
            this.addAppButton.Text = "Add";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addAppButton_Click);
            // 
            // appDataGridView
            // 
            this.appDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appDataGridView.Location = new System.Drawing.Point(32, 35);
            this.appDataGridView.Name = "appDataGridView";
            this.appDataGridView.Size = new System.Drawing.Size(509, 150);
            this.appDataGridView.TabIndex = 0;
            // 
            // calDataView
            // 
            this.calDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calDataView.Location = new System.Drawing.Point(42, 21);
            this.calDataView.Name = "calDataView";
            this.calDataView.Size = new System.Drawing.Size(468, 150);
            this.calDataView.TabIndex = 0;
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLabel.Location = new System.Drawing.Point(1110, 146);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(100, 26);
            this.calLabel.TabIndex = 6;
            this.calLabel.Text = "Calendar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.calDataView);
            this.panel3.Location = new System.Drawing.Point(891, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 379);
            this.panel3.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.calLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.title);
            this.Name = "MainForm";
            this.Text = "Appointment Scheduler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cusDataView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calDataView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView cusDataView;
        private System.Windows.Forms.DataGridView calDataView;
        private System.Windows.Forms.Label calLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView appDataGridView;
        private System.Windows.Forms.Button delCusButton;
        private System.Windows.Forms.Button upCusButton;
        private System.Windows.Forms.Button addCusButton;
        private System.Windows.Forms.Button delAppButton;
        private System.Windows.Forms.Button upAppButton;
        private System.Windows.Forms.Button addAppButton;
    }
}