namespace Second_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anketa();
            //Kintamieji();
            //Konsole();
            Konsole2();
        }
        static void  Calculator()
        {
            double q = 10;
            float w = 11;
            float myFloat = 1.01f;
            byte bitas = 8;
            short sh = 254;
            long lg = 2343;
            decimal dec = 65545;
            int a = 7;
            int b = 5;
            int sum = a + b;
            int sub = a - b;
            int div = a / b;
            int mult = a * b;
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mult);
            Console.WriteLine("Parasykite pirma skaiciu");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parasykite antra skaiciu");
            int y = Convert.ToInt32(Console.ReadLine());
            int suma = x + y;
            int skirtumas = x - y;
            int daugiklis = x * y;
            int daliklis = x / y;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Skirtumas: " + skirtumas);
            Console.WriteLine("Daugiklis: " + daugiklis);
            Console.WriteLine("Daliklis: " + daliklis);

        }
        static void Anketa() {
            Console.WriteLine("Parasykite savo varda");
            var name = Console.ReadLine();
            Console.WriteLine("Parasykite savo pavarde");
            var surname = Console.ReadLine();
            Console.WriteLine("Parasykite savo amziu");
            var age = Console.ReadLine();
            Console.WriteLine("Parasykite savo Pareigos");
            var position = Console.ReadLine();
            Console.WriteLine("Parasykite savo El. pasta");
            var email = Console.ReadLine();
            Console.WriteLine("Parasykite savo telefono numeri");
            var number = Console.ReadLine();

            Console.WriteLine("=============== VIZITINE ===============");
            Console.WriteLine("Vardas: " + name + surname );
            Console.WriteLine("Amzius: " + age);
            Console.WriteLine("Pareigos: " + position);
            Console.WriteLine("E. Pastas: " + email);
            Console.WriteLine("Tel: " + number);
            Console.WriteLine("========================================");
        }
        static void Kintamieji()
        {
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue || isFalse);
            Console.WriteLine(isTrue && isFalse);
            Console.WriteLine(!isFalse);
            Console.WriteLine(!isTrue);
            Console.WriteLine(isTrue ^ isFalse);
            if (isTrue != isFalse)
            {
                Console.WriteLine(true);
            }
            else if (isTrue == isFalse)
            {
                Console.WriteLine(false);
            }
            double number = 124.2657415;
            Console.WriteLine(number.ToString("F4"));
            Console.WriteLine(number.ToString("E2"));
        }
        static void Konsole()
        {
            //1
            Console.WriteLine("Parasykite pirma sveikaji skaiciu");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parasykite antra sveikaji skaiciu");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parasykite skaiciu su kablieliu");
            double z = Convert.ToDouble(Console.ReadLine());
            double suma = x + y + z;
            double skirtumas = x - y - z;
            double sandauga = x * y * z;
            double dalyba = x / y / z;
            Console.WriteLine($"Suma: {suma} \nSkirtumas: {skirtumas} \nSandauga: {sandauga} \nDalyba: {dalyba}");

            //2
            Console.WriteLine("Parasykite  skaiciu");
            double myDouble= double.Parse(Console.ReadLine());
            myDouble *= myDouble;
            Console.WriteLine(myDouble);


            //3
            Console.WriteLine("Parasykite pirma sveikaji skaiciu");
            int a = int.Parse(Console.ReadLine());
            double b = Convert.ToDouble(a);
            Console.WriteLine("Parasykite antraji  skaiciu");
            double c = Convert.ToDouble(Console.ReadLine());
            double sumad = b + c;
            double skirtumasd = b - c;
            double sandaugad = b * c;
            double dalybad = b / c;
            Console.WriteLine($"Suma: {sumad} \nSkirtumas: {skirtumasd} \nSandauga: {sandaugad} \nDalyba: {dalybad}");
            
        }

        static void Konsole2()
        {
            //1
            Console.WriteLine("Parasykite pirma sveikaji skaiciu");
            var number = Console.ReadLine();
            int integer;
            if (int.TryParse(number, out integer ))
            {
                int x = Convert.ToInt32(number);
                Console.WriteLine("Parasykite antra skaiciu");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Parasykite trecia skaiciu ");
                double z = Convert.ToDouble(Console.ReadLine());
                double suma = x + y + z;
                double skirtumas = x - y - z;
                double sandauga = x * y * z;
                Console.WriteLine($"Suma: {suma} \nSkirtumas: {skirtumas} \nSandauga: {sandauga.ToString("F0")} ");
            }
            else
            {
                Console.WriteLine("Parasete bloga skaiciu, bandykite dar karta");
                Konsole2();
            }
                
            
            

            //2
            
            Console.WriteLine("Parasykite  skaiciu ");
            double myDouble = Convert.ToDouble(Console.ReadLine());
            double square = myDouble * myDouble;    
            double cube = square * myDouble;
            double root = Math.Sqrt(myDouble);
            Console.WriteLine($"Kvadratas: {square.ToString("F2")} \nKubas: {cube.ToString("F2")}\nSaknis: {root.ToString("F2")}");

           
        }
    }
}
                                   


            
    