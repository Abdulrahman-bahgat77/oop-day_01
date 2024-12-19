using System.Linq.Expressions;
using Common;
using static oop_day_01.Program;
namespace oop_day_01
{
    //whta can write in namespace:
    //class
    //struct
    //interace
    //Enum

    //what access modifier in namespace:
    //public
    //internel

  
    internal class Program
    {

        #region exception handleing
        // static void doanything()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine());
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y; ///system.divide by zero exception
        //        int[] number = { 1, 2, 3, 4 };
        //        number[10] = 100; // system.indexoutofrangeexception
        //    }
        //    catch(Exception ex) {
        //        Console.WriteLine(ex.Message);
        //    }

        //}

        //static void protectcode()
        //{
        //    int x, y, z;
        //    bool flag1, flag2;
        //    do
        //    {
        //        Console.WriteLine("enter x");
        //        flag1 = int.TryParse(Console.ReadLine(), out x);
        //    } while (!flag1 ||x==0);

        //    do
        //    {
        //        Console.WriteLine("enter y");
        //        flag2 = int.TryParse(Console.ReadLine(), out y);
        //    } while (!flag2||y==0);
        //    z = x / y;

        //    int[] number = null;
        //    if (number.Length > 10)
        //    {
        //        number[10] = 100;
        //    }
        //}
        #endregion


        #region Enum
        public enum dayes :int
        {
            saturday,
            sunday,
            monday,
            tuesday,
            wedensday,
            thursday,
            friday
        }

        public enum gender :int
        {
          Male=0,Female=0
            
        }

        public enum grades
        {
            A,B,C,D,E,F
        }

        [Flags] // search for label sum of them =7 or 3 or...
        public enum permession :byte
        {
            delete=1,excute=2,read=4,write=8
        }
       
        class Employee
        {
            public string name;
            public int Age;
            public double salary;
            public gender gender;
            public permession permession;
        }

        #endregion
        static void Main(string[] args)
        {
            #region exception handeling
            //doanything();
            //eception:
            //system exception:
            //1.1format exception
            //1.2index out of range
            //1.3 null reference exception
            //1.4invalid operation exception
            //1.5 arithmetic exception
            //5.1-divided by zero
            //5.2- over flow exception
            //2-application exception

            //try
            //{
            //    protectcode();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(Console.ReadLine()); 
            //}
            #endregion


            #region Access Modifier
            TypeA TypeA=new TypeA();
            //TypeA.x = 10; //invalid
            //TypeA.y = 20; // invalid
            //TypeA.z = 30;//  valid y its public

            #endregion

            #region Enum
            //dayes day = dayes.friday;

            //if (day == dayes.friday)
            //{
            //    Console.WriteLine("its holiday");
            //}
            //else
            //{
            //    Console.WriteLine("go to work");
            //}

            //dayes a = (dayes)2;  //Explict casting
            //Console.WriteLine(a);// monday

            //dayes z = (dayes)10; //Explict casting
            //Console.WriteLine(z);//10
            ////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("enter your grade");

            //bool result = Enum.TryParse(typeof(grades), Console.ReadLine(), out object x);
            //Console.WriteLine(result);
            //Console.WriteLine($"your grade is {x}");


            // string gender = "malE";
            //// Enum.TryParse(typeof(gender), gender, out object result);
            //bool flag = Enum.TryParse<gender>(gender, true, out gender result);
            // Console.WriteLine(flag);
            // Console.WriteLine(result);

            // gender x=(gender) 0;
            // Console.WriteLine(x);

            //Employee employee = new Employee();
            //employee.name = "abdo";
            //employee.gender=gender.Male;
            //employee.permession = (permession)6;
            //Console.WriteLine(employee.permession);
            //employee.permession = employee.permession ^ permession.write;// to add write permession.
            //Console.WriteLine(employee.permession);
            //employee.permession = employee.permession ^ permession.write;// to remove write permession.
            //Console.WriteLine(employee.permession);


            //// to check if write is exist or not
            //if ((employee.permession & permession.write) == permession.write) {
            //    Console.WriteLine("write is exist ");


            //}
            //else
            //{
            //    Console.WriteLine("not exist and will added");
            //    employee.permession=employee.permession ^ permession.write;
            //    Console.WriteLine(employee.permession);
            //}
            #endregion

            #region Struct
            //point p1 = new point(1020);
            //Console.WriteLine($"x={p1.x}");
            //Console.WriteLine($"y={p1.y}");
            //Console.WriteLine(p1.ToString());
            
            #endregion

        }
    }
}
