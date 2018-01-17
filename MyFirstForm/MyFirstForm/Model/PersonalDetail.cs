using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstForm
{
	public class PersonalDetail : IPersonalDetail
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public char MiddleInitials { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public DateTime DOB { get; set; }
		public string PermAddrRow1 { get; set; }
		public string PermAddrRow2 { get; set; }
		public string PermAddrCity { get; set; }
		public string PermAddrZipCode { get; set; }
		public int PermAddrState { get; set; }
		public int PermAddrCountry { get; set; }
		public string TempAddrRow1 { get; set; }
		public string TempAddrRow2 { get; set; }
		public string TempAddrCity { get; set; }
		public string TempAddrZipCode { get; set; }
		public int TempAddrState { get; set; }
		public int TempAddrCountry { get; set; }
	}
}
