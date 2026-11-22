using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    partial class CtrlPersoneAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.RemoveImage = new System.Windows.Forms.LinkLabel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lblGendor = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(490, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Person";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(30, 65);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(83, 16);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "Person ID :";
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.AutoSize = true;
            this.lblPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDValue.Location = new System.Drawing.Point(130, 65);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(33, 16);
            this.lblPersonIDValue.TabIndex = 2;
            this.lblPersonIDValue.Text = "N/A";
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPersonInfo.Controls.Add(this.RemoveImage);
            this.gbPersonInfo.Controls.Add(this.lblFirst);
            this.gbPersonInfo.Controls.Add(this.lblSecond);
            this.gbPersonInfo.Controls.Add(this.lblThird);
            this.gbPersonInfo.Controls.Add(this.lblLast);
            this.gbPersonInfo.Controls.Add(this.lblName);
            this.gbPersonInfo.Controls.Add(this.txtFirstName);
            this.gbPersonInfo.Controls.Add(this.txtSecondName);
            this.gbPersonInfo.Controls.Add(this.txtThirdName);
            this.gbPersonInfo.Controls.Add(this.txtLastName);
            this.gbPersonInfo.Controls.Add(this.lblNationalNo);
            this.gbPersonInfo.Controls.Add(this.txtNationalNo);
            this.gbPersonInfo.Controls.Add(this.lblGendor);
            this.gbPersonInfo.Controls.Add(this.rbMale);
            this.gbPersonInfo.Controls.Add(this.rbFemale);
            this.gbPersonInfo.Controls.Add(this.lblEmail);
            this.gbPersonInfo.Controls.Add(this.txtEmail);
            this.gbPersonInfo.Controls.Add(this.lblAddress);
            this.gbPersonInfo.Controls.Add(this.txtAddress);
            this.gbPersonInfo.Controls.Add(this.lblDateOfBirth);
            this.gbPersonInfo.Controls.Add(this.dtpDateOfBirth);
            this.gbPersonInfo.Controls.Add(this.lblPhone);
            this.gbPersonInfo.Controls.Add(this.txtPhone);
            this.gbPersonInfo.Controls.Add(this.lblCountry);
            this.gbPersonInfo.Controls.Add(this.cbCountry);
            this.gbPersonInfo.Controls.Add(this.pbProfileImage);
            this.gbPersonInfo.Controls.Add(this.llSetImage);
            this.gbPersonInfo.Location = new System.Drawing.Point(25, 95);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(1135, 431);
            this.gbPersonInfo.TabIndex = 3;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Information";
            this.gbPersonInfo.Enter += new System.EventHandler(this.gbPersonInfo_Enter);
            // 
            // RemoveImage
            // 
            this.RemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveImage.AutoSize = true;
            this.RemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveImage.Location = new System.Drawing.Point(980, 266);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(100, 16);
            this.RemoveImage.TabIndex = 25;
            this.RemoveImage.TabStop = true;
            this.RemoveImage.Text = "Remove Image";
            this.RemoveImage.Visible = false;
            this.RemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveImage_LinkClicked);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.ForeColor = System.Drawing.Color.Gray;
            this.lblFirst.Location = new System.Drawing.Point(150, 20);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(26, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.ForeColor = System.Drawing.Color.Gray;
            this.lblSecond.Location = new System.Drawing.Point(380, 20);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(44, 13);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.ForeColor = System.Drawing.Color.Gray;
            this.lblThird.Location = new System.Drawing.Point(610, 20);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(31, 13);
            this.lblThird.TabIndex = 2;
            this.lblThird.Text = "Third";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.ForeColor = System.Drawing.Color.Gray;
            this.lblLast.Location = new System.Drawing.Point(840, 20);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(27, 13);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "Last";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(15, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(210, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(365, 40);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(210, 20);
            this.txtSecondName.TabIndex = 6;
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(595, 40);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(210, 20);
            this.txtThirdName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(825, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNationalNo.Location = new System.Drawing.Point(15, 82);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(87, 15);
            this.lblNationalNo.TabIndex = 9;
            this.lblNationalNo.Text = "National No:";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(135, 80);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(167, 20);
            this.txtNationalNo.TabIndex = 10;
            this.txtNationalNo.TextChanged += new System.EventHandler(this.txtNationalNo_TextChanged);
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblGendor.Location = new System.Drawing.Point(15, 122);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(58, 15);
            this.lblGendor.TabIndex = 11;
            this.lblGendor.Text = "Gendor:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(135, 122);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 12;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(205, 122);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 13;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(15, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(15, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 15);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 265);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(670, 90);
            this.txtAddress.TabIndex = 17;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.Location = new System.Drawing.Point(325, 82);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(93, 15);
            this.lblDateOfBirth.TabIndex = 18;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(425, 80);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(150, 20);
            this.dtpDateOfBirth.TabIndex = 19;
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(325, 122);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 15);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(425, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountry.Location = new System.Drawing.Point(325, 162);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(59, 15);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country:";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(425, 160);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(150, 21);
            this.cbCountry.TabIndex = 23;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfileImage.Location = new System.Drawing.Point(932, 80);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(150, 160);
            this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfileImage.TabIndex = 24;
            this.pbProfileImage.TabStop = false;
            // 
            // llSetImage
            // 
            this.llSetImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(980, 250);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(68, 16);
            this.llSetImage.TabIndex = 0;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1050, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(940, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CtrlPersoneAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbPersonInfo);
            this.Controls.Add(this.lblPersonIDValue);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CtrlPersoneAdd";
            this.Size = new System.Drawing.Size(1183, 590);
            this.Load += new System.EventHandler(this.CtrlPersoneAdd_Load);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel RemoveImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}