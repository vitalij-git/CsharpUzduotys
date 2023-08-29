using _2.OrderByAndGruopBy.SqlDatabase;
using System.Data.SqlClient;

namespace _2.OrderByAndGroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
            GetWorkerByBirthDate();
            Console.WriteLine(2);
            GetWorkersWhichBirthDateBeforeByDate();
            Console.WriteLine(3);
            Task3();
            Console.WriteLine(4);
            Task4();
            Console.WriteLine(5);
            Task5();
            Console.WriteLine(6);
            Task6();
            Console.WriteLine(7);
            Task7();
            Console.WriteLine(8);
            Task8();
            Console.WriteLine(9);
            Task9();
            Console.WriteLine(10);
            Task10();
            Console.WriteLine(11);
            Task11();
            Console.WriteLine(12);
            Task12();
            Console.WriteLine(13);
            Task13();
            Console.WriteLine(14);
            Task14();
            Console.WriteLine(15);
            Task15();
            Console.WriteLine(16);
            Task16();


        }

        private static void GetWorkerByBirthDate()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select asmenskodas, vardas, pavarde from darbuotojas where gimimometai = '1988-07-29'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) 
            {
                string personalCode = reader["asmenskodas"].ToString();
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                Console.WriteLine($"Vardas {firstName} pavarde {lastName} asmens kodas {personalCode}");
            }
           
            connect.CloseConection();   
        }

        private static void GetWorkersWhichBirthDateBeforeByDate()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select * from darbuotojas where gimimometai < '1988-07-29'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string personalCode = reader["asmenskodas"].ToString();
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string startDate = reader["dirbanuo"].ToString();
                string birthDate = reader["gimimometai"].ToString();
                string role = reader["pareigos"].ToString();
                string department = reader["skyrius_pavadinimas"].ToString();
                string projectId = reader["projektas_id"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName} asmens kodas {personalCode} dirba nuo {startDate}" +
                    $"\ngimimo data {birthDate} pareigos {role} skyrius {department} projektas {projectId}");
            }

            connect.CloseConection();
        }

        private static void Task3()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select dirbanuo,gimimometai from darbuotojas where dirbanuo > '2009-10-30' and dirbanuo < '2012-11-11'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string startDate = reader["dirbanuo"].ToString();
                string birthDate = reader["gimimometai"].ToString();
                Console.WriteLine($"{startDate} {birthDate}" );
            }
        }
        
        private static void Task4()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,asmenskodas from darbuotojas Where projektas_id In(2,3)";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string personalCode = reader["asmenskodas"].ToString();
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                Console.WriteLine($"Vardas {firstName} pavarde {lastName} asmens kodas {personalCode}");
            }

            connect.CloseConection();
        }

        private static void Task5()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,asmenskodas from darbuotojas where asmenskodas like '4%'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string personalCode = reader["asmenskodas"].ToString();
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                Console.WriteLine($"Vardas {firstName} pavarde {lastName} asmens kodas {personalCode}");
            }

            connect.CloseConection();
        }

        private static void Task6()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select * from darbuotojas where gimimometai like '%12'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string personalCode = reader["asmenskodas"].ToString();
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string startDate = reader["dirbanuo"].ToString();
                string birthDate = reader["gimimometai"].ToString();
                string role = reader["pareigos"].ToString();
                string department = reader["skyrius_pavadinimas"].ToString();
                string projectId = reader["projektas_id"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName} asmens kodas {personalCode} dirba nuo {startDate}" +
                    $"\ngimimo data {birthDate} pareigos {role} skyrius {department} projektas {projectId}");
            }

            connect.CloseConection();
        }

        private static void Task7() 
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select * from projektas where pavadinimas like '__u%'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["id"].ToString();
                string title = reader["pavadinimas"].ToString();
                

                Console.WriteLine($"Id {id} pavadinimas {title} ");
            }

            connect.CloseConection();
        }

        private static void Task8()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select * from darbuotojas where pareigos is null";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string personalCode = reader["asmenskodas"].ToString();
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string startDate = reader["dirbanuo"].ToString();
                string birthDate = reader["gimimometai"].ToString();
                string role = reader["pareigos"].ToString();
                string department = reader["skyrius_pavadinimas"].ToString();
                string projectId = reader["projektas_id"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName} asmens kodas {personalCode} dirba nuo {startDate}" +
                    $"\ngimimo data {birthDate} pareigos {role} skyrius {department} projektas {projectId}");
            }

            connect.CloseConection();
        }

        private static void Task9() 
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,dirbanuo,pareigos from darbuotojas where dirbanuo > '2011-02-10' and  pareigos like 'programuotoja%'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string startDate = reader["dirbanuo"].ToString();
                string role = reader["pareigos"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName}  dirba nuo {startDate} pareigos {role} ");
            }

            connect.CloseConection();
        }

        private static void Task10()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,skyrius_pavadinimas,projektas_id from darbuotojas where skyrius_pavadinimas = 'java' or projektas_id = 1";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string department = reader["skyrius_pavadinimas"].ToString();
                string projectId = reader["projektas_id"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName}  skyrius {department} projektas {projectId}");
            }

            connect.CloseConection();
        }

        private static void Task11()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas from darbuotojas where vardas not like 's%'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader["vardas"].ToString();


                Console.WriteLine($"Vardas {firstName} ");
            }

            connect.CloseConection();
        }

        private static void Task12()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,dirbanuo,gimimometai from darbuotojas where   dirbanuo  not between '2009-10-30' and '2012-11-11'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string startDate = reader["dirbanuo"].ToString();
                string birthdate = reader["gimimometai"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName}  dirba nuo {startDate} gimimo metai  {birthdate} ");
            }

            connect.CloseConection();
        }

        private static void Task13()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,gimimometai from darbuotojas  order by gimimometai";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string birthdate = reader["gimimometai"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName}   gimimo metai  {birthdate} ");
            }

            connect.CloseConection();
        }

        private static void Task14()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select vardas,pavarde,gimimometai from darbuotojas  order by gimimometai desc";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader["vardas"].ToString();
                string lastName = reader["pavarde"].ToString();
                string birthdate = reader["gimimometai"].ToString();

                Console.WriteLine($"Vardas {firstName} pavarde {lastName}   gimimo metai  {birthdate} ");
            }

            connect.CloseConection();
        }

        private static void Task15()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select  max(projektas_id) as max, min(projektas_id) as min from DARBUOTOJAS";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string min = reader["min"].ToString();
                string max = reader["max"].ToString();

                Console.WriteLine($"Minimum {min} maximum {max} ");
            }

            connect.CloseConection();
        }

        private static void Task16()
        {
            Connect connect = new Connect();
            SqlConnection connection = connect.ConnectToDatabase();
            string query = "Select  PROJEKTAS_ID,  count(PROJEKTAS_ID) as count  from DARBUOTOJAS where pareigos like 'programuotoja%' group by PROJEKTAS_ID";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string projectId = reader["projektas_id"].ToString();
                string count = reader["count"].ToString();

                Console.WriteLine($"Projektas {projectId} programuotoju skaicius {count} ");
            }

            connect.CloseConection();
        }

        private static void Task17()
        {

        }
    }
}