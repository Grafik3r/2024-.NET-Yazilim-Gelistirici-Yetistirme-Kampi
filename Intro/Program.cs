// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;            //term - vade
double amount = 100000;   // amount - miktar

// variables --> camelCase  /  değişkenler camelCase yazılır

bool isAuthenticated = false;   // sisteme girmiş mi

Console.WriteLine(message1);

// condition - şart
if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton --> Sisteme giriş yap");
}


string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };      // loans -krediler  // db'den gelecek

//string[] loans2 = new string[6];
//loans2[0] = "Kredi1";

//string[] loans3 = new string[]
//    {
//        "Kredi1", "Kredi2"
//    };

// Yukarıdaki 3 şekilde de dizi tanımlayabilirz.

//     start     condition        increment    
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 vs...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "Java 17...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "PYTHON"; ;
course3.Description = "Python 3.12...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}




Console.WriteLine("Kod bitti");
