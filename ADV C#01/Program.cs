using ADV_C_01.@interface;

namespace ADV_C_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Def:Generics allow you to write classes, interfaces and with type parameters.
            //The actual is specified when the is used,not when it is written.
            //Use:Type Safety, Code Reusability, Better Performance, Cleaner Code
            #endregion

            #region Q2
            //Container<int> s1 = new Container<int>();
            //s1.Add(10);
            //int value = s1.Get();
            //Console.WriteLine(value);
            #endregion

            #region Q3
            //Pair<int, string> p1 = new Pair<int, string>();
            //p1.Value = 10;
            //p1.Key = "ahmed";
            //p1.print();
            #endregion

            #region Q4
            //int a = 5;
            //int b = 10;
            //Helpers.Swap(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b}");
            #endregion

            #region Q5
            //Max maxFinder = new Max();
            //int max = Max.FindMax(5, 10, 3);
            //Console.WriteLine($"The maximum value is: {max}");
            #endregion

            #region Q6
            //Interfaces can also be generic. Any class that implements them must specify the type arguments.

            //IRepository<Student> repository = new StudentRepository();

            //Student s1 = new Student(1, "Ahmed");
            //Student s2 = new Student(2, "Omar");

            //repository.Add(s1);
            //repository.Add(s2);

            //Console.WriteLine(repository.Get(0));

            //repository.Remove(s1);

            //Console.WriteLine(repository.Get(0));
            #endregion
        }
    }
}

