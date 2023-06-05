// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ASSIGNMENT OF CHAPTER 4;
// NUMBER ONE;
// int a = 2;
// int h = 3;
// int d = 4;
// int sum = a + h + d;
// Console.WriteLine(sum);

// NUMBER TWO;
// Console.WriteLine("Enter the radius of a circle");
// int radius = int.Parse(Console.ReadLine());
// double perimeter = 2 * 3.142 * radius;
// double area = 3.142 * radius * radius;
// Console.WriteLine("The perimeter of a circle is " + perimeter);
// Console.WriteLine("The area of a circle is " + area);

// NUMBER 3;
// Console.WriteLine("Enter the company address");
// string address = Console.ReadLine();
// Console.WriteLine("Enter your phone number");
// long num = long.Parse(Console.ReadLine());
// Console.WriteLine("Enter your fax number");
// string faxNum = Console.ReadLine();
// Console.WriteLine("Enter the company website");
// string website = Console.ReadLine();
// Console.WriteLine("Enter the manager name");
// string name = Console.ReadLine();
// Console.WriteLine("Enter the manager surname");
// string surname = Console.ReadLine();
// Console.WriteLine("Enter the manager phone number");
// long  num2  = long.Parse(Console.ReadLine());
// Console.WriteLine("the company address is" + address +  );


// NUMBER 6;
// Console.WriteLine("Enter the first number");
// double num = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter another number");
// double num2 = double.Parse(Console.ReadLine());
// double x = Math.Max( num,num2);
// Console.WriteLine("the biggest number is "+ x);





// ASSIGNMENT ON IF STATEMENT i.e CHAPTER FIVE;



// QUESTION 1;

int a = 10;
int b = 5;
int c = 0;
if(a > b)
{
   c=a;
   a=b;
   b=c;
   
}


// QUESTION 7;

// int a = 5;
// int b= 7;
// int c = 9;
// int d = 11;
// int f = 15;
// if(a > b && a > c && a > d && a > f)
// {
//       Console.WriteLine(a + " is the greatest number");
// }
// else if(b > c && b > d && b > f && b > a)
// {
//       Console.WriteLine(b + " is the greatest number");
// }
// else if(c > d && c > f && c > a && c > b)
// {
//       Console.WriteLine(c + " is the greatest number");
// }
// else if(d > f && d > a && d > b && d > c)
// {
//       Console.WriteLine(d + " is the greatest number");
// }
// else if(f >a && f > b && f > c && f > d)
// {
//       Console.WriteLine(f + " is the greatest number");
// }
// else
// {
//       Console.WriteLine("Invalid numbre");
// }


// QUESTION 5;
// Console.WriteLine("Enter a number between 0 and 9");
// int num = int.Parse(Console.ReadLine());


// switch(num)
// {
//       case 1:
//       Console.WriteLine("one");
//       break;
//       case 2:
//       Console.WriteLine("two");
//       break;
//       case 3:
//       Console.WriteLine("three");
//       break;
//       case 4:
//       Console.WriteLine("four");
//       break;
//       case 5:
//       Console.WriteLine("five");
//       break;
//       case 6:
//       Console.WriteLine("six");
//       break;
//       case 7:
//       Console.WriteLine("seven");
//       break;
//       case 8:
//       Console.WriteLine("eight");
//       break;
//       case 9:
//       Console.WriteLine("nine");
//       break;
//       default:
//       Console.WriteLine("Invalid number");
//       break;
// }

// int a = 5;


// NUMBER 3;
// int num = 0;
// int max = 0;
// if(num < 3)
// {
//     Console.WriteLine("Enter the first number");
//     int num = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the second number");
//     int num2 = int.Parse(Console.REadLine());
//     Console.WriteLine("Enter the third number");
//     int num3 = int.Parse(Console.ReadLine());
//     if(num > num2 && num > num3)
//     {
//         max = number;
//     }
//     if(num < num2 && num2 < num3)
//     {
//         max = num2;
//     }
//     if(num < num2 && num2 < num3)
//     {
//         max = num3;
//     }
//     Console.WriteLine(max);

    
// QUESTION 8;

