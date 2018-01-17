using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
	public partial class MyForm : Form
	{
		private PersonalDetailsController _controller;

		public MyForm()
		{
			InitializeComponent();
			_controller = new PersonalDetailsController();
		}

		private void MyForm_Load(object sender, EventArgs e)
		{
			//cmbPermAddrState.Items.AddRange(_controller.GetStateAbbrev().ToArray());
			//cmbTempAddrState.Items.AddRange(_controller.GetStateAbbrev().ToArray());
			//cmbPermAddrCountry.Items.AddRange(_controller.GetCountryAbbrev().ToArray());
			//cmbTempAddrCountry.Items.AddRange(_controller.GetCountryAbbrev().ToArray());

			//Using databindings instead of manually maintaining sync between form fields and objects

			cmbPermAddrState.DisplayMember = "State_Abbrev";
			cmbPermAddrState.ValueMember = "ID";
			cmbPermAddrState.DataSource = _controller.GetAllStates();

			cmbTempAddrState.DisplayMember = "State_Abbrev";
			cmbTempAddrState.ValueMember = "ID";
			cmbTempAddrState.DataSource = _controller.GetAllStates();

			cmbPermAddrCountry.DisplayMember = "Country_Abbrev";
			cmbPermAddrCountry.ValueMember = "ID";
			cmbPermAddrCountry.DataSource = _controller.GetAllCountries();

			cmbTempAddrCountry.DisplayMember = "Country_Abbrev";
			cmbTempAddrCountry.ValueMember = "ID";
			cmbTempAddrCountry.DataSource = _controller.GetAllCountries();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			PersonalDetail personalDetail = new PersonalDetail();
			personalDetail.FirstName = "Sherlock";
			personalDetail.MiddleInitials = 'R';
			personalDetail.LastName = "Holmes";
			personalDetail.Gender = "Male";
			personalDetail.DOB = new DateTime(1854, 12, 25);
			personalDetail.PermAddrRow1 = "221B";
			personalDetail.PermAddrRow2 = "Baker St";
			personalDetail.PermAddrCity = "London";
			personalDetail.PermAddrState = 1;
			personalDetail.PermAddrZipCode = "30006";
			personalDetail.PermAddrCountry = 2;
			personalDetail.TempAddrRow1 = "10";
			personalDetail.TempAddrRow2 = "Downing St";
			personalDetail.TempAddrCity = "London";
			personalDetail.TempAddrState = 1;
			personalDetail.TempAddrZipCode = "30004";
			personalDetail.TempAddrCountry = 2;

			_controller.InsertPersonalDetail(personalDetail);

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
