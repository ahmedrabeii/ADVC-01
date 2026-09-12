using ADV_C_01.Example;
using ADV_C_01.@interface;
using static ADV_C_01.Example.ExStruct;

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

            #region Q7
            //The struct constraint specifies that the type argument must be a value type.
            //It can be used with built-in value types such as int, double, and bool, or user-defined structs.

            //ExStruct.Example<int> e1 = new ExStruct.Example<int>(10);
            //Console.WriteLine(e1.Value);
            #endregion

            #region Q8
            //The class constraint specifies that the type argument must be a reference type,
            //such as a class, interface, delegate, or array.

            //ExClass.Example<string> e1 = new ExClass.Example<string>("Hello");
            //Console.WriteLine(e1.Value);
            #endregion

            #region Q9
            //The new() constraint specifies that the type must have a public parameterless constructor.
            //It allows the generic code to create an object using new T().

            //ExNew.Example<ExNew.Person> e1 =
            //    new ExNew.Example<ExNew.Person>();

            //ExNew.Person p = e1.CreateObject();

            //Console.WriteLine("Object Created");
            #endregion

            #region Q11
            //The base class constraint specifies that the type argument must inherit from a specific base class.

            //ExBase.Example<Animal> e = new ExBase.Example<Animal>();
            //e.Show(new Animal());
            #endregion

            #region Q12 
            //Multiple constraints can be applied using the where clause.

            //ExMultiple.Example<Dog> e =new ExMultiple.Example<Dog>();
            //e.Show(new Dog());
            #endregion

            #region Q13
            //The default keyword returns the default value of a type.
            #endregion

            #region Q14
            //SafeList<int> list = new SafeList<int>();

            //list.Add(10);
            //list.Add(20);

            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(5));
            #endregion

            #region Q15
            //Covariance: allows a derived type to be used where a base type is expected.
            //The out keyword is used for covariance and is mainly used for output value
            #endregion

            #region Q16
            //Contravariance: allows a base type to be used where a derived type is expected.
            //The in keyword is used for contravariance and is mainly used for input values
            #endregion
        }
    }
}

