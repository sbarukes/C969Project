namespace C969Project
{
    partial class AppointmentsForm
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
            this.dataViewAppointmentType = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAppointmentType)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewAppointmentType
            // 
            this.dataViewAppointmentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewAppointmentType.Location = new System.Drawing.Point(62, 51);
            this.dataViewAppointmentType.Name = "dataViewAppointmentType";
            this.dataViewAppointmentType.Size = new System.Drawing.Size(397, 150);
            this.dataViewAppointmentType.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(384, 334);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 369);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dataViewAppointmentType);
            this.Name = "AppointmentsForm";
            this.Text = "AppointmentsForm";
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAppointmentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewAppointmentType;
        private System.Windows.Forms.Button closeBtn;
    }
}