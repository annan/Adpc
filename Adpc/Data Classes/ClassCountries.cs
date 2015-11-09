using System;
using System.Collections.Generic;
using System.Text;

namespace Adpc
{
    class ClassCountries
    {
        #region PrivateVariables
        private long _country_id;
        private string _country_code;
        private string _country_name;
        private string _active;
        #endregion

        #region PublicVariables
        public long CountryID
        {
            get { return _country_id; }
            set { _country_id = value; }
        }

        public string CountryCode
        {
            get { return _country_code; }
            set { _country_code = value; }
        }

        public string CountryName
        {
            get { return _country_name; }
            set { _country_name = value; }
        }

        public string Active
        {
            get { return _active; }
            set { _active = value; }
        }
        #endregion

        public Boolean SaveCountry() 
        {
            Boolean returnValue = true;
            string SQL = "insert into adpc.Countries(country_name,country_code,active,created_date) values('Ghana','GH',1,sysdate())";
            return returnValue;
        }
    }
}
