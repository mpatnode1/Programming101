using System;
using System.Xml.Schema;
using static System.Console;

namespace StoreFront
{
    public class Item
{
    public float Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    

    public Item(float price, string name, string description)
    {
        this.Price = price;
        this.Name = name;
        this.Description = description;
    }

    public string FormatForList()
    {
        return $"Name: {this.Name}, Price: {this.Price}";
    }

    public string FormatForDetails() {
        return $"{this.Description}";
    }

    public void Print(string format)
    {
        if(format == "display")
        {
            Console.WriteLine(this.FormatForDetails());
        }
        else {
            Console.WriteLine(this.FormatForList());
        }
    }
}

public class Store
{
    public float Total = 0;
    private Item ItemOne = new Item(7.99f, "Map Mug", "One side has a map on it, the other side says 'No place like home'");
    private Item ItemTwo = new Item(7.99f, "Mondays Mug", "'I hate Mondays' is printed on either side. ");
    private Item ItemThree = new Item(9.99f, "Soup Mug", "Mug intended for soup, so it's bigger. Spoon included!");
    private Item ItemFour = new Item(2.99f, "Souvenir Keychain", "It is a tiny plastic mug, the size of your thumb, with a keyring.");
    private Item ItemFive = new Item(5.99f, "Mug Cake", "Cake in a mug.");

    public void DisplayItems()
    {
        Console.WriteLine("Item 1");
        ItemOne.Print("list");
        ItemOne.Print("display");

        Console.WriteLine("");
        Console.WriteLine("Item 2:");
        ItemTwo.Print("list");
        ItemTwo.Print("display");

        Console.WriteLine("");
        Console.WriteLine("Item 3:");
        ItemThree.Print("list");
        ItemThree.Print("display");

        Console.WriteLine("");
        Console.WriteLine("Item 4:");
        ItemFour.Print("list");
        ItemFour.Print("display");

        Console.WriteLine("");
        Console.WriteLine("Item 5");
        ItemFive.Print("list");
        ItemFive.Print("display");

        Order();
    }

     public void More(){
            Console.WriteLine($"That brings your total to ${Total:0.00}. Did you want anything else?");
            Console.WriteLine("Type 1 for Yes. 2 for No.");
           
            
    }
    public void Order()
    {
        float x = 0;
        Console.WriteLine("");
        Console.WriteLine("So, what do you want to order? Type in the number of the item.");
        
        bool StillOrdering = true;
        while(StillOrdering){
            var OrderedFood = Console.ReadKey(true).KeyChar;
            switch(OrderedFood)
            {
                case '1':
                    Console.WriteLine("");
                    Console.WriteLine("Alright. How many would you like? Type in the number.");
                        string AmountInput = Console.ReadLine();
                        try{
                             x = float.Parse(AmountInput);
                             Total += ItemOne.Price*x;
                        }
                        catch {
                            Console.WriteLine("What? One more time?");
                        }
                    
                        More();
                        var MoreChoice = Console.ReadKey(true).KeyChar;
                        if (MoreChoice == '2'){
                        StillOrdering = false;
                        }
                        else{
                            Console.WriteLine("");
                            Console.WriteLine("Alright, what'll it be?");
                        }
                break;
                case '2':
                    Console.WriteLine("");
                    Console.WriteLine("Alright. How many would you like? Type in the number.");
                        AmountInput = Console.ReadLine();
                        try{
                             x = float.Parse(AmountInput);
                             Total += ItemOne.Price*x;
                        }
                        catch {
                            Console.WriteLine("What? One more time?");
                        }

                    More();
                        MoreChoice = Console.ReadKey(true).KeyChar;
                        if (MoreChoice == '2'){
                        StillOrdering = false;
                        }
                        else{
                            Console.WriteLine("");
                            Console.WriteLine("Alright, what'll it be?");
                        }
                break;
                case '3':
                    Console.WriteLine("");
                    Console.WriteLine("Alright. How many would you like? Type in the number.");
                        AmountInput = Console.ReadLine();
                        try{
                             x = float.Parse(AmountInput);
                             Total += ItemOne.Price*x;
                        }
                        catch {
                            Console.WriteLine("What? One more time?");
                        }
                    More();
                        MoreChoice = Console.ReadKey(true).KeyChar;
                        if (MoreChoice == '2'){
                        StillOrdering = false;
                        }
                        else{
                            Console.WriteLine("");
                            Console.WriteLine("Alright, what'll it be?");
                        }
                break;
                case '4':
                    Console.WriteLine("");
                    Console.WriteLine("Alright. How many would you like? Type in the number.");
                        AmountInput = Console.ReadLine();
                        try{
                             x = float.Parse(AmountInput);
                             Total += ItemOne.Price*x;
                        }
                        catch {
                            Console.WriteLine("What? One more time?");
                        }
                    More();
                        MoreChoice = Console.ReadKey(true).KeyChar;
                        if (MoreChoice == '2'){
                        StillOrdering = false;
                        }
                        else{
                            Console.WriteLine("");
                            Console.WriteLine("Alright, what'll it be?");
                        }
                break;
                case '5':
                    Console.WriteLine("");
                    Console.WriteLine("Alright. How many would you like? Type in the number.");
                        AmountInput = Console.ReadLine();
                        try{
                             x = float.Parse(AmountInput);
                             Total += ItemOne.Price*x;
                        }
                        catch {
                            Console.WriteLine("What? One more time?");
                        }

                    More();
                        MoreChoice = Console.ReadKey(true).KeyChar;
                        if (MoreChoice == '2'){
                        StillOrdering = false;
                        }
                        else{
                            Console.WriteLine("");
                            Console.WriteLine("Alright, what'll it be?");
                        }
                break;
            }
        }
        End();
    }

    public void End()
    {
        Console.WriteLine($"Your total is ${Total:0.00}.");
        Console.WriteLine("Have a nice day!");
    }

       
    }
}
/**/

