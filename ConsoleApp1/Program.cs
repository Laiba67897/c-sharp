//// See https://aka.ms/new-console-template for more information


////using System.Runtime.ExceptionServices;

////Console.WriteLine("Hello, World!");

////Console.WriteLine("Hello, World!");

////Console.WriteLine("Asad");

//////operators
////int a = 30, b = 10;
//////Arithmetical operators
////Console.WriteLine(a + b);
////Console.WriteLine(a - b);
////Console.WriteLine(a * b);
////Console.WriteLine(a / b);
////Console.WriteLine(a % b);

////// assignment operators
////a += 23;// a = a + 23
////Console.WriteLine(a);
////a -= 23;// a = a - 23
////Console.WriteLine(a);
////a *= 3;// a = a * 3
////Console.WriteLine(a);
////a /= 3;// a = a / 3
////Console.WriteLine(a);


////// Comparison operators
////Console.WriteLine(a == b);//False
//////Console.WriteLine(a != b);//True
//////Console.WriteLine(a < b);//False
//////Console.WriteLine(a > b);//True
////Console.WriteLine(a <= b);//False


//////logical operators
//////And

////Console.WriteLine(a <= b && a != b);

//////or
////Console.WriteLine(a <= b || a != b);

//////Not
////Console.WriteLine(!(a <= b) && a != b);

//////conditional statements


////bool a = true;
////bool b = true;
////bool c = false;
////bool d = false;

//////console.writeline(d || c);
//////console.writeline(!a && !c);

////string g = "";
////do
////{
////    Console.WriteLine("please write your name");

////    g = Console.ReadLine();

////} while (g == "");

////Console.WriteLine("Hello, " + g);





////Console.WriteLine("Please Enter Your Age");
////String userAge = Console.ReadLine();


////if (int.Parse(userAge) > 18)
////{
////    Console.WriteLine("You Are Eligible For Vote");
////}
////else if (int.Parse(userAge) == 18)
////{
////    Console.WriteLine("Are you married");
////    Console.WriteLine("If yes Press 'Y' IF NO PRESS 'N'");
////    String userMarriageStatus = Console.ReadLine();
////    String capitalUserMarriageStatus = userMarriageStatus.ToUpper();
////    if (capitalUserMarriageStatus == "Y")
////    {
////        Console.WriteLine("Congratulations You Are eligible for vote");
////    }
////    else if (capitalUserMarriageStatus == "N")
////    {
////        Console.WriteLine("Sorry You Are NOT eligible for vote");
////    }
////    else
////    {
////        Console.WriteLine("Please give your answer in 'Y' OR 'N'");
////    }
////}
////else
////{
////    Console.WriteLine("You Are Not eligible for vote");
////}



////LOOPS

////FOR
////for (int i = 1; i <= 100; i++)
////{
////    Console.WriteLine(i);
////}
//////reverse counting
////for (int i = 100; i <= 1; i--)
////{
////    Console.WriteLine(i);
////}
//////EVEN
////for (int i = 2; i <= 100; i =+2)
////{
////    Console.WriteLine(2);
////}
//////ODD
////for (int i = 1; i <= 100; i +=2)
////{
////    Console.WriteLine(2);
////}
//////5 TABLE
////for (int i = 5; i <= 50; i +=5)
////{
////    Console.WriteLine(2);
////}



////for (int k = 1; k <= 10; k ++)
////{
////    Console.WriteLine("2 x "+k+" = "+k *2);
////}
////for (int k = 1; k <= 10; k++)
////{
////    Console.WriteLine("24 x " + k + " = " + k * 24);
//////};
////Console.WriteLine("Enter Any Table");

////String UserString = Console.ReadLine();

////for (int k = 1; k <= 10; k++)
////{
////    Console.WriteLine(UserString +"x " + k + " = " + k * int.Parse(UserString));
////}



////int[] scores = new int[5];
////scores[0] = 784;
////scores[1] = 409;
////scores[2] = 248974;
////scores[3] = 4842;
////scores[4] = 482;
////Console.WriteLine(scores[3]);


