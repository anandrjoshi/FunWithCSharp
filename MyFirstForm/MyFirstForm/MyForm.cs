﻿using System;
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
		public MyForm()
		{
			InitializeComponent();
			List<USStates> states = DBOperations.GetAllUSStates();
		}
	}
}
