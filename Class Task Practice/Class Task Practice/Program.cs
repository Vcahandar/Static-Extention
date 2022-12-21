using Class_Task_Practice.Helpers;
using Class_Task_Practice.Models;

//Console.WriteLine(Car.Speed);

//Car car = new Car();

//Console.WriteLine(Car.Sum());


//Car car = new Car();
//Car car2 = new Car();
//Car car3= new Car();
//Car car4 = new Car();


//Book book1 = new Book(); 
//Book book2 = new Book();
//Book book3 = new Book();
//Book book4 = new Book();
//Book book5 = new Book();


//Console.WriteLine(Book.Count);


//int num = 100;
//Console.WriteLine(num.GetNums());

//string address = "Ehmedli";
//if (address.CheckDigitInString())
//{
//    Console.WriteLine("Reqem var");
//}
//else
//{
//    Console.WriteLine("Reqem yoxdur");
//}

string address = "Ehmedli44";
if (address.CheckString(@"\d"))
{
    Console.WriteLine("Reqem var");
}
else
{
    Console.WriteLine("Reqem yoxdur");
}


Console.WriteLine(address.CheckString(@"\d"));
Console.WriteLine(address.CheckString(@"A-Z"));




