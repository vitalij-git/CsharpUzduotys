using _6._Generics.Models;


namespace _6._Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InputValidate();
            //ValidatesMoreOne();
            //GenericsMethod();
            //Types();
            GeometricFigures();
            Console.ReadKey();
        }
        
        static void InputValidate()
        {
            var validate = Validation.Validate<string>("name");
            var validateEmpty = Validation.Validate<string>("");
            var validate1 = Validation.Validate<string>(null);
            var validate2 = Validation.Validate<int?>(null);
            var validate4 = Validation.Validate<double>(4.5);
            var validate5 = Validation.Validate(new int[] { 4,5});
            var validate6 = Validation.Validate(new int[] {});
            var validate7 = Validation.Validate(new List<int>());
        }

        static void ValidatesMoreOne()
        {
            Validation.ShowValue<string, string>("Home", "Town");
            Validation.ShowValue<string, int>("music", 25);
        }

        static void GenericsMethod()
        {
            var values = new Method<int,int>(25,50);
            values.ShowFirstValue();
            values.ShowSecondValue();
            int newFirstValue = 30;
            values.UpdateFirstValue(newFirstValue);
            values.ShowFirstValue();
            int newSecondValue = 60;
            values.UpdateSecondValue(newSecondValue);
            values.ShowSecondValue();
        }

        static void Types()
        {
            var types = new Type<int,string>();
            types.GetTypeOfFirstInput();
            types.GetTypeOfSecondInput();
        }

        static void GeometricFigures()
        {
            var figure = new FourSideGeometricFigure("figure1", 15, 25);
            Generator<FourSideGeometricFigure>.Show(figure);
        }

        public void Sports()
        {

        }

    }
}