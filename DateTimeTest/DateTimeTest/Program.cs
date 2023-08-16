namespace DateTimeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            string dateTime = currentDateTime.ToString();
            Console.WriteLine(dateTime);
        }
    }
}