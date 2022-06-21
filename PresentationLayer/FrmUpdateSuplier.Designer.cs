
namespace PresentationLayer
{
    partial class FrmUpdateSuplier
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
            this.dt_ContactDate = new System.Windows.Forms.DateTimePicker();
            this.btn_CloseFrm = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SuplierMoreInfo = new System.Windows.Forms.TextBox();
            this.txt_SuplierEmail = new System.Windows.Forms.TextBox();
            this.txt_SuplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_SuplierAddress = new System.Windows.Forms.TextBox();
            this.txt_SuplierName = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_ContactDate);
            this.groupBox1.Controls.Add(this.btn_CloseFrm);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_SuplierMoreInfo);
            this.groupBox1.Controls.Add(this.txt_SuplierEmail);
            this.groupBox1.Controls.Add(this.txt_SuplierPhoneNumber);
            this.groupBox1.Controls.Add(this.txt_SuplierAddress);
            this.groupBox1.Controls.Add(this.txt_SuplierName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suplier Infomation Data";
            // 
            // dt_ContactDate
            // 
            this.dt_ContactDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ContactDate.Location = new System.Drawing.Point(97, 183);
            this.dt_ContactDate.Name = "dt_ContactDate";
            this.dt_ContactDate.Size = new System.Drawing.Size(271, 20);
            this.dt_ContactDate.TabIndex = 14;
            // 
            // btn_CloseFrm
            // 
            this.btn_CloseFrm.Location = new System.Drawing.Point(6, 246);
            this.btn_CloseFrm.Name = "btn_CloseFrm";
            this.btn_CloseFrm.Size = new System.Drawing.Size(362, 23);
            this.btn_CloseFrm.TabIndex = 13;
            this.btn_CloseFrm.Text = "Cancel";
            this.btn_CloseFrm.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(6, 217);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(362, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact Date";
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
            // txt_SuplierMoreInfo
            // 
            this.txt_SuplierMoreInfo.Location = new System.Drawing.Point(97, 148);
            this.txt_SuplierMoreInfo.Multiline = true;
            this.txt_SuplierMoreInfo.Name = "txt_SuplierMoreInfo";
            this.txt_SuplierMoreInfo.Size = new System.Drawing.Size(271, 24);
            this.txt_SuplierMoreInfo.TabIndex = 4;
            // 
            // txt_SuplierEmail
            // 
            this.txt_SuplierEmail.Location = new System.Drawing.Point(97, 118);
            this.txt_SuplierEmail.Multiline = true;
            this.txt_SuplierEmail.Name = "txt_SuplierEmail";
            this.txt_SuplierEmail.Size = new System.Drawing.Size(271, 24);
            this.txt_SuplierEmail.TabIndex = 3;
            // 
            // txt_SuplierPhoneNumber
            // 
            this.txt_SuplierPhoneNumber.Location = new System.Drawing.Point(97, 88);
            this.txt_SuplierPhoneNumber.Multiline = true;
            this.txt_SuplierPhoneNumber.Name = "txt_SuplierPhoneNumber";
            this.txt_SuplierPhoneNumber.Size = new System.Drawing.Size(271, 24);
            this.txt_SuplierPhoneNumber.TabIndex = 2;
            // 
            // txt_SuplierAddress
            // 
            this.txt_SuplierAddress.Location = new System.Drawing.Point(97, 58);
            this.txt_SuplierAddress.Multiline = true;
            this.txt_SuplierAddress.Name = "txt_SuplierAddress";
            this.txt_SuplierAddress.Size = new System.Drawing.Size(271, 24);
            this.txt_SuplierAddress.TabIndex = 1;
            // 
            // txt_SuplierName
            // 
            this.txt_SuplierName.Location = new System.Drawing.Point(97, 28);
            this.txt_SuplierName.Multiline = true;
            this.txt_SuplierName.Name = "txt_SuplierName";
            this.txt_SuplierName.Size = new System.Drawing.Size(271, 24);
            this.txt_SuplierName.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusNotification});
            this.statusStrip.Location = new System.Drawing.Point(0, 284);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(398, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusNotification
            // 
            this.statusNotification.Name = "statusNotification";
            this.statusNotification.Size = new System.Drawing.Size(39, 17);
            this.statusNotification.Text = "Status";
            // 
            // FrmUpdateSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 306);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUpdateSuplier";
            this.Text = "FrmUpdateSuplier";
            this.Load += new System.EventHandler(this.FrmUpdateSuplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_ContactDate;
        private System.Windows.Forms.Button btn_CloseFrm;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SuplierMoreInfo;
        private System.Windows.Forms.TextBox txt_SuplierEmail;
        private System.Windows.Forms.TextBox txt_SuplierPhoneNumber;
        private System.Windows.Forms.TextBox txt_SuplierAddress;
        private System.Windows.Forms.TextBox txt_SuplierName;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusNotification;
    }
}