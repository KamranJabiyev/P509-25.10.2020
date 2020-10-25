using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {
        public delegate bool Check(int n);
        public delegate int Diference(int n, int m);
        //public delegate void Write(string word);
        //public delegate void Write2(int n);
        public delegate void Write<T>(T n);
        static void Main(string[] args)
        {
            #region Task
            //Queue<int> sira = new Queue<int>();
            //sira.Enqueue(1);
            //sira.Enqueue(2);
            //sira.Enqueue(3);
            //sira.Enqueue(4);
            //foreach (int item in sira)
            //{
            //    Console.WriteLine(item);
            //}
            //Queue<int> reverseSira = ReverseQueue(sira);
            //foreach (int item in reverseSira)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Delegate
            //Console.WriteLine(Sum(new int[]{10,15,20,25,30 },IsOdd));
            //Console.WriteLine(Sum(new int[] { 10, 15, 20, 25, 30 }, IsElder));
            //Console.WriteLine(Sum(new int[] { 10, 15, 20, 25, 30 }, IsEven));
            #region delegate - anonymous,lambda expression
            //int[] arr = new int[] { 10, 15, 20, 25, 30 };
            //anonymous method
            //int res = Sum(arr,delegate(int n) 
            //{ 
            //    return n % 5 == 0; 
            //});
            //int r = Sum(arr, delegate (int n)
            //{
            //    return n % 21 == 0;
            //});
            //lambda expression
            //int res = Sum(arr, n => n % 5 == 0);

            //Test(delegate (int n, int m) { return n - m; });
            //Test((n, m) => n - m);
            //Test((n, m) =>
            //{
            //    if (n > m)
            //        return n - m;
            //    return m - n;
            //});
            #endregion

            //Write<string> write = new Write<string>(GetWord);
            //write += GetLength;
            //write += UpperWord;
            //write += delegate (string s) { Console.WriteLine(s.ToLower()); };
            //write += s => Console.WriteLine(s[0]);
            //write -= GetWord;
            //write -= delegate (string s) { Console.WriteLine(s.ToLower()); };
            //write("Rufet");

            //Write<int> writeInt = new Write<int>(GetInt);

            #region Func,Action,Predicate
            //func
            //Func<int, int, string> func =(int n, int m)=> $"n={n},m={m}";
            //Console.WriteLine(func(10, 15));
            //Func<string, int> func1 = s => s.Length;
            //Console.WriteLine(func1("Rufet"));

            //action
            //Action<string> action = GetLength;
            //action += UpperWord;
            //action += s => Console.WriteLine(s.ToLower());
            //action("Hello World");

            //predicate
            //Predicate<int> predicate = IsEven;
            //predicate += num => num > 0;
            //Console.WriteLine(predicate(-5));
            //List<string> numbers = new List<string>();
            //numbers.Add("1");
            //numbers.Add("2");
            //numbers.Add("3");
            //Console.WriteLine(numbers.Find(n => n == "5"));
            #endregion
            #endregion

            #region Event
            Student s1 = new Student("Aqil Beshirov", 64);
            s1.Notify += delegate (int mark)
              {
                  if (mark < 65)
                  {
                      Console.WriteLine("Hormetli valideyn oglunuz diplom ala bilmedi");
                      return;
                  }
                  Console.WriteLine("Hormetli valideyn vecinize de olmasa ushaq oxuyan ushaqgdi.Tebrikler");
              };
            Student s2 = new Student("Reshad Xan", 4);
            s2.Notify += mark =>
            {
                if (mark < 65)
                {
                    Console.WriteLine("Hormetli valideyn oglunuzu rahat doye bilersiz");
                    return;
                }
                Console.WriteLine("Tebrikler,baxin daaa");
            };
            s1.SendMail();
            s2.SendMail();
            #endregion

        }
        #region Delegate

        public static void GetInt(int n)
        {
            Console.WriteLine(n);
        }
        public static void GetLength(string str)
        {
            Console.WriteLine(str.Length);
        }

        public static void UpperWord(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void GetWord(string str)
        {
            Console.WriteLine(str);
        }
        public static void Test(Diference func)
        {
            Console.WriteLine(func(10,15));
        }
        public static int Sum(int[] arr,Check func)
        {
            int result=0;
            foreach (int num in arr)
            {
                if (func(num))
                    result += num;
            }
            return result;
        }

        public static bool IsEven(int num)
        {
            Console.WriteLine("in isEven");
            return num % 2 == 0;
        }

        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool IsElder(int num)
        {
            return num > 20;
        }
        #endregion

        #region Task
        //public static Queue<int> ReverseQueue(Queue<int> q)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int count = q.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        stack.Push(q.Dequeue());
        //    }
        //    for (int i = 0; i < count; i++)
        //    {
        //        q.Enqueue(stack.Pop());
        //    }

        //    return q;
        //}
        #endregion
    }
}
