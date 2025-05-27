// See https://aka.ms/new-console-template for more information


//using System.Runtime.ExceptionServices;

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Asad");

////operators
//int a = 30, b = 10;
////Arithmetical operators
//Console.WriteLine(a + b);
//Console.WriteLine(a - b);
//Console.WriteLine(a * b);
//Console.WriteLine(a / b);
//Console.WriteLine(a % b);

//// assignment operators
//a += 23;// a = a + 23
//Console.WriteLine(a);
//a -= 23;// a = a - 23
//Console.WriteLine(a);
//a *= 3;// a = a * 3
//Console.WriteLine(a);
//a /= 3;// a = a / 3
//Console.WriteLine(a);


//// Comparison operators
//Console.WriteLine(a == b);//False
////Console.WriteLine(a != b);//True
////Console.WriteLine(a < b);//False
////Console.WriteLine(a > b);//True
//Console.WriteLine(a <= b);//False


////logical operators
////And

//Console.WriteLine(a <= b && a != b);

////or
//Console.WriteLine(a <= b || a != b);

////Not
//Console.WriteLine(!(a <= b) && a != b);

////conditional statements


//bool a = true;
//bool b = true;
//bool c = false;
//bool d = false;

////console.writeline(d || c);
////console.writeline(!a && !c);

//string g = "";
//do
//{
//    Console.WriteLine("please write your name");

//    g = Console.ReadLine();

//} while (g == "");

//Console.WriteLine("Hello, " + g);





//Console.WriteLine("Please Enter Your Age");
//String userAge = Console.ReadLine();


//if (int.Parse(userAge) > 18)
//{
//    Console.WriteLine("You Are Eligible For Vote");
//}
//else if (int.Parse(userAge) == 18)
//{
//    Console.WriteLine("Are you married");
//    Console.WriteLine("If yes Press 'Y' IF NO PRESS 'N'");
//    String userMarriageStatus = Console.ReadLine();
//    String capitalUserMarriageStatus = userMarriageStatus.ToUpper();
//    if (capitalUserMarriageStatus == "Y")
//    {
//        Console.WriteLine("Congratulations You Are eligible for vote");
//    }
//    else if (capitalUserMarriageStatus == "N")
//    {
//        Console.WriteLine("Sorry You Are NOT eligible for vote");
//    }
//    else
//    {
//        Console.WriteLine("Please give your answer in 'Y' OR 'N'");
//    }
//}
//else
//{
//    Console.WriteLine("You Are Not eligible for vote");
//}



//LOOPS

//FOR
//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}
////reverse counting
//for (int i = 100; i <= 1; i--)
//{
//    Console.WriteLine(i);
//}
////EVEN
//for (int i = 2; i <= 100; i =+2)
//{
//    Console.WriteLine(2);
//}
////ODD
//for (int i = 1; i <= 100; i +=2)
//{
//    Console.WriteLine(2);
//}
////5 TABLE
//for (int i = 5; i <= 50; i +=5)
//{
//    Console.WriteLine(2);
//}



//for (int k = 1; k <= 10; k ++)
//{
//    Console.WriteLine("2 x "+k+" = "+k *2);
//}
//for (int k = 1; k <= 10; k++)
//{
//    Console.WriteLine("24 x " + k + " = " + k * 24);
////};
//Console.WriteLine("Enter Any Table");

//String UserString = Console.ReadLine();

//for (int k = 1; k <= 10; k++)
//{
//    Console.WriteLine(UserString +"x " + k + " = " + k * int.Parse(UserString));
//}



//int[] scores = new int[5];
//scores[0] = 784;
//scores[1] = 409;
//scores[2] = 248974;
//scores[3] = 4842;
//scores[4] = 482;
//Console.WriteLine(scores[3]);


//foreach (int item in scores)
//{
//    Console.WriteLine(item);
//}
/////or/////////
//int[] scores = [200, 300, 400, 500];

//for (int i = 0; i < scores.Length; i++)
//{
//    Console.WriteLine(scores[i]);
//}

/////ARRAY METHOS//////////

//int[] scores = [200, 300, 400, 500];
//Array.Sort(scores);
//Array.Reverse(scores);
//Array.Clear(scores);

//Console.WriteLine(Array.IndexOf(scores, 400));
//scores.[Array.IndexOf(scores, 400)] = 54657858;

//for (int i = 0; i < scores.Length; i++)
//{
//    Console.WriteLine(scores[i]);
//}