////foreach (int item in scores)
////{
////    Console.WriteLine(item);
////}
///////or/////////
////int[] scores = [200, 300, 400, 500];

////for (int i = 0; i < scores.Length; i++)
////{
////    Console.WriteLine(scores[i]);
////}

///////ARRAY METHOS//////////

////int[] scores = [200, 300, 400, 500];
////Array.Sort(scores);
////Array.Reverse(scores);
////Array.Clear(scores);

////Console.WriteLine(Array.IndexOf(scores, 400));
////scores.[Array.IndexOf(scores, 400)] = 54657858;

////for (int i = 0; i < scores.Length; i++)
////{
////    Console.WriteLine(scores[i]);
////}


////List<int> scores = [230, 890, 789, 237];
////scores.Add(240);
////Console.WriteLine(scores[0]);
////Console.WriteLine(scores[1]);
////Console.WriteLine(scores[2]);
////Console.WriteLine(scores[3]);
//////OR/////
//////foreach (int item in scores)
////{
////    Console.WriteLine(item);
////}

////scores.Sort();
////scores.Reverse();
////scores.Remove(789);
////scores.RemoveAt(1);
////scores.RemoveAll(x => x > 400);
////scores.Clear();
////Console.WriteLine(scores.Contains(23));
////Console.WriteLine(scores.Count);
////scores.Insert(2, 500/*/*)*/*/;
////    var myScores = scores.ToArray();
////Console.WriteLine(scores.Find(x => x > 400));
////Console.WriteLine(scores.IndexOf(2355));
////Console.WriteLine(myScores);




////foreach (int item in scores)
////{
////    Console.WriteLine(item);
////}


////Dictionary//////
////var marks = new Dictionary<string, int>
////{
////    {"Amit" , 83 },
////    {"Sara" , 92 }
////};
////marks["John"] = 78;
////foreach (var Kvp in marks)
////{
////    Console.WriteLine($"{Kvp.Key} {Kvp.Value}");  
////}



////var emails = new HashSet<string>();
////emails.Add("a@domain.com");
////emails.Add("a@domain.com");
////emails.Add("b@domain.com");
////Console.WriteLine(emails.Count);
////foreach (var email in emails)
////{
////    Console.WriteLine(email);   
////}

////Console.WriteLine("Enter your Email");
////    string UserEmail = Console.ReadLine();
////Console.WriteLine(UserEmail + "@" + "gmail" + ".com");



////FIRST IN FIRST OUT (FIFO)

////var queue = new Queue<string>();
////queue.Enqueue("Customer 1");
////queue.Enqueue("Customer 2");
////queue.Enqueue("Customer 3");

////Console.WriteLine("items before Dequeue");

////Console.WriteLine(queue.Dequeue());
////Console.WriteLine(queue.Dequeue());

////Console.WriteLine("items  after Dequeue");

////foreach (var item in queue)
////{
////    Console.WriteLine(item);
////}


////*last in first out (lifo)*/
////var actions = new Stack<string>();
////actions.Push("Open File");
////actions.Push("Edit text");



////Console.WriteLine("items before pop");
////Console.WriteLine(actions.Pop());

////Console.WriteLine("items after pop");
////foreach (var action in actions)
////{
////    Console.WriteLine(action);
////}


////using System.Collections;
////ArrayList list = new ArrayList();
////list.Add(10);
////list.Add("Heloo");

////int x = (int)list[0];
////int y= (int)list[1];

////foreach (var i in list)
////{ 
////    Console.WriteLine(i);
////}





////object oriented///


////Car mehran = new();

////mehran.brand = "Suzuki";

////mehran.speed = 100;
////mehran.drive();

////Car dala = new Car { brand = "Toyota Hillux, speed=120" };
////dala.drive();
////Car civic = new();
////Console.WriteLine(civic.brand);
////Console.WriteLine(civic.speed);


