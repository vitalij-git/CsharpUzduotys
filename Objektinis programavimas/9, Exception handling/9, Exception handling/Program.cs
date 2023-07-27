namespace _9__Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryConvertToDouble();
            TryArray();
        }
        static void TryConvertToDouble()
        {
            var number = "10a";
            try
            {
                Convert.ToDouble(number);
            }
            catch (SystemException errorMessage) 
            {
                Console.WriteLine(errorMessage.Message.ToString()); 
            }

        }

        static void TryArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (SystemException errorMessage)
            {
                Console.WriteLine(errorMessage.Message.ToString());     
            }
            var result = 0;
            int[] arr1 = { 19, 0, 75, 52 };
            for(int i=0; i<arr1.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr1[i] / arr1[i + 1]); 
                }
                catch(DivideByZeroException errorMessage)
                {
                    Console.WriteLine(errorMessage.Message.ToString()); 
                }
                catch ( SystemException errorMessage )
                {
                    Console.WriteLine(errorMessage.Message.ToString());
                }
            }
        }
    }
}