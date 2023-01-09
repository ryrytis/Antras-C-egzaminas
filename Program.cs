
using CsvHelper;
using Egzas1117;
using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Http.Headers;




var currentTime = DateTime.Now;

var menu = new List<Food>()
{
    new Food { Dish = "Fish", Price = 15},
    new Food { Dish = "Steak", Price = 19 },
    new Food { Dish = "Shrimps", Price = 17 }
};


using (var writer = new StreamWriter("C:\\Users\\rytissuk\\Desktop\\food.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(menu);
}

var drinks = new List<Drinks>()
{
    new Drinks { Drink = "Beer", Price = 4},
    new Drinks { Drink = "Wine", Price = 9 },
    new Drinks { Drink = "Tea", Price = 3 }
};


using (var writer = new StreamWriter("C:\\Users\\rytissuk\\Desktop\\drinks.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(drinks);
}

using (var reader = new StreamReader("C:\\Users\\rytissuk\\Desktop\\drinks.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var readDrinks = csv.GetRecords<Drinks>();
}
using (var reader = new StreamReader("C:\\Users\\rytissuk\\Desktop\\drinks.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var readFood = csv.GetRecords<Food>();
}

var staliukai = new List<Staliukai>()
{
    new Staliukai() { StaliukoStatusas = "Laisvas", StaliukoNr = 1, VietuSkPrieStaliuko = 2},
    new Staliukai() { StaliukoStatusas = "Laisvas", StaliukoNr = 2, VietuSkPrieStaliuko = 1},
    new Staliukai() { StaliukoStatusas = "Laisvas", StaliukoNr = 3, VietuSkPrieStaliuko = 1},
    new Staliukai() { StaliukoStatusas = "Laisvas", StaliukoNr = 4, VietuSkPrieStaliuko = 1}
};
Console.WriteLine("Chose action:\n1. New client\n2. Close order\n3. Generate cheque for client\n4. Generate cheque for restaurant\n5. Generate financial report");
if (Console.ReadLine() == "1")
{
    Console.WriteLine("Kiek žmonių pietaus?");
    int zmoniuSk = int.Parse(Console.ReadLine());


    for (int i = 0; i < zmoniuSk; i++)
    {
        Console.WriteLine($"Guest number {i + 1}");

        Console.WriteLine($"Pasirinkite, ką gersite");

        foreach (var drink in drinks)
        {
            Console.WriteLine($"{drink.Drink}");
        }
        string chosenDrink = Console.ReadLine();

        Console.WriteLine($"Pasirinkite, ką valgysite");

        foreach (var dish in menu)
        {
            Console.WriteLine($"{dish.Dish}");
        }
        string chosenDish = Console.ReadLine();

        //var tableInfo = new OrderInfo() { Foods = new List<Food>() { new Food { Dish = chosenDish, Price = Food.Price}, new Drinks { Drink = chosenDrink, Price = Drinks.Price } } };
    }

   
    var staliukas = staliukai
        .Where(str => str.StaliukoStatusas.Equals("Laisvas")
    && str.VietuSkPrieStaliuko >= zmoniuSk);

    foreach (var item in staliukas)
    {
        item.StaliukoStatusas = "Užimtas";
        Console.WriteLine($"{item.StaliukoStatusas}");
    }
}
/*Console.WriteLine($"{staliukai.Where(str => str.StaliukoStatusas.Equals("Laisvas") && str.VietuSkPrieStaliuko >= zmoniuSk)}");*/


//Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;




