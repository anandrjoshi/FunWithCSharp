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

		public static List<IUSState> GetAllUSStates()
		{
			List<IUSState> allUSStates = new List<IUSState>();

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
							USState state	 = new USState();
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

		public static List<ICountry> GetAllCountries()
		{
			List<ICountry> allCountries = new List<ICountry>();

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

		static public void InsertPersonalDetails(PersonalDetail personalDetail)
		{
			using (SqlConnection connection = GetSQLConnection())
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("dbo.sp_InsertPersonalDetails", connection);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@FirstName", personalDetail.FirstName);
				cmd.Parameters.AddWithValue("@MiddleInitials", personalDetail.MiddleInitials);
				cmd.Parameters.AddWithValue("@LastName", personalDetail.LastName);
				cmd.Parameters.AddWithValue("@Gender", personalDetail.Gender);
				cmd.Parameters.AddWithValue("@DOB", personalDetail.DOB);
				cmd.Parameters.AddWithValue("@PermAddrRow1", personalDetail.PermAddrRow1);
				cmd.Parameters.AddWithValue("@PermAddrRow2", personalDetail.PermAddrRow2);
				cmd.Parameters.AddWithValue("@PermAddrCity", personalDetail.PermAddrCity);
				cmd.Parameters.AddWithValue("@PermAddrZipCode", personalDetail.PermAddrZipCode);
				cmd.Parameters.AddWithValue("@PermAddrState", personalDetail.PermAddrState);
				cmd.Parameters.AddWithValue("@PermAddrCountry", personalDetail.PermAddrCountry);
				cmd.Parameters.AddWithValue("@TempAddrRow1", personalDetail.TempAddrRow1);
				cmd.Parameters.AddWithValue("@TempAddrRow2", personalDetail.TempAddrRow2);
				cmd.Parameters.AddWithValue("@TempAddrCity", personalDetail.TempAddrCity);
				cmd.Parameters.AddWithValue("@TempAddrZipCode", personalDetail.TempAddrZipCode);
				cmd.Parameters.AddWithValue("@TempAddrState", personalDetail.TempAddrState);
				cmd.Parameters.AddWithValue("@TempAddrCountry", personalDetail.TempAddrCountry);

				cmd.ExecuteNonQuery();
			}
		}
	}
}
