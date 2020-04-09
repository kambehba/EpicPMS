using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EpicPMS
{
    public class DataAccess
    {
        private string _storedProceduer { get; set; }
        private SqlConnection _sqlConnection { get; set; }
        private SqlCommand _sqlCommand { get; set; }

        private static DataAccess _instance;

        private List<Apartment> _apartments { get; set; }

        private List<Tenent> _tenents { get; set; }
        public static DataAccess Instance
        {
            get
            {
                if (_instance == null) { _instance = new DataAccess(); }

                return _instance;
            }

        }
        private DataAccess()
        {
            _apartments = new List<Apartment>();
            _tenents = new List<Tenent>();
            _sqlConnection = new SqlConnection("Server=Kam-Office\\MSSQLSERVER01;Database=Epic;Trusted_Connection=True;");
          
        }

       
        public List<Apartment> GetApartments(int bedcount)
        {
            switch(bedcount)
            {
                case 1: 
                    _storedProceduer = "GetOneBeds";
                    break;
                case 2:
                    _storedProceduer = "GetTwoBeds";
                    break;
                case 3:
                    _storedProceduer = "GetThreeBeds";
                    break;
            }
            
            _apartments.Clear();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand(_storedProceduer, _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            var reader = _sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                _apartments.Add(new Apartment()
                {
                    Id = (int)reader["Id"],
                    Bed = (int)reader["Bed"],
                    Bath = (int)reader["Bath"],
                    Rent = (decimal)reader["Rent"],
                    sqf = (int)reader["sqf"],
                    ApartmentNumber = (int)reader["ApartmentNumber"]
                });

            }
            reader.Close();
            _sqlConnection.Close();
            return _apartments;
        }

        public List<Tenent> GetTenents()
        {
            _storedProceduer = "GetTenents";

            _tenents.Clear();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand(_storedProceduer, _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            var reader = _sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                _tenents.Add(new Tenent()
                {
                    
                    Id = (int)reader["Id"],
                    firstName = (string)reader["FirstName"],
                    lastName = (string)reader["LastName"],
                    startDate = (DateTime)reader["StartDate"],
                    endDate = (DateTime)reader["EndDate"],
                    rent = (decimal)reader["Rent"],
                });

            }
            reader.Close();
            _sqlConnection.Close();
            return _tenents;
        }


        public bool AssignTenent(Tenent tenent)
        {
            _storedProceduer = "AssignTenent";
          
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand(_storedProceduer, _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            
            _sqlCommand.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar).Value = tenent.firstName;
            _sqlCommand.Parameters.Add("@lastName", System.Data.SqlDbType.NVarChar).Value = tenent.lastName;
            _sqlCommand.Parameters.Add("@startDate", System.Data.SqlDbType.Date).Value = tenent.startDate;
            _sqlCommand.Parameters.Add("@endDate", System.Data.SqlDbType.Date).Value = tenent.endDate;
            _sqlCommand.Parameters.Add("@rent", System.Data.SqlDbType.Int).Value = tenent.rent;
            _sqlCommand.Parameters.Add("@apartmentNumber", System.Data.SqlDbType.Int).Value = tenent.apartmentNumber;

            var reader = _sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
            return true;
        }






    }
}
