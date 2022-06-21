namespace PresentationLayer
{
    partial class FrmAddCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_CustomerContactDate = new System.Windows.Forms.DateTimePicker();
            this.btn_CloseFrm = new System.Windows.Forms.Button();
            this.btn_CustomerSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustomerMoreInfo = new System.Windows.Forms.TextBox();
            this.txt_CustomerEmail = new System.Windows.Forms.TextBox();
            this.txt_CustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_CustomerContactDate);
            this.groupBox1.Controls.Add(this.btn_CloseFrm);
            this.groupBox1.Controls.Add(this.btn_CustomerSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_CustomerMoreInfo);
            this.groupBox1.Controls.Add(this.txt_CustomerEmail);
            this.groupBox1.Controls.Add(this.txt_CustomerPhoneNumber);
            this.groupBox1.Controls.Add(this.txt_CustomerAddress);
            this.groupBox1.Controls.Add(this.txt_CustomerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Infomation Data";
            // 
            // dt_CustomerContactDate
            // 
            this.dt_CustomerContactDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_CustomerContactDate.Location = new System.Drawing.Point(97, 183);
            this.dt_CustomerContactDate.Name = "dt_CustomerContactDate";
            this.dt_CustomerContactDate.Size = new System.Drawing.Size(271, 20);
            this.dt_CustomerContactDate.TabIndex = 15;
            // 
            // btn_CloseFrm
            // 
            this.btn_CloseFrm.Location = new System.Drawing.Point(6, 246);
            this.btn_CloseFrm.Name = "btn_CloseFrm";
            this.btn_CloseFrm.Size = new System.Drawing.Size(362, 23);
            this.btn_CloseFrm.TabIndex = 13;
            this.btn_CloseFrm.Text = "Cancel";
            this.btn_CloseFrm.UseVisualStyleBackColor = true;
            this.btn_CloseFrm.Click += new System.EventHandler(this.btn_CloseFrm_Click);
            // 
            // btn_CustomerSave
            // 
            this.btn_CustomerSave.Location = new System.Drawing.Point(6, 217);
            this.btn_CustomerSave.Name = "btn_CustomerSave";
            this.btn_CustomerSave.Size = new System.Drawing.Size(362, 23);
            this.btn_CustomerSave.TabIndex = 12;
            this.btn_CustomerSave.Text = "Save";
            this.btn_CustomerSave.UseVisualStyleBackColor = true;
            this.btn_CustomerSave.Click += new System.EventHandler(this.btn_CustomerSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contract Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "More Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Display Name";
            // 
            // txt_CustomerMoreInfo
            // 
            this.txt_CustomerMoreInfo.Location = new System.Drawing.Point(97, 148);
            this.txt_CustomerMoreInfo.Multiline = true;
            this.txt_CustomerMoreInfo.Name = "txt_CustomerMoreInfo";
            this.txt_CustomerMoreInfo.Size = new System.Drawing.Size(271, 24);
            this.txt_CustomerMoreInfo.TabIndex = 4;
            // 
            // txt_CustomerEmail
            // 
            this.txt_CustomerEmail.Location = new System.Drawing.Point(97, 118);
            this.txt_CustomerEmail.Multiline = true;
            this.txt_CustomerEmail.Name = "txt_CustomerEmail";
            this.txt_CustomerEmail.Size = new System.Drawing.Size(271, 24);
            this.txt_CustomerEmail.TabIndex = 3;
            // 
            // txt_CustomerPhoneNumber
            // 
            this.txt_CustomerPhoneNumber.Location = new System.Drawing.Point(97, 88);
            this.txt_CustomerPhoneNumber.Multiline = true;
            this.txt_CustomerPhoneNumber.Name = "txt_CustomerPhoneNumber";
            this.txt_CustomerPhoneNumber.Size = new System.Drawing.Size(271, 24);
            this.txt_CustomerPhoneNumber.TabIndex = 2;
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.Location = new System.Drawing.Point(97, 58);
            this.txt_CustomerAddress.Multiline = true;
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.Size = new System.Drawing.Size(271, 24);
            this.txt_CustomerAddress.TabIndex = 1;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(97, 28);
            this.txt_CustomerName.Multiline = true;
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(271, 24);
            this.txt_CustomerName.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(396, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 17);
            this.Status.Text = "Status";
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 324);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddCustomer";
            this.Text = "FrmAddCustomer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CloseFrm;
        private System.Windows.Forms.Button btn_CustomerSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerMoreInfo;
        private System.Windows.Forms.TextBox txt_CustomerEmail;
        private System.Windows.Forms.TextBox txt_CustomerPhoneNumber;
        private System.Windows.Forms.TextBox txt_CustomerAddress;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.DateTimePicker dt_CustomerContactDate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
    }
}