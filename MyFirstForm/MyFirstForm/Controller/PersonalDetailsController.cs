using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstForm
{
	public class PersonalDetailsController
	{
		private List<IUSState> _states;
		private List<ICountry> _countries;

		public List<string> GetCountryAbbrev()
		{
			if (_countries == null)
			{
				_countries = DBOperations.GetAllCountries();
			}

			List<string> countryAbbrev = new List<string>();
			countryAbbrev.AddRange(_countries.Select(item => (item as Country).Country_Abbrev));
			return countryAbbrev;
		}

		public List<string> GetStateAbbrev()
		{
			if (_states == null)
			{
				_states = DBOperations.GetAllUSStates();
			}

			List<string> stateAbbrev = new List<string>();
			stateAbbrev.AddRange(_states.Select(item => (item as USState).State_Abbrev));
			return stateAbbrev;
		}

		public List<IUSState> GetAllStates()
		{
			if (_states == null)
			{
				_states = DBOperations.GetAllUSStates();
			}
			return _states;
		}

		public List<ICountry> GetAllCountries()
		{
			if (_countries == null)
			{
				_countries = DBOperations.GetAllCountries();
			}
			return _countries;
		}
	}
}
