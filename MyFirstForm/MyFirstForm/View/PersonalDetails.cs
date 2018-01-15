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
	}
}
