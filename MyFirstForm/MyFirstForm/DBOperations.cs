using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstForm
{
	public static class DBOperations
	{
		private static SqlConnection GetSQLConnection()
		{
			return new SqlConnection("Data Source=MYLAPTOP\\SQLEXPRESS;Initial Catalog=dbo;User ID=world;Password=Password1");
		}

		public static List<USStates> GetAllUSStates()
		{
			List<USStates> allUSStates = new List<USStates>();

			using (SqlConnection connection = GetSQLConnection())
			using (SqlCommand cmd = new SqlCommand("dbo.sp_GetAllUSStates", connection))
			{
				connection.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Check is the reader has any rows at all before starting to read.
					if (reader.HasRows)
					{
						// Read advances to the next row.
						while (reader.Read())
						{
							USStates state	 = new USStates();
							// To avoid unexpected bugs access columns by name.
							state.ID = reader.GetInt32(reader.GetOrdinal("USStates_ID"));
							state.State_Abbrev = reader.GetString(reader.GetOrdinal("State_Abbrev"));

							state.State_Description = reader.GetString(reader.GetOrdinal("State_Description"));
							allUSStates.Add(state);
						}
					}
				}
			}

			return allUSStates;
		}

		public static List<Country> GetAllCountries()
		{
			List<Country> allCountries = new List<Country>();

			using (SqlConnection connection = GetSQLConnection())
			using (SqlCommand cmd = new SqlCommand("dbo.sp_GetAllCountries", connection))
			{
				connection.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Check is the reader has any rows at all before starting to read.
					if (reader.HasRows)
					{
						// Read advances to the next row.
						while (reader.Read())
						{
							Country country = new Country();
							// To avoid unexpected bugs access columns by name.
							country.ID = reader.GetInt32(reader.GetOrdinal("Country_ID"));
							country.Country_Abbrev = reader.GetString(reader.GetOrdinal("Country_Abbrev"));

							country.Country_Description = reader.GetString(reader.GetOrdinal("Country_Description"));
							allCountries.Add(country);
						}
					}
				}
			}

			return allCountries;
		}
	}
}
