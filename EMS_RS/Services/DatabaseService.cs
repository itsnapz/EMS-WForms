using EMS_RS.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_RS.Services
{
    public class DatabaseService
    {
        private SqlConnection _connection;
        public DatabaseService()
        {
            Init();
        }
        public void Init()
        {
            SqlConnectionStringBuilder builder = new();

            builder.UserID = "emsLogin";
            builder.Password = "Heslo1234.";
            builder.InitialCatalog = "emsDb";
            builder.DataSource = "(localdb)\\mssqllocaldb";
            builder.TrustServerCertificate = true;

            _connection = new SqlConnection(builder.ConnectionString);
        }
        public bool Connect()
        {
            try
            {
                _connection.Open();

                return true;
            }
            catch (Exception ex)
            {

                Debug.Write(ex);
                return false;
            }
        }
        public IEnumerable<DoctorModel>? GetDoctors()
        {
            string cmd = $"SELECT * FROM [Doctor]";
            SqlCommand command = new(cmd, _connection);
            List<DoctorModel> doctors = new();

            try
            {
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DoctorModel doctor = new()
                        {
                            Doctor_Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Sex = reader.GetString(3),
                            Rank = reader.GetString(4),
                            Phone_Number = reader.GetInt32(5),
                            Hospital_Id= reader.GetInt32(6),
                            Password = reader.GetString(7),
                            Call_Sign= reader.GetString(8),
                            Birthday = reader.GetDateTime(9),
                            Reputation = reader.GetInt32(10),
                        };
                        doctors.Add(doctor);
                    }
                    return doctors;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
                return null;
            }
        }

        public IEnumerable<RespondModel> GetResponds(int Doctor_Id)
        {
            string cmd = $"SELECT * FROM [Respond] where [doctor_id] = {Doctor_Id}";
            SqlCommand command = new SqlCommand(cmd, _connection);
            List<RespondModel> responds = new();

            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RespondModel respond = new()
                        {
                            Respond_Id = reader.GetInt32(0),
                            Doctor_Id = reader.GetInt32(1),
                            Date = reader.GetDateTime(2),
                            Price = reader.GetInt32(3),
                            Car_Id = reader.GetInt32(4),
                            Patient_Id = reader.GetInt32(5),
                        };
                        responds.Add(respond);
                    }
                }
                foreach (var item in responds)
                {
                    item.Doctor = GetDoctor(item.Doctor_Id);
                }
                return responds;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }

        public DoctorModel? GetDoctor(int doctorId)
        {
            string cmd = $"SELECT * FROM [Doctor] where [doctor_id] = {doctorId}";
            SqlCommand command = new(cmd, _connection);
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();

                    return new DoctorModel()
                    {
                        Doctor_Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Sex = reader.GetString(3),
                        Rank = reader.GetString(4),
                        Phone_Number = reader.GetInt32(5),
                        Hospital_Id= reader.GetInt32(6),
                        Password = reader.GetString(7),
                        Call_Sign= reader.GetString(8),
                        Birthday = reader.GetDateTime(9),
                        Reputation = reader.GetInt32(10),
                    };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
    }
}
