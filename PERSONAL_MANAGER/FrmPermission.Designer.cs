
namespace PERSONAL_MANAGER
{
    partial class FrmPermission
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
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.lblUserNumç = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtDayAmount = new System.Windows.Forms.TextBox();
            this.lblDayAmount = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblExpalnation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserNum
            // 
            this.txtUserNum.Location = new System.Drawing.Point(135, 39);
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.ReadOnly = true;
            this.txtUserNum.Size = new System.Drawing.Size(200, 20);
            this.txtUserNum.TabIndex = 17;
            // 
            // lblUserNumç
            // 
            this.lblUserNumç.AutoSize = true;
            this.lblUserNumç.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumç.Location = new System.Drawing.Point(25, 39);
            this.lblUserNumç.Name = "lblUserNumç";
            this.lblUserNumç.Size = new System.Drawing.Size(71, 20);
            this.lblUserNumç.TabIndex = 16;
            this.lblUserNumç.Text = "User Nº";
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(135, 114);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(200, 20);
            this.dtpFinish.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(135, 75);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(25, 114);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(101, 20);
            this.lblFinish.TabIndex = 20;
            this.lblFinish.Text = "Finish Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(25, 75);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(93, 20);
            this.lblStart.TabIndex = 19;
            this.lblStart.Text = "Start Date";
            // 
            // txtDayAmount
            // 
            this.txtDayAmount.Location = new System.Drawing.Point(135, 149);
            this.txtDayAmount.Name = "txtDayAmount";
            this.txtDayAmount.ReadOnly = true;
            this.txtDayAmount.Size = new System.Drawing.Size(200, 20);
            this.txtDayAmount.TabIndex = 24;
            // 
            // lblDayAmount
            // 
            this.lblDayAmount.AutoSize = true;
            this.lblDayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAmount.Location = new System.Drawing.Point(25, 149);
            this.lblDayAmount.Name = "lblDayAmount";
            this.lblDayAmount.Size = new System.Drawing.Size(107, 20);
            this.lblDayAmount.TabIndex = 23;
            this.lblDayAmount.Text = "Day Amount";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(135, 192);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(321, 170);
            this.txtTitle.TabIndex = 2;
            // 
            // lblExpalnation
            // 
            this.lblExpalnation.AutoSize = true;
            this.lblExpalnation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpalnation.Location = new System.Drawing.Point(24, 192);
            this.lblExpalnation.Name = "lblExpalnation";
            this.lblExpalnation.Size = new System.Drawing.Size(103, 20);
            this.lblExpalnation.TabIndex = 26;
            this.lblExpalnation.Text = "Explanation";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(244, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 67);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(96, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 67);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblExpalnation);
            this.Controls.Add(this.txtDayAmount);
            this.Controls.Add(this.lblDayAmount);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtUserNum);
            this.Controls.Add(this.lblUserNumç);
            this.Name = "FrmPermission";
            this.Text = "FrmPermission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.Label lblUserNumç;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtDayAmount;
        private System.Windows.Forms.Label lblDayAmount;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblExpalnation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}