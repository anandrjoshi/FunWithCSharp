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
			cmbPermAddrState.Items.AddRange(_controller.GetStateAbbrev().ToArray());
			cmbTempAddrState.Items.AddRange(_controller.GetStateAbbrev().ToArray());
			cmbPermAddrCountry.Items.AddRange(_controller.GetCountryAbbrev().ToArray());
			cmbTempAddrCountry.Items.AddRange(_controller.GetCountryAbbrev().ToArray());
		}
	}
}
