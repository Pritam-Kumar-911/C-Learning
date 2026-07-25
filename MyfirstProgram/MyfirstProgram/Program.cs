
Console.WriteLine("Hello, World!");


String name = "Pritam Kumar";

Console.WriteLine(name);

Console.WriteLine("Hello, " + name + "!");

//converting string to int 

String age = "21";

int age2 = Convert.ToInt32(age);

Console.WriteLine(age2);

//boolean value

bool value = false;
Console.WriteLine(value);

//var keyword (var automatically gets the datatype you dont have to give the type explicitly like int , String etc)

//var semester = 4;
//Console.WriteLine(semester);

//var school = "City school";
//Console.WriteLine(school);


////Taking input from user
//Console.WriteLine("What is your name?");
//var Myname = Console.ReadLine();
//Console.WriteLine("Hello, " + Myname + "!");

//guess game 

//int answer = 7;

//int i = 0;

//while(i < 3)
//{
//    Console.WriteLine("Guess the number between 1 to 10");
//    int guess = Convert.ToInt32(Console.ReadLine());
//    if (guess == answer)
//    {
//        Console.WriteLine("You guessed it right!");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Try again!");
//    }
//    i++;
//}   

//print a table of x number 
//Console.WriteLine("Enter a Number you want tale of");
//int number = Convert.ToInt32(Console.ReadLine());

//for(int  i = 1; i <= 10; i++)
//{
//    Console.WriteLine(number + " * " + i + " = " + number * i);
//}


//Enter a number 
//Console.WriteLine("Enter a Number X:");
//int value1 = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= value1; i++)
//{

//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }

//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}

//iterating over a string 
String male = "Hello this is pritam";

for (int i = male.Length-1; i >= 0; i--)
{
    Console.Write(male[i]);
    Thread.Sleep(100);
}












