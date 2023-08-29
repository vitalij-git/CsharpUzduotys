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

    }
}