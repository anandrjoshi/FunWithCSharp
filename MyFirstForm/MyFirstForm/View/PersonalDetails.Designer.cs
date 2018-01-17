namespace MyFirstForm
{
	partial class MyForm
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
			this.OkCancelPanel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblMiddleInitial = new System.Windows.Forms.Label();
			this.txtMiddleInitial = new System.Windows.Forms.TextBox();
			this.rbtnMale = new System.Windows.Forms.RadioButton();
			this.rbtnFemale = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblDOB = new System.Windows.Forms.Label();
			this.gpbxPermanentAddress = new System.Windows.Forms.GroupBox();
			this.cmbPermAddrCountry = new System.Windows.Forms.ComboBox();
			this.cmbPermAddrState = new System.Windows.Forms.ComboBox();
			this.lblPermAddrState = new System.Windows.Forms.Label();
			this.lblPermAddrCountry = new System.Windows.Forms.Label();
			this.txtPermAddrZip = new System.Windows.Forms.TextBox();
			this.lblPermAddrZip = new System.Windows.Forms.Label();
			this.txtPermAddrCity = new System.Windows.Forms.TextBox();
			this.txtPermAddr2 = new System.Windows.Forms.TextBox();
			this.lblPermAddrCity = new System.Windows.Forms.Label();
			this.lblPermAddr2 = new System.Windows.Forms.Label();
			this.txtPermAddr1 = new System.Windows.Forms.TextBox();
			this.lblPermAddr1 = new System.Windows.Forms.Label();
			this.gpbxTemporaryAddress = new System.Windows.Forms.GroupBox();
			this.txtTempAddrCity = new System.Windows.Forms.TextBox();
			this.lblTempAddrCity = new System.Windows.Forms.Label();
			this.cmbTempAddrCountry = new System.Windows.Forms.ComboBox();
			this.cmbTempAddrState = new System.Windows.Forms.ComboBox();
			this.lblTempAddrState = new System.Windows.Forms.Label();
			this.lblTempAddrCountry = new System.Windows.Forms.Label();
			this.txtTempAddrZip = new System.Windows.Forms.TextBox();
			this.lblTempAddrZip = new System.Windows.Forms.Label();
			this.txtTempAddr2 = new System.Windows.Forms.TextBox();
			this.lblTempAddr2 = new System.Windows.Forms.Label();
			this.txtTempAddr1 = new System.Windows.Forms.TextBox();
			this.lblTempAddr1 = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.OkCancelPanel.SuspendLayout();
			this.gpbxPermanentAddress.SuspendLayout();
			this.gpbxTemporaryAddress.SuspendLayout();
			this.SuspendLayout();
			// 
			// OkCancelPanel
			// 
			this.OkCancelPanel.Controls.Add(this.btnCancel);
			this.OkCancelPanel.Controls.Add(this.btnOk);
			this.OkCancelPanel.Location = new System.Drawing.Point(12, 675);
			this.OkCancelPanel.Name = "OkCancelPanel";
			this.OkCancelPanel.Size = new System.Drawing.Size(1092, 76);
			this.OkCancelPanel.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(828, 13);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(245, 55);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(577, 13);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(245, 55);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(182, 51);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(265, 38);
			this.txtFirstName.TabIndex = 1;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(16, 57);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(160, 32);
			this.lblFirstName.TabIndex = 2;
			this.lblFirstName.Text = "First Name:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(491, 54);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(159, 32);
			this.lblLastName.TabIndex = 4;
			this.lblLastName.Text = "Last Name:";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(656, 51);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(265, 38);
			this.txtLastName.TabIndex = 3;
			// 
			// lblMiddleInitial
			// 
			this.lblMiddleInitial.AutoSize = true;
			this.lblMiddleInitial.Location = new System.Drawing.Point(964, 57);
			this.lblMiddleInitial.Name = "lblMiddleInitial";
			this.lblMiddleInitial.Size = new System.Drawing.Size(53, 32);
			this.lblMiddleInitial.TabIndex = 6;
			this.lblMiddleInitial.Text = "MI:";
			// 
			// txtMiddleInitial
			// 
			this.txtMiddleInitial.Location = new System.Drawing.Point(1033, 51);
			this.txtMiddleInitial.MaxLength = 1;
			this.txtMiddleInitial.Name = "txtMiddleInitial";
			this.txtMiddleInitial.Size = new System.Drawing.Size(68, 38);
			this.txtMiddleInitial.TabIndex = 5;
			// 
			// rbtnMale
			// 
			this.rbtnMale.AutoSize = true;
			this.rbtnMale.Location = new System.Drawing.Point(182, 141);
			this.rbtnMale.Name = "rbtnMale";
			this.rbtnMale.Size = new System.Drawing.Size(114, 36);
			this.rbtnMale.TabIndex = 7;
			this.rbtnMale.TabStop = true;
			this.rbtnMale.Text = "Male";
			this.rbtnMale.UseVisualStyleBackColor = true;
			// 
			// rbtnFemale
			// 
			this.rbtnFemale.AutoSize = true;
			this.rbtnFemale.Location = new System.Drawing.Point(320, 141);
			this.rbtnFemale.Name = "rbtnFemale";
			this.rbtnFemale.Size = new System.Drawing.Size(147, 36);
			this.rbtnFemale.TabIndex = 7;
			this.rbtnFemale.TabStop = true;
			this.rbtnFemale.Text = "Female";
			this.rbtnFemale.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(586, 141);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(515, 38);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// lblDOB
			// 
			this.lblDOB.AutoSize = true;
			this.lblDOB.Location = new System.Drawing.Point(491, 145);
			this.lblDOB.Name = "lblDOB";
			this.lblDOB.Size = new System.Drawing.Size(84, 32);
			this.lblDOB.TabIndex = 4;
			this.lblDOB.Text = "DOB:";
			// 
			// gpbxPermanentAddress
			// 
			this.gpbxPermanentAddress.Controls.Add(this.cmbPermAddrCountry);
			this.gpbxPermanentAddress.Controls.Add(this.cmbPermAddrState);
			this.gpbxPermanentAddress.Controls.Add(this.lblPermAddrState);
			this.gpbxPermanentAddress.Controls.Add(this.lblPermAddrCountry);
			this.gpbxPermanentAddress.Controls.Add(this.txtPermAddrZip);
			this.gpbxPermanentAddress.Controls.Add(this.lblPermAddrZip);
			this.gpbxPermanentAddress.Controls.Add(this.txtPermAddrCity);
			this.gpbxPermanentAddress.Controls.Add(this.txtPermAddr2);
			this.gpbxPermanentAddress.Controls.Add(this.lblPermAddrCity);
			this.gpbxPermanentAddress.Controls.Add(this.lblPermAddr2);
			this.gpbxPermanentAddress.Controls.Add(this.txtPermAddr1);
			this.gpbxPermanentAddress.Controls.Add(this.lblPermAddr1);
			this.gpbxPermanentAddress.Location = new System.Drawing.Point(12, 209);
			this.gpbxPermanentAddress.Name = "gpbxPermanentAddress";
			this.gpbxPermanentAddress.Size = new System.Drawing.Size(484, 460);
			this.gpbxPermanentAddress.TabIndex = 9;
			this.gpbxPermanentAddress.TabStop = false;
			this.gpbxPermanentAddress.Text = "Permanent Address";
			// 
			// cmbPermAddrCountry
			// 
			this.cmbPermAddrCountry.FormattingEnabled = true;
			this.cmbPermAddrCountry.Location = new System.Drawing.Point(170, 402);
			this.cmbPermAddrCountry.Name = "cmbPermAddrCountry";
			this.cmbPermAddrCountry.Size = new System.Drawing.Size(157, 39);
			this.cmbPermAddrCountry.TabIndex = 19;
			// 
			// cmbPermAddrState
			// 
			this.cmbPermAddrState.FormattingEnabled = true;
			this.cmbPermAddrState.Location = new System.Drawing.Point(170, 270);
			this.cmbPermAddrState.Name = "cmbPermAddrState";
			this.cmbPermAddrState.Size = new System.Drawing.Size(157, 39);
			this.cmbPermAddrState.TabIndex = 18;
			// 
			// lblPermAddrState
			// 
			this.lblPermAddrState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPermAddrState.AutoSize = true;
			this.lblPermAddrState.Location = new System.Drawing.Point(74, 273);
			this.lblPermAddrState.Name = "lblPermAddrState";
			this.lblPermAddrState.Size = new System.Drawing.Size(90, 32);
			this.lblPermAddrState.TabIndex = 17;
			this.lblPermAddrState.Text = "State:";
			// 
			// lblPermAddrCountry
			// 
			this.lblPermAddrCountry.AutoSize = true;
			this.lblPermAddrCountry.Location = new System.Drawing.Point(42, 405);
			this.lblPermAddrCountry.Name = "lblPermAddrCountry";
			this.lblPermAddrCountry.Size = new System.Drawing.Size(122, 32);
			this.lblPermAddrCountry.TabIndex = 16;
			this.lblPermAddrCountry.Text = "Country:";
			// 
			// txtPermAddrZip
			// 
			this.txtPermAddrZip.Location = new System.Drawing.Point(170, 336);
			this.txtPermAddrZip.Name = "txtPermAddrZip";
			this.txtPermAddrZip.Size = new System.Drawing.Size(157, 38);
			this.txtPermAddrZip.TabIndex = 13;
			// 
			// lblPermAddrZip
			// 
			this.lblPermAddrZip.AutoSize = true;
			this.lblPermAddrZip.Location = new System.Drawing.Point(28, 339);
			this.lblPermAddrZip.Name = "lblPermAddrZip";
			this.lblPermAddrZip.Size = new System.Drawing.Size(138, 32);
			this.lblPermAddrZip.TabIndex = 14;
			this.lblPermAddrZip.Text = "Zip Code:";
			// 
			// txtPermAddrCity
			// 
			this.txtPermAddrCity.Location = new System.Drawing.Point(170, 210);
			this.txtPermAddrCity.Name = "txtPermAddrCity";
			this.txtPermAddrCity.Size = new System.Drawing.Size(265, 38);
			this.txtPermAddrCity.TabIndex = 11;
			// 
			// txtPermAddr2
			// 
			this.txtPermAddr2.Location = new System.Drawing.Point(170, 143);
			this.txtPermAddr2.Name = "txtPermAddr2";
			this.txtPermAddr2.Size = new System.Drawing.Size(265, 38);
			this.txtPermAddr2.TabIndex = 11;
			// 
			// lblPermAddrCity
			// 
			this.lblPermAddrCity.AutoSize = true;
			this.lblPermAddrCity.Location = new System.Drawing.Point(92, 213);
			this.lblPermAddrCity.Name = "lblPermAddrCity";
			this.lblPermAddrCity.Size = new System.Drawing.Size(72, 32);
			this.lblPermAddrCity.TabIndex = 12;
			this.lblPermAddrCity.Text = "City:";
			// 
			// lblPermAddr2
			// 
			this.lblPermAddr2.AutoSize = true;
			this.lblPermAddr2.Location = new System.Drawing.Point(14, 143);
			this.lblPermAddr2.Name = "lblPermAddr2";
			this.lblPermAddr2.Size = new System.Drawing.Size(150, 32);
			this.lblPermAddr2.TabIndex = 12;
			this.lblPermAddr2.Text = "Address 2:";
			// 
			// txtPermAddr1
			// 
			this.txtPermAddr1.Location = new System.Drawing.Point(170, 72);
			this.txtPermAddr1.Name = "txtPermAddr1";
			this.txtPermAddr1.Size = new System.Drawing.Size(265, 38);
			this.txtPermAddr1.TabIndex = 10;
			// 
			// lblPermAddr1
			// 
			this.lblPermAddr1.AutoSize = true;
			this.lblPermAddr1.Location = new System.Drawing.Point(14, 72);
			this.lblPermAddr1.Name = "lblPermAddr1";
			this.lblPermAddr1.Size = new System.Drawing.Size(150, 32);
			this.lblPermAddr1.TabIndex = 10;
			this.lblPermAddr1.Text = "Address 1:";
			// 
			// gpbxTemporaryAddress
			// 
			this.gpbxTemporaryAddress.Controls.Add(this.txtTempAddrCity);
			this.gpbxTemporaryAddress.Controls.Add(this.lblTempAddrCity);
			this.gpbxTemporaryAddress.Controls.Add(this.cmbTempAddrCountry);
			this.gpbxTemporaryAddress.Controls.Add(this.cmbTempAddrState);
			this.gpbxTemporaryAddress.Controls.Add(this.lblTempAddrState);
			this.gpbxTemporaryAddress.Controls.Add(this.lblTempAddrCountry);
			this.gpbxTemporaryAddress.Controls.Add(this.txtTempAddrZip);
			this.gpbxTemporaryAddress.Controls.Add(this.lblTempAddrZip);
			this.gpbxTemporaryAddress.Controls.Add(this.txtTempAddr2);
			this.gpbxTemporaryAddress.Controls.Add(this.lblTempAddr2);
			this.gpbxTemporaryAddress.Controls.Add(this.txtTempAddr1);
			this.gpbxTemporaryAddress.Controls.Add(this.lblTempAddr1);
			this.gpbxTemporaryAddress.Location = new System.Drawing.Point(617, 209);
			this.gpbxTemporaryAddress.Name = "gpbxTemporaryAddress";
			this.gpbxTemporaryAddress.Size = new System.Drawing.Size(484, 460);
			this.gpbxTemporaryAddress.TabIndex = 20;
			this.gpbxTemporaryAddress.TabStop = false;
			this.gpbxTemporaryAddress.Text = "Temporary Address";
			// 
			// txtTempAddrCity
			// 
			this.txtTempAddrCity.Location = new System.Drawing.Point(170, 210);
			this.txtTempAddrCity.Name = "txtTempAddrCity";
			this.txtTempAddrCity.Size = new System.Drawing.Size(265, 38);
			this.txtTempAddrCity.TabIndex = 20;
			// 
			// lblTempAddrCity
			// 
			this.lblTempAddrCity.AutoSize = true;
			this.lblTempAddrCity.Location = new System.Drawing.Point(92, 213);
			this.lblTempAddrCity.Name = "lblTempAddrCity";
			this.lblTempAddrCity.Size = new System.Drawing.Size(72, 32);
			this.lblTempAddrCity.TabIndex = 21;
			this.lblTempAddrCity.Text = "City:";
			// 
			// cmbTempAddrCountry
			// 
			this.cmbTempAddrCountry.FormattingEnabled = true;
			this.cmbTempAddrCountry.Location = new System.Drawing.Point(170, 409);
			this.cmbTempAddrCountry.Name = "cmbTempAddrCountry";
			this.cmbTempAddrCountry.Size = new System.Drawing.Size(157, 39);
			this.cmbTempAddrCountry.TabIndex = 19;
			// 
			// cmbTempAddrState
			// 
			this.cmbTempAddrState.FormattingEnabled = true;
			this.cmbTempAddrState.Location = new System.Drawing.Point(170, 277);
			this.cmbTempAddrState.Name = "cmbTempAddrState";
			this.cmbTempAddrState.Size = new System.Drawing.Size(157, 39);
			this.cmbTempAddrState.TabIndex = 18;
			// 
			// lblTempAddrState
			// 
			this.lblTempAddrState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTempAddrState.AutoSize = true;
			this.lblTempAddrState.Location = new System.Drawing.Point(74, 277);
			this.lblTempAddrState.Name = "lblTempAddrState";
			this.lblTempAddrState.Size = new System.Drawing.Size(90, 32);
			this.lblTempAddrState.TabIndex = 17;
			this.lblTempAddrState.Text = "State:";
			// 
			// lblTempAddrCountry
			// 
			this.lblTempAddrCountry.AutoSize = true;
			this.lblTempAddrCountry.Location = new System.Drawing.Point(42, 409);
			this.lblTempAddrCountry.Name = "lblTempAddrCountry";
			this.lblTempAddrCountry.Size = new System.Drawing.Size(122, 32);
			this.lblTempAddrCountry.TabIndex = 16;
			this.lblTempAddrCountry.Text = "Country:";
			// 
			// txtTempAddrZip
			// 
			this.txtTempAddrZip.Location = new System.Drawing.Point(170, 343);
			this.txtTempAddrZip.Name = "txtTempAddrZip";
			this.txtTempAddrZip.Size = new System.Drawing.Size(157, 38);
			this.txtTempAddrZip.TabIndex = 13;
			// 
			// lblTempAddrZip
			// 
			this.lblTempAddrZip.AutoSize = true;
			this.lblTempAddrZip.Location = new System.Drawing.Point(28, 343);
			this.lblTempAddrZip.Name = "lblTempAddrZip";
			this.lblTempAddrZip.Size = new System.Drawing.Size(138, 32);
			this.lblTempAddrZip.TabIndex = 14;
			this.lblTempAddrZip.Text = "Zip Code:";
			// 
			// txtTempAddr2
			// 
			this.txtTempAddr2.Location = new System.Drawing.Point(170, 143);
			this.txtTempAddr2.Name = "txtTempAddr2";
			this.txtTempAddr2.Size = new System.Drawing.Size(265, 38);
			this.txtTempAddr2.TabIndex = 11;
			// 
			// lblTempAddr2
			// 
			this.lblTempAddr2.AutoSize = true;
			this.lblTempAddr2.Location = new System.Drawing.Point(14, 143);
			this.lblTempAddr2.Name = "lblTempAddr2";
			this.lblTempAddr2.Size = new System.Drawing.Size(150, 32);
			this.lblTempAddr2.TabIndex = 12;
			this.lblTempAddr2.Text = "Address 2:";
			// 
			// txtTempAddr1
			// 
			this.txtTempAddr1.Location = new System.Drawing.Point(170, 72);
			this.txtTempAddr1.Name = "txtTempAddr1";
			this.txtTempAddr1.Size = new System.Drawing.Size(265, 38);
			this.txtTempAddr1.TabIndex = 10;
			// 
			// lblTempAddr1
			// 
			this.lblTempAddr1.AutoSize = true;
			this.lblTempAddr1.Location = new System.Drawing.Point(14, 72);
			this.lblTempAddr1.Name = "lblTempAddr1";
			this.lblTempAddr1.Size = new System.Drawing.Size(150, 32);
			this.lblTempAddr1.TabIndex = 10;
			this.lblTempAddr1.Text = "Address 1:";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(16, 141);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(118, 32);
			this.lblGender.TabIndex = 21;
			this.lblGender.Text = "Gender:";
			// 
			// MyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1116, 763);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.gpbxTemporaryAddress);
			this.Controls.Add(this.gpbxPermanentAddress);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.rbtnFemale);
			this.Controls.Add(this.rbtnMale);
			this.Controls.Add(this.lblMiddleInitial);
			this.Controls.Add(this.txtMiddleInitial);
			this.Controls.Add(this.lblDOB);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.OkCancelPanel);
			this.Name = "MyForm";
			this.Text = "Personal Details";
			this.Load += new System.EventHandler(this.MyForm_Load);
			this.OkCancelPanel.ResumeLayout(false);
			this.gpbxPermanentAddress.ResumeLayout(false);
			this.gpbxPermanentAddress.PerformLayout();
			this.gpbxTemporaryAddress.ResumeLayout(false);
			this.gpbxTemporaryAddress.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel OkCancelPanel;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblMiddleInitial;
		private System.Windows.Forms.TextBox txtMiddleInitial;
		private System.Windows.Forms.RadioButton rbtnMale;
		private System.Windows.Forms.RadioButton rbtnFemale;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lblDOB;
		private System.Windows.Forms.GroupBox gpbxPermanentAddress;
		private System.Windows.Forms.ComboBox cmbPermAddrCountry;
		private System.Windows.Forms.ComboBox cmbPermAddrState;
		private System.Windows.Forms.Label lblPermAddrState;
		private System.Windows.Forms.Label lblPermAddrCountry;
		private System.Windows.Forms.TextBox txtPermAddrZip;
		private System.Windows.Forms.Label lblPermAddrZip;
		private System.Windows.Forms.TextBox txtPermAddr2;
		private System.Windows.Forms.Label lblPermAddr2;
		private System.Windows.Forms.TextBox txtPermAddr1;
		private System.Windows.Forms.Label lblPermAddr1;
		private System.Windows.Forms.GroupBox gpbxTemporaryAddress;
		private System.Windows.Forms.ComboBox cmbTempAddrCountry;
		private System.Windows.Forms.ComboBox cmbTempAddrState;
		private System.Windows.Forms.Label lblTempAddrState;
		private System.Windows.Forms.Label lblTempAddrCountry;
		private System.Windows.Forms.TextBox txtTempAddrZip;
		private System.Windows.Forms.Label lblTempAddrZip;
		private System.Windows.Forms.TextBox txtTempAddr2;
		private System.Windows.Forms.Label lblTempAddr2;
		private System.Windows.Forms.TextBox txtTempAddr1;
		private System.Windows.Forms.Label lblTempAddr1;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TextBox txtPermAddrCity;
		private System.Windows.Forms.Label lblPermAddrCity;
		private System.Windows.Forms.TextBox txtTempAddrCity;
		private System.Windows.Forms.Label lblTempAddrCity;
	}
}

