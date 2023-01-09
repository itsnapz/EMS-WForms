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
                    foreach (var item in doctors)
                    {
                        item.Hospital = GetHospital(item.Hospital_Id);
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
        public IEnumerable<HospitalModel> GetHospitals()
        {
            string cmd = $"SELECT * FROM [Hospital]";
            SqlCommand command = new SqlCommand(cmd, _connection);
            List<HospitalModel> hospitals = new List<HospitalModel>();
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HospitalModel hospital = new()
                        {
                            Hospital_Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Street = reader.GetString(2),
                        };
                        hospitals.Add(hospital);
                    }
                    return hospitals;
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
        public HospitalModel? GetHospital(int Id)
        {
            string cmd = $"SELECT * FROM [Hospital] where [hospital_id] = {Id}";
            SqlCommand command = new(cmd, _connection);
            try
            {
                using(var reader = command.ExecuteReader())
                {
                    reader.Read();

                    return new HospitalModel()
                    {
                        Hospital_Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Street = reader.GetString(2),
                    };
                }
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
        public void InsertPatient(PatientModel patient)
        {
            //string cmd = $"INSERT INTO Patient (name, surname, birthday, sex, street, city, country, zip, phone_number) VALUES ({patient.Name},{patient.Surname},'{patient.Birthday.ToString("yyyy-MM-dd")}',{patient.Sex},{patient.Street},{patient.City},{patient.Country},{patient.Zip},{patient.Phone_Number})";
            string insertSql = "INSERT INTO Patient (name, surname, birthday, sex, street, city, country, zip, phone_number) VALUES (@name, @surname, @birthday, @sex, @street, @city, @country, @zip, @phone)";
            using (SqlCommand command = new SqlCommand(insertSql, _connection))
            {
                command.Parameters.AddWithValue("@name", patient.Name);
                command.Parameters.AddWithValue("@surname", patient.Surname);
                command.Parameters.AddWithValue("@birthday", patient.Birthday);
                command.Parameters.AddWithValue("@sex", patient.Sex);
                command.Parameters.AddWithValue("@street", patient.Street);
                command.Parameters.AddWithValue("@city", patient.City);
                command.Parameters.AddWithValue("@country", patient.Country);
                command.Parameters.AddWithValue("@zip", patient.Zip);
                command.Parameters.AddWithValue("@phone", patient.Phone_Number);
                command.ExecuteNonQuery();
            }
        }
        public void InsertDoctor(DoctorModel doctor)
        {
            string insertSql = $"INSERT INTO Doctor (name, surname, sex, rank, phone_number, hospital_id, password, call_sign, birthday, reputation) VALUES (@name, @surname, @sex, @rank, @phone, @hospital, @pass, @call, @birthday, @rep)";
            using (SqlCommand command = new SqlCommand(insertSql, _connection))
            {
                command.Parameters.AddWithValue("@name", doctor.Name);
                command.Parameters.AddWithValue("@surname", doctor.Surname);
                command.Parameters.AddWithValue("@sex", doctor.Sex);
                command.Parameters.AddWithValue("@rank", doctor.Rank);
                command.Parameters.AddWithValue("@phone", doctor.Phone_Number);
                command.Parameters.AddWithValue("@hospital", doctor.Hospital_Id);
                command.Parameters.AddWithValue("@pass", doctor.Password);
                command.Parameters.AddWithValue("@call", doctor.Call_Sign);
                command.Parameters.AddWithValue("@birthday", doctor.Birthday);
                command.Parameters.AddWithValue("@rep", doctor.Reputation);
                command.ExecuteNonQuery();
            }
        }
        public void InsertCar(CarModel car)
        {
            string insertSql = $"INSERT INTO Car (name, plate) VALUES (@name, @plate)";
            using (SqlCommand command = new SqlCommand(insertSql, _connection))
            {
                command.Parameters.AddWithValue("@name", car.Name);
                command.Parameters.AddWithValue("@plate", car.Plate);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateRespond(RespondModel respond, int Id)
        {
            string cmd = $"UPDATE Respond SET price = '{respond.Price}', car_id = '{respond.Car_Id}', patient_id = '{respond.Patient_Id}' WHERE respond_id = {Id}";
            SqlCommand command = new(cmd, _connection);
            command.ExecuteNonQuery();
        }
        public void UpdateDoctor(DoctorModel doctor, int Id)
        {
            string cmd = $"UPDATE Doctor SET name = '{doctor.Name}', surname = '{doctor.Surname}', sex = '{doctor.Sex}', rank = '{doctor.Rank}', phone_number = '{doctor.Phone_Number}', hospital_id = '{doctor.Hospital_Id}', password = '{doctor.Password}', call_sign = '{doctor.Call_Sign}', birthday = '{doctor.Birthday}', reputation = '{doctor.Reputation}' WHERE doctor_id = {Id}";
            SqlCommand command = new(cmd, _connection);
            command.ExecuteNonQuery();
        }
        public void UpdateDoctorPassword(string password, int Id)
        {
            string cmd = $"UPDATE Doctor SET password = '{password}' WHERE doctor_id = '{Id}'";
            using (SqlCommand command = new SqlCommand(cmd, _connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void UpdatePatient(PatientModel patient, int Id)
        {
            string cmd = $"UPDATE Patient SET name = '{patient.Name}', surname = '{patient.Surname}', birthday = '{patient.Birthday}', sex = '{patient.Sex}', street = '{patient.Street}', city = '{patient.City}', country = '{patient.Country}', zip = '{patient.Zip}', phone_number = '{patient.Phone_Number}' WHERE patient_id = {Id}";
            SqlCommand command = new(cmd, _connection);
            command.ExecuteNonQuery();
        }
        public void UpdateCar(CarModel car, int Id)
        {
            string cmd = $"UPDATE Car SET name = '{car.Name}', plate = '{car.Plate}' WHERE car_id = {Id}";
            SqlCommand command = new(cmd, _connection);
            command.ExecuteNonQuery();
        }
        public void DeleteRespond(RespondModel respond, int Id)
        {
            string cmd = $"DELETE FROM Respond WHERE respond_id = @ID";
            using (SqlCommand command = new SqlCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
            }
        }
        public void DeletePatient(PatientModel patient, int Id)
        {
            string cmd = $"DELETE FROM Patient WHERE patient_id = @ID";
            using (SqlCommand command = new SqlCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteDoctor(DoctorModel doctor, int Id)
        {
            string cmd = $"DELETE FROM Doctor WHERE doctor_id = @ID";
            using (SqlCommand command = new SqlCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteCar(CarModel car, int Id)
        {
            string cmd = $"DELETE FROM Car WHERE car_id = @ID";
            using (SqlCommand command = new SqlCommand(cmd, _connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@ID", Id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