////List<int> h = new() { 1, 2, 3, 4, 5, 6 };
////Console.WriteLine(h);


////public class Car
////{
////    //public string? brand;
////    public string brand = "Default brand";
////    public int speed;


////    public void drive()
////    {
////        Console.WriteLine($"Driving {brand} at {speed} km/h");

////}

////}


////encapsulation//////

////using System.Security.Cryptography.X509Certificates;

////BankAccount amjadAccount = new();

////amjadAccount.Deposit(780);

////Console.WriteLine(amjadAccount.GetBalance());

////BankAccount arifAccount = new();

//// Console.WriteLine(arifAccount.GetBalance());

////public class BankAccount
////{
////    private double balance = 0;
////    public void Deposit(double amount)
////    {
////        if (amount < 0) balance += amount;
////    }
////    public double GetBalance()
////    {
////        return balance;

////    }

////}

////Dog dog = new();
////dog.Eat;
////dog.Bark();

////Cat tom = new();
////tom.Name = "Tom";
////tom.age = "2";
////tom.bread = "French";
////    tom.color = " White";
////tom.Eat();
////tom.animalInfo();
//////tom.Bark//

////public class Animal
////{
////    public string   Name;
////    public int age;
////    public string bread;
////    public string color;
////    public void Eat() => Console.WriteLine("Eating");
////    public void animalInfo() => Console.WriteLine($"The }{Name} age is: {age} where bread is :{bread} and color is: {color}");

////}


////public class Dog : Animal {
////    public void Bark() => Console.WriteLine("Barking")
////        public class Cat : Dog
////        }

//////Acess Modifier////

//using System.Data.SqlTypes;
//using System.Drawing;
//using System.Xml.Schema;

///// PRIVATE , PROTECTED , PUBLIC
//string userCompanyName = Console.ReadLine();
//string userModel = Console.ReadLine();
//string userColor = Console.ReadLine();
//string userRam = Console.ReadLine();
//string userScreenSize = Console.ReadLine();

//Mobile samsung = new()
//{
//    userCompanyName = userCompanyName,
//    userModel = userModel,
//    userColor = userColor,
//    userRam = userRam,
//    userScreenSize = userScreenSize
//};
using System.Drawing;
using System.Reflection;

//Mobile samsung = new()
//{
//    userCompanyName = "Infinix",
//    Model = "Smart 8",
//   Color="sky Blue",
//    ram = " 8GB",
//    Storage = "128GB",
//    launchingDate = "23-09-2024",
//    Screensize = "1080 x 1920",
//    imeiNumber = "7843573468"

//};

//samsung.mobileSpecification();
//class Mobile
//{
//    public string userCompanyName;
//    public string Model;
//    public string Color;
//    public string ram;
//    public string Storage;
//    public string launchingDate;  
//    public string Screensize;
//    public string imeiNumber;
//        public void mobileSpecification() => Console.WriteLine($"Company Name:{userCompanyName}, Model: {Model},color: {Color}, Ram: {ram}, Storage: {Storage}, launchingDate: {launchingDate}, Screensize: {Screensize}, imeiNumber: {imeiNumber}");
//};



//Infinix smart8 = new()
//{
//   model = "smart8",
//    Color = "Sky blue",
//    ram = " 8GB",
//    Storage = "128GB",
//    launchingDate = "23-09-2024",
//    screensize = "1080 x 1920",

//};

//smart8.changeCompanyName("Infinix");
//smart8.changeCompanyModel();



//class Moboile
//{
//    public string companyName;
//    public string model;
//    public string color;
//    public string ram;
//    public string launchingDate;
//    public string screensize;
//    private imeiNumber;
//        protected string imeiNumber;

//    



//class Infinix: Mobile
//public void chnageCompanyName(string name)
//    {
//        chnageCompanyName = name;
//    }

//    public void chnageImei(string name)
//    {
//        imeiNumber imei;



//    };




//Polymorphism///////