//List<int> scores = [230, 890, 789, 237];
//scores.Add(240);
//Console.WriteLine(scores[0]);
//Console.WriteLine(scores[1]);
//Console.WriteLine(scores[2]);
//Console.WriteLine(scores[3]);
////OR/////
////foreach (int item in scores)
//{
//    Console.WriteLine(item);
//}

//scores.Sort();
//scores.Reverse();
//scores.Remove(789);
//scores.RemoveAt(1);
//scores.RemoveAll(x => x > 400);
//scores.Clear();
//Console.WriteLine(scores.Contains(23));
//Console.WriteLine(scores.Count);
//scores.Insert(2, 500/*/*)*/*/;
//    var myScores = scores.ToArray();
//Console.WriteLine(scores.Find(x => x > 400));
//Console.WriteLine(scores.IndexOf(2355));
//Console.WriteLine(myScores);




//foreach (int item in scores)
//{
//    Console.WriteLine(item);
//}


//Dictionary//////
//var marks = new Dictionary<string, int>
//{
//    {"Amit" , 83 },
//    {"Sara" , 92 }
//};
//marks["John"] = 78;
//foreach (var Kvp in marks)
//{
//    Console.WriteLine($"{Kvp.Key} {Kvp.Value}");  
//}


/*hashset*////////

//var emails = new HashSet<string>();
//emails.Add("a@domain.com");
//emails.Add("a@domain.com");
//emails.Add("b@domain.com");
//Console.WriteLine(emails.Count);
//foreach (var email in emails)
//{
//    Console.WriteLine(email);   
//}

//Console.WriteLine("Enter your Email");
//    string UserEmail = Console.ReadLine();
//Console.WriteLine(UserEmail + "@" + "gmail" + ".com");



//FIRST IN FIRST OUT (FIFO)

//var queue = new Queue<string>();
//queue.Enqueue("Customer 1");
//queue.Enqueue("Customer 2");
//queue.Enqueue("Customer 3");

//Console.WriteLine("items before Dequeue");

//Console.WriteLine(queue.Dequeue());
//Console.WriteLine(queue.Dequeue());

//Console.WriteLine("items  after Dequeue");

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}


//*last in first out (lifo)*/
//var actions = new Stack<string>();
//actions.Push("Open File");
//actions.Push("Edit text");



//Console.WriteLine("items before pop");
//Console.WriteLine(actions.Pop());

//Console.WriteLine("items after pop");
//foreach (var action in actions)
//{
//    Console.WriteLine(action);
//}


//using System.Collections;
//ArrayList list = new ArrayList();
//list.Add(10);
//list.Add("Heloo");

//int x = (int)list[0];
//int y= (int)list[1];

//foreach (var i in list)
//{ 
//    Console.WriteLine(i);
//}





//object oriented///


//Car mehran = new();

//mehran.brand = "Suzuki";

//mehran.speed = 100;
//mehran.drive();

//Car dala = new Car { brand = "Toyota Hillux, speed=120" };
//dala.drive();
//Car civic = new();
//Console.WriteLine(civic.brand);
//Console.WriteLine(civic.speed);


//List<int> h = new() { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(h);


//public class Car
//{
//    //public string? brand;
//    public string brand = "Default brand";
//    public int speed;


//    public void drive()
//    {
//        Console.WriteLine($"Driving {brand} at {speed} km/h");

//}

//}


//encapsulation//////

//using System.Security.Cryptography.X509Certificates;

//BankAccount amjadAccount = new();

//amjadAccount.Deposit(780);

//Console.WriteLine(amjadAccount.GetBalance());

//BankAccount arifAccount = new();

// Console.WriteLine(arifAccount.GetBalance());

//public class BankAccount
//{
//    private double balance = 0;
//    public void Deposit(double amount)
//    {
//        if (amount < 0) balance += amount;
//    }
//    public double GetBalance()
//    {
//        return balance;

//    }

//}

//Dog dog = new();
//dog.Eat;
//dog.Bark();

//Cat tom = new();
//tom.Name = "Tom";
//tom.age = "2";
//tom.bread = "French";
//    tom.color = " White";
//tom.Eat();
//tom.animalInfo();
////tom.Bark//

//public class Animal
//{
//    public string   Name;
//    public int age;
//    public string bread;
//    public string color;
//    public void Eat() => Console.WriteLine("Eating");
//    public void animalInfo() => Console.WriteLine($"The }{Name} age is: {age} where bread is :{bread} and color is: {color}");

//}


//public class Dog : Animal {
//    public void Bark() => Console.WriteLine("Barking")
//        public class Cat : Dog
//        }

















































