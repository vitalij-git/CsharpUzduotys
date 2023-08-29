namespace _1.Database
{
    using System;
    using System.Runtime;
    using System.Runtime.CompilerServices;
    using System.Globalization;
    using System.Diagnostics.Contracts;
    using _1.Database.SqlDatabase;
    using _1.Database.Models;
    using System.Data.SqlClient;

    public class Program
    {

        static void Main(string[] args)
        {
            //1
            Console.WriteLine(1);
            GetAllWorkers();
            //2
            Console.WriteLine(2);
            GetAllPersonalsCode();
            //3
            Console.WriteLine(3);
            GetAllNameSurnameAndRole();
            //4
            Console.WriteLine(4);
            GetDistinctRoles();
            //5
            Console.WriteLine(5);
            GetAllWhereCsharp();
            //6
            Console.WriteLine(6);
            GetRoleByWorker();
            //7
            Console.WriteLine(7);
            GetAllByBirthDate();
            //8
            Console.WriteLine(8);
            GetWorkesNameBySurname();
            //9
            Console.WriteLine(9);
            GetWorkesNameAndSurnameFromDepartment();
            //10
            Console.WriteLine(10);
            //AddNewWorker();
            //11
            Console.WriteLine(11);
           //AddNewWorkerWithNotAllValues();
            //12
            Console.WriteLine(12);
            //UpdateWorkerByPersonalCode();
            //13
            Console.WriteLine(13);
            //DeleteWorkerByPersonalCode();
            //14
            Console.WriteLine(14);
            //UpdateWorkerByLastName();
            //15
            Console.WriteLine(15);
            GetCountRoles();

        }
        private static void GetAllEmployees()
        {
            WorkerRepository workerRepository = new WorkerRepository();
            var workersDictionary = workerRepository.GetAll();
            ResultOutput(workersDictionary);
        }

        private static void ResultOutput(Dictionary<int, List<Worker>> workersDictionary)
        {
            foreach (var workers in workersDictionary)
            {
                Console.Write(workers.Key);
                foreach (var worker in workers.Value)
                {
                    Console.WriteLine($"First name: {worker.FirstName}" +
                        $"\nLast name: {worker.LastName}" +
                        $"\nRole: {worker.Role}" +
                        $"\nDepartnemt: {worker.Department}" +
                        $"\nPersonal code: {worker.PersonalCode}" +
                        $"\nBirth date: {worker.BirthDate}");
                }
            }
        }

        private static void GetAllEmployeesnationalKey()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select EmployeeNationalIDAlternateKey from DimEmployee";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    int employeeNationalKey = Convert.ToInt32(reader["EmployeeNationalIDAlternateKey"]);
                    Console.WriteLine(employeeNationalKey);
                }
            }
            connect.CloseConection();
        }

        private static void GetAllEmployeesFirstNameLastNameAndTitle()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select FirstName,LastName,Title from DimEmployee";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string title = reader["Title"].ToString();
                    Console.WriteLine($"First name is {firstName}, Last name is {lastName} and title is {title}");
                }
            }
            connect.CloseConection();
        }

        private static void GetDistinctDepartmentName()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select Distinct Title from DimEmployee";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    Console.WriteLine($"Title is {title}");
                }
            }
            connect.CloseConection();
        }

        private void EmployeesTask()
        {
            GetAllEmployees();
            GetAllEmployeesnationalKey();
            GetAllEmployeesFirstNameLastNameAndTitle();
            GetDistinctDepartmentName();
        }

        private static void GetAllWorkers()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select * from Darbuotojas";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string personalCode = reader["Asmenskodas"].ToString();
                    string firstName = reader["Vardas"].ToString();
                    string lastname = reader["Pavarde"].ToString();
                    string startDate = reader["Dirbanuo"].ToString();
                    string birthDate = reader["Gimimometai"].ToString();
                    string role = reader["pareigos"].ToString();
                    string department = reader["Skyrius_pavadinimas"].ToString();
                    string projectId = reader["Projektas_id"].ToString();
                    Console.WriteLine($"Vardas  {firstName}, Pavarde {lastname}, Asmens kodas {personalCode}, Darbo pradžios data {startDate}, Gimimo data {birthDate}, Pareigos {role}, Skyrius {department}, Projekto ID {projectId}");
                }
            }
            connect.CloseConection();
        }

        private static void GetAllPersonalsCode()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select * from Darbuotojas";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string personalCode = reader["Asmenskodas"].ToString();

                    Console.WriteLine($"Asmens kodas{personalCode}");
                }
            }
            connect.CloseConection();
        }

        private static void GetAllNameSurnameAndRole()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select Vardas,Pavarde,pareigos from Darbuotojas";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string firstName = reader["Vardas"].ToString();
                    string lastname = reader["Pavarde"].ToString();
                    string role = reader["pareigos"].ToString();
                    Console.WriteLine($"Vardas  {firstName}, Pavarde {lastname}, Pareigos {role}");
                }
            }
            connect.CloseConection();
        }

        private static void GetDistinctRoles()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select distinct pareigos from Darbuotojas";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string role = reader["pareigos"].ToString();
                    Console.WriteLine($"Pareigos {role}");
                }
            }
            connect.CloseConection();
        }

        private static void GetAllWhereCsharp()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select * from Darbuotojas where Skyrius_Pavadinimas='C#'";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string personalCode = reader["Asmenskodas"].ToString();
                    string firstName = reader["Vardas"].ToString();
                    string lastname = reader["Pavarde"].ToString();
                    string startDate = reader["Dirbanuo"].ToString();
                    string birthDate = reader["Gimimometai"].ToString();
                    string role = reader["pareigos"].ToString();
                    string department = reader["Skyrius_pavadinimas"].ToString();
                    string projectId = reader["Projektas_id"].ToString();
                    Console.WriteLine($"Vardas  {firstName}, Pavarde {lastname}, Asmens kodas {personalCode}, Darbo pradžios data {startDate}, Gimimo data {birthDate}, Pareigos {role}, Skyrius {department}, Projekto ID {projectId}");
                }
            }
            connect.CloseConection();
        }

        private static void GetRoleByWorker()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select Pareigos from Darbuotojas where Vardas='Giedrius'";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string role = reader["pareigos"].ToString();
                    Console.WriteLine($"Pareigos {role}");
                }
            }
            connect.CloseConection();
        }

        private static void GetAllByBirthDate()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select * from Darbuotojas where Gimimometai='1986-09-19'";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string personalCode = reader["Asmenskodas"].ToString();
                    string firstName = reader["Vardas"].ToString();
                    string lastname = reader["Pavarde"].ToString();
                    string startDate = reader["Dirbanuo"].ToString();
                    string birthDate = reader["Gimimometai"].ToString();
                    string role = reader["pareigos"].ToString();
                    string department = reader["Skyrius_pavadinimas"].ToString();
                    string projectId = reader["Projektas_id"].ToString();
                    Console.WriteLine($"Vardas  {firstName}, Pavarde {lastname}, Asmens kodas {personalCode}, Darbo pradžios data {startDate}, Gimimo data {birthDate}, Pareigos {role}, Skyrius {department}, Projekto ID {projectId}");
                }
            }
            connect.CloseConection();
        }

        private static void GetWorkesNameBySurname()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select Vardas from Darbuotojas where pavarde='Sabutis'";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string firstName = reader["Vardas"].ToString();
                    Console.WriteLine($"Vardas  {firstName}");
                }
            }
            connect.CloseConection();
        }
        private static void GetWorkesNameAndSurnameFromDepartment()
        {
            Connect connect = new Connect();
            string queryByPersonalCode = "Select Vardas,Pavarde from Darbuotojas where Skyrius_pavadinimas='Java'";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(queryByPersonalCode, sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string firstName = reader["Vardas"].ToString();
                    string lastName = reader["Pavarde"].ToString();
                    Console.WriteLine($"Vardas  {firstName}, Pavarde {lastName}");
                }
            }
            connect.CloseConection();
        }

        private static void AddNewWorker()
        {
            Connect connect = new Connect();
            string addNew = "Insert into Darbuotojas(Asmenskodas,Vardas,Pavarde,dirbanuo,gimimometai,pareigos,skyrius_pavadinimas,projektas_id)" +
                "values(@personalCode,@FirstName,@lastName,@startDate,@birthDate,@role,@department,@projectId)";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(addNew, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@personalCode", 332351115);
            sqlCommand.Parameters.AddWithValue("@FirstName", "Tomas");
            sqlCommand.Parameters.AddWithValue("@lastName", "Antonaitis");
            sqlCommand.Parameters.AddWithValue("@startDate", "2020-05-19");
            sqlCommand.Parameters.AddWithValue("@birthDate", "1990-05-06");
            sqlCommand.Parameters.AddWithValue("@role", "Programuotojas");
            sqlCommand.Parameters.AddWithValue("@department", "Java");
            sqlCommand.Parameters.AddWithValue("@projectId", 3);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Darbuotojas pridetas sekmingai");
            }
            connect.CloseConection();
        }

        private static void AddNewWorkerWithNotAllValues()
        {
            Connect connect = new Connect();
            string addNew = "Insert into Darbuotojas(Asmenskodas,Vardas,Pavarde,dirbanuo,gimimometai,pareigos)" +
                "values(@personalCode,@FirstName,@lastName,@startDate,@birthDate,@role)";
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(addNew, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@personalCode", 33245678);
            sqlCommand.Parameters.AddWithValue("@FirstName", "Simas");
            sqlCommand.Parameters.AddWithValue("@lastName", "Nepilnas");
            sqlCommand.Parameters.AddWithValue("@startDate", "2020-06-19");
            sqlCommand.Parameters.AddWithValue("@birthDate", "1990-09-06");
            sqlCommand.Parameters.AddWithValue("@role", "Programuotojas");
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Darbuotojas pridetas sekmingai");
            }
            connect.CloseConection();
        }

        private static void UpdateWorkerByPersonalCode()
        {
            Connect connect = new Connect();
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand("Update Darbuotojas Set skyrius_pavadinimas=@department, projektas_id = @projectId Where Asmenskodas='33245678'", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@department", "Testavimo");
            sqlCommand.Parameters.AddWithValue("@projectId", 3);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Darbuotojas atnaujintas");
            }   
            connect.CloseConection();   
        }

        private static void DeleteWorkerByPersonalCode()
        {
            Connect connect = new Connect();
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand("delete darbuotojas where asmenskodas='33245678'", sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Darbuotojas sekmingai istrintas");
            }
            connect.CloseConection();   
        }

        private static void UpdateWorkerByLastName()
        {
            Connect connect = new Connect();
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand("Update Darbuotojas Set pareigos=@role Where Pavarde='antonaitis'", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@role", "Testuotojas");
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Darbuotojas atnaujintas");
            }
            connect.CloseConection();
        }

        private static void GetCountRoles()
        {
            Connect connect = new Connect();
            SqlConnection sqlConnection = connect.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand("Select Count(Pareigos) from darbuotojas where Pareigos = 'testuotojas'", sqlConnection);
            int count = (int)sqlCommand.ExecuteScalar(); 
            Console.WriteLine(count);
        }
    }
      
}