// Console.WriteLine("Enter first varaible");
// int num = int.Parse(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     Console.WriteLine("Enter integer number");
//     int x = int.Parse(Console.ReadLine());
//     x++;
//     Console.WriteLine(x);
//     break;
//     case 2:
//     Console.WriteLine("Enter double figure");
//     double r = double.Parse(Console.ReadLine());
//     r++;
//     Console.WriteLine(r);
//     break;
//     case 3:
//     Console.WriteLine("Enter a string format");
//     string y = Console.ReadLine();
//     y += "*";
//     Console.WriteLine(y);
//     break;
//     default:
//     Console.WriteLine("Invalid term");
//     break;

// }



// NUMBER10;
// Console.WriteLine("Enter any nunber between 0 and 9");
// int kum = int.Parse(Console.ReadLine());

// switch(kum)
// {
//     case 1:
//     case 2:
//     case 3:
//     Console.WriteLine("the bonus score " + (kum * 10));
//     break;
//     case4:
//     case 5:
//     case 6:
//     Console.WriteLine("the bonus score " + (kum * 100));
//     break;
//     case 7:
//     case 8:
//     case 9:
//     Console.WriteLine("the bonus score " + (kum * 1000));
//     break;
//     default:
//     Console.WriteLine("Invalid number");
//     break;

// }

//  ASSIGNMENT 2;

// QUESTION 1;

// Console.WriteLine("Enter your number");
// int num = int.Parse(Console.ReadLine());
// if(num % 2 == 0)
// {
// Console.WriteLine("Number is even");
// }
// else
// {
// Console.WriteLine("Number is odd");
// }


// QUESTION 2;
// Console.WriteLine("Enter num");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 5 == 0 && num % 7 == 0)
// {
// Console.WriteLine(true);
// }
// else
// {
// Console.WriteLine(false);
// }

// QUESTION 7;
// Console.WriteLine("Enter a number");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine( num * 0.17d);

// QUESTION 5;
// Console.WriteLine("Enter a value");
// double aValue = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter b value");
// double bValue = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter h value");
// double hValue = double.Parse(Console.ReadLine());
// double surface = (aValue + bValue) * hValue / 2;
// Console.WriteLine("the surface is " + surface);

// QUESTION 8;
// Console.WriteLine("Enter the value of x");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the value of y");
// int y = int.Parse(Console.ReadLine());
// bool isEqual = (x*x) + (y*y) <= 5*5;
// Console.WriteLine(isEqual);

// QUESTION 6;
// Console.WriteLine("Enter the side of the rectangle");
// double side = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter the height of the rectangle");
// double height = double.Parse(Console.ReadLine());
// double perimeter = 2 * (side + height);
// double area = side * height;
// Console.WriteLine("the perimeter is " + perimeter);
// Console.WriteLine("the area is " + area);


// QUESTION 3;
// int num = 6789;      
// Console.WriteLine("Enter your number");
// int digit = int.Parse(Console.ReadLine());
// int div = num / 100;
// int GetlastNum = div % 10;
// if (GetlastNum == 7)
// {
//     Console.WriteLine("true");
// }
// else
// {
//     Console.WriteLine("false");
// }

//     QUESTION 4;
// Console.WriteLine("Enter a number");
// int num = int.Parse(Console.ReadLine());
// bool bit3 = (num & 8) != 0;
// Console.WriteLine(bit3);



// CHAPTER SEVEN;

// NUMBER ONE;
// int[] number = new int[20];
// for(int i = 0; i < number.Length; i++)
// {
//     number[i] = i * 5;
//     Console.Write(number[i] + " ");
// }

// NUMBER TWO;
// Console.WriteLine("Enter the first number");
// int f = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the second number");
// int k = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter length of an array");
// int length = int.Parse(Console.ReadLine());

// int[] num =new int[length];

// for(int i = 0; i < num.Length; i++)
// {
//    Console.WriteLine("Enter a given number");
//    int p = int.Parse(Console.ReadLine());
//    num[i] = p;

// }


// Console.WriteLine("Enter another length");
// int length2 = int.Parse(Console.ReadLine());
// int[] t = new int[length2];

// for(int r = 0; r < t.Length; r++)
// {
//     Console.WriteLine("Enter another number");
//     int y = int.Parse(Console.ReadLine());
//     t[r] = y;
// }

// if(length == length2)
// {
//     for(int i= 0; i < num.Length; i++)
//     if(t[i] != num[i])
//     {
//         Console.WriteLine("They are equal");
//     }
//     else
//     {
//         Console.WriteLine("they are not equal");
//     }

// }

// NUMBER 3;
 

   














