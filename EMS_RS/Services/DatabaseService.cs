using EMS_RS.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
            SqlConnectionStringBuilder builder = new()
            {
                UserID = "emsLogin",
                Password = "Heslo1234.",
                InitialCatalog = "emsDb",
                DataSource = "(localdb)\\mssqllocaldb",
                TrustServerCertificate = true
            };

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

        public IEnumerable<RespondModel>? GetResponds(int Doctor_Id)
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
                    item.Car = GetCar(item.Car_Id);
                    item.Patient = GetPatient(item.Patient_Id);
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
        public CarModel? GetCar(int carId)
        {
            string cmd = $"SELECT * FROM [Car] where [car_id] = {carId}";
            SqlCommand command = new(cmd, _connection);
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();

                    return new CarModel()
                    {
                        Car_Id= reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Plate = reader.GetString(2),
                    };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
        public CarModel? GetCarByName(string name)
        {
            string cmd = $"SELECT * FROM [Car] WHERE [name]={name}";
            SqlCommand command = new(cmd, _connection);
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new CarModel()
                        {
                            Car_Id = reader.GetInt32(0),
                            Name = reader.GetString(0),
                            Plate = reader.GetString(1),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
        public IEnumerable<CarModel> GetCars()
        {
            string cmd = $"SELECT * FROM [Car]";
            SqlCommand command = new(cmd, _connection);
            List<CarModel> cars = new List<CarModel>();
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarModel car = new()
                        {
                            Car_Id= reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Plate = reader.GetString(2),
                        };
                        cars.Add(car);
                    }
                }
                return cars;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
        public PatientModel? GetPatient(int patientId)
        {
            string cmd = $"SELECT * FROM [Patient] WHERE [patient_id] = {patientId}";
            SqlCommand command = new(cmd, _connection);

            try
            {
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    return new PatientModel()
                    {
                        Patient_Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Birthday = reader.GetDateTime(3),
                        Sex = reader.GetString(4),
                        Street= reader.GetString(5),
                        City = reader.GetString(6),
                        Country = reader.GetString(7),
                        Zip = reader.GetString(8),
                        Phone_Number = reader.GetInt32(9),
                    };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
        public PatientModel? GetPatientByName(string name)
        {
            string cmd = $"SELECT * FROM [Patient] WHERE [name] [surname]={name}";
            SqlCommand command = new(cmd, _connection);
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new PatientModel()
                        {
                            Patient_Id= reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Birthday = reader.GetDateTime(3),
                            Sex = reader.GetString(4),
                            Street= reader.GetString(5),
                            City = reader.GetString(6),
                            Country = reader.GetString(7),
                            Zip = reader.GetString(8),
                            Phone_Number = reader.GetInt32(9),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
        public IEnumerable<PatientModel> GetPatients()
        {
            string cmd = $"SELECT * FROM [Patient]";
            SqlCommand command = new(cmd, _connection);
            List<PatientModel> patients = new();

            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PatientModel patient = new()
                        {
                            Patient_Id= reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Birthday = reader.GetDateTime(3),
                            Sex = reader.GetString(4),
                            Street = reader.GetString(5),
                            City = reader.GetString(6),
                            Country = reader.GetString(7),
                            Zip = reader.GetString(8),
                            Phone_Number = reader.GetInt32(9),
                        };
                        patients.Add(patient);
                    }
                }
                return patients;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
        public void InsertRespond(RespondModel respond)
        {
            string cmd = $"INSERT INTO [Respond](doctor_id, date, price, car_id, patient_id) VALUES({respond.Doctor_Id},'{DateTime.Now.ToString("yyyy-MM-dd")}',{respond.Price},{respond.Car_Id},{respond.Patient_Id})";
            SqlCommand command = new(cmd, _connection);
            command.ExecuteNonQuery();
        }
    }
}