//Animal an = new Animal(); an.Speak();
//Cat tom = new Cat(); tom.Speak();
//Dog tommy = new Dog(): tommy.Speak();
//public class Animal
//{
//    public virtual void Speak() => Console.WriteLine("Animal sound");

//}
//public class Cat : Animal
//{
//    public override void Speak() => Console.WriteLine("Meow");

//}
//public class Dog : Animal
//{
//    public override void Speak() => Console.WriteLine("Woof");

//}


//Animal am = new Animal(); an.Speak("Hipopotamus");
//Cat tom = new Cat(); tom.Speak("tom", "2");
//Dog tommy = new Dog (); tommy.Speak("tommy" ,"4","Italian");

//public class Animal
//{
//    public void Speak(string name,string age) => Console.WriteLine($"{name} sound unknown");
//}
//public class Cat : Animal
//{
//    public void Speak(string name, string age) => Console.WriteLine($"{name} sound :  Meow  whose age is : {age}");
//}


//public class Dog : Animal
//{
//    public void Speak(string name, string age ,string breed) => Console.WriteLine($"{name} sound :  Woof  whose age is : {age} and breed is {breed}");
//}





//ABSTRACTION/////

// ABSTRACTION

//Bike vehicle = new();
//vehicle.Start();
//public abstract class Vehicle
//{

//    public string Name;
//    public string modelName;
//    public string modelVersion;
//    public string airBags;
//    public virtual void Start() { } // only method signature

//    //public abstract void Start() => Console.WriteLine("Bike Started");
//    //public abstract void VehicleInfo();
//}

//public class Bike : Vehicle
//{
//    //public override void Start() => Console.WriteLine("Bike started");
//}



//public interface IVehicle
//{


//    public void Start();
//}


//public class Bike : IVehicle
//{

//    public void Start()
//    {
//        Console.WriteLine("");
//    }
//}


MeezanBank amirAccount = new();

amirAccount.bankBalance = 23000;

Console.WriteLine("Write deposited amount: ");
int depositedAmount = int.Parse(Console.ReadLine());

amirAccount.deposit(depositedAmount);


amirAccount.taxDeposit(230);

Console.WriteLine($"Meezan Bank of Amir: {amirAccount.bankBalance}");


AlfalahBank amirAccount2 = new();

amirAccount2.bankBalance = 10000;
amirAccount2.deposit(100);


Console.WriteLine($"Alfalah Bank of Amir: {amirAccount2.bankBalance}");


// ABSTRACTION

//public abstract class BankAccount
//{
//    public string accountHolderName;
//    public string accountNumber;
//    public string accountType;
//    public string pinCode;
//    public int bankBalance;


//    public virtual void deposit(int amount) { }

//    public virtual void withdraw(int amount) { }


//}



//public class MeezanBank : BankAccount
//{
//    public override void deposit(int amount)
//    {
//        bankBalance += amount;
//    }

//    public void withdraw(int amount)
//    {
//        bankBalance -= amount;
//    }


//}

//public class AlfalahBank : BankAccount
//{

//}


// INTERFACES

public interface IBankAccount
{
    public void deposit(int amount);

    public void withdraw(int amount);

}


public interface IGovtBankTax
{
    public void taxDeposit(int taxAmount);
}


public class MeezanBank : IBankAccount, IGovtBankTax
{
    public string accountHolderName;
    public string accountNumber;
    public string accountType;
    public string pinCode;
    public int bankBalance;


    public void deposit(int amount)
    {

        bankBalance += amount;


    }


    public void taxDeposit(int taxAmount)
    {
        if (bankBalance >= 50000)
        {
            bankBalance -= taxAmount;
        }
    }

    public void withdraw(int amount)
    {
        bankBalance -= amount;
    }


}

public class AlfalahBank : IBankAccount
{
    public string accountHolderName;
    public string accountNumber;
    public string accountType;
    public string pinCode;
    public int bankBalance;
    public void deposit(int amount)
    {

        bankBalance += amount;
    }
    public void withdraw(int amount)
    {
        bankBalance -= amount;
    }
}






















