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
            _sqlConnection = new SqlConnection("Server=Kam-Office\\MSSQLSERVER01;Database=Epic;Trusted_Connection=True;");
           // _sqlConnection.Open();



            // reader.Close();
            //  dbConnection.Close();
            //Console.ReadLine();
        }

        public List<Apartment> GetApartments()
        {
            _apartments.Clear();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand("Select * from Apartments", _sqlConnection);

            var reader = _sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                
              //  _apartments.Add(new Apartment() { ID = (int)reader["ApartmentId"],Bed= (int)reader["Bed"],Bath= (int)reader["Bath"],
                                         //         Rent= (decimal)reader["Rent"],sqf = (int)reader["sqf"],TenentId= (int)reader["TenentId"] });
             
            }
            reader.Close();
            _sqlConnection.Close();

            return _apartments;
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

    }
}
