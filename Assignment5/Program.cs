namespace Assignment5
{
    internal class Program
    {

        #region Q1
        //public static void SwapByValue(int a, int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;

        //}
        //public static void SwapByRef(ref int a, ref int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //}
        #endregion
        #region Q2
        //public static void ChangeArray(int[] Num)
        //{
        //    Num[0] = 100;
        //    int temp;
        //    temp = Num[0];
        //    Num[0] = Num[1];
        //    Num[1] = temp;

        //}
        //public static void ChangeArrayRef( ref int[] Num)
        //{
        //    Num[0] = 100;
        //    int temp;
        //    temp = Num[0];
        //    Num[0] = Num[1];
        //    Num[1] = temp;

        //}
        // by value or by reference in ref type has the same result because the have the address
        // the diff in by value new place has a copy from the address by ref pointed in the same add
        #endregion
        #region Q3
        //public static void  SumAndSub(int a, int b, int c, int d, out int Sum, out int Sub)
        //{
        //    Sum = a+b+c+d;
        //    Sub = a-b;
        //}
        #endregion
        #region Q4
        //public static int SumDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        int reminder = num % 10;
        //        sum += reminder;
        //        num /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region Q5
        //public static void IsPrime(int Num)
        //{
        //    int i;
        //    if (Num > 1)
        //    {
        //        for (i = 2; i < (Num / 2) ; i++)
        //        {
        //            if (Num % i == 0)
        //            {
        //                Console.WriteLine("Number is not prime");
        //                break;
        //            }
        //        }

        //        if(i>=(Num/2))
        //        {
        //            Console.WriteLine("Number is prime");

        //        }

        //    }

        //}

        #endregion
        #region Q6
        //public static void MinMaxArray(ref int[] arr,out int Max,out int Min)

        //{
        //    Max = arr[0];
        //    Min=arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i+1;j < arr.Length; j++)
        //        {
        //            if (arr[j] > Max)
        //            {
        //                Max = arr[j];
        //            }
        //            if (arr[j] < Min)
        //            {
        //                Min = arr[j];
        //            }

        //        }

        //    }
        //}
        #endregion
        #region Q7
        //public static int Factorial(int Num)
        //{
        //    int result=1;
        //    while (Num>1)
        //    {
        //        result *= Num;
        //        Num--;
        //    }
        //    return result;

        //}
        #region Recursive
        //public static int Factorial(int Num)
        //{
        //    if (Num == 0 || Num == 1) {  return 1; }
        //    return Num*Factorial(Num - 1);

        //}
        #endregion
        #endregion
        #region Q8
        //public static string ChangeChar(string word,char a,int pos) {
        //    string replace = "";
        //    for (int i = 0; i < word.Length; i++) 
        //    {
        //        if (i == pos)
        //        {
        //            replace += a;
        //        }
        //        else
        //        {
        //            replace += word[i];
        //        }  
        //    }
        //    return replace;
        //}

        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("By Value");
            //int a = 10, b = 20;
            //Console.WriteLine("Before Swaping");
            //Console.WriteLine("A = " + a);
            //Console.WriteLine("B = " + b);
            //SwapByValue(a, b);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine("A = " + a);
            //Console.WriteLine("B = " + b);
            ////in this the value not changed because in the fram of function it has copy of the variables and swap in this copy
            ////after execution of the function all is deleted and the value is still the same

            //Console.WriteLine("By Reference");
            //Console.WriteLine("Before Swaping");
            //Console.WriteLine("A = " + a);
            //Console.WriteLine("B = " + b);
            //SwapByRef(ref a, ref b);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine("A = " + a);
            //Console.WriteLine("B = " + b);
            //// in reference the fuction has the address so any change will be changed in the reference in the variables so the values changed
            #endregion
            #region Q2
            //Console.WriteLine("By Value");
            //int[]number = { 1, 2, 3 ,4,5};
            //ChangeArray(number);
            //Console.WriteLine("After Function");
            //Console.WriteLine("index1= " + number[0]);
            //Console.WriteLine("index2= " + number[1]);
            //Console.WriteLine("By Reference");
            //int[] number = { 1, 2, 3, 4, 5 };
            //ChangeArrayRef(ref number);
            //Console.WriteLine("After Function");
            //Console.WriteLine("index1= " + number[0]);
            //Console.WriteLine("index2= " + number[1]);
            #endregion
            #region Q3
            //Console.WriteLine("Enter for numbers");
            //int a=int.Parse(Console.ReadLine());
            //int b=int.Parse(Console.ReadLine());
            //int c=int.Parse(Console.ReadLine());
            //int d=int.Parse(Console.ReadLine());
            //int Sum, Sub;
            //SumAndSub(a, b, c, d, out Sum, out Sub);
            //Console.WriteLine("Sum = " + Sum);
            //Console.WriteLine("Subtraction = " + Sub);
            #endregion
            #region Q4
            //Console.WriteLine("Enter Number");
            //int num=int.Parse(Console.ReadLine());
            //int result=SumDigits(num);
            //Console.WriteLine("Result= "+result);
            #endregion
            #region Q5
            //Console.WriteLine("Enter Number");
            //int num=int.Parse(Console.ReadLine());
            //IsPrime(num);

            #endregion
            #region Q6
            //int[] arr = {10,20,25,36,98,10,60};
            //int Max, Min;
            //MinMaxArray(ref arr,out Max,out Min);
            //Console.WriteLine("Max = " + Max);
            //Console.WriteLine("Min = " + Min);

            #endregion
            #region Q7
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //int fact = Factorial(num);
            //Console.WriteLine("Factorial = " + fact);
            #endregion
            #region Q8
            //Console.WriteLine("Enter String");
            //string Word=Console.ReadLine();
            //Console.WriteLine("Enter Char that you want");
            //char Char=Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //Console.WriteLine("Enter Position of Character");
            //int pos=int.Parse(Console.ReadLine());
            //string result=ChangeChar(Word,Char,pos);
            //Console.WriteLine("After Change "+result);

            //can make char as a string 
            #endregion

        }
    }
}
