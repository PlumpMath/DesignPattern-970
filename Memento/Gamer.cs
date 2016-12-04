using System;
using System.Collections.Generic;

public class Gamer
{
    private int money;
    private List<string> fruits = new List<string>();
    private Random random = new Random();
    private static string[] fruitsName =
    {
        "Apple",
        "Grape",
        "Banana",
        "Orange",
    };

    public Gamer(int money)
    {
        this.money = money;
    }

    public int GetMoney()
    {
        return money;
    }

    public void Bet()
    {
        int dice = random.Next(1, 7);
        if (dice == 1)
        {
            money += 100;
            Console.WriteLine("Money has increased");
            return;
        }

        if (dice == 2)
        {
            money /= 2;
            Console.WriteLine("Money is halved");
            return;
        }

        if (dice == 6)
        {
            string fruit = GetFruit();
            Console.WriteLine("Get " + fruit);
            fruits.Add(fruit);
            return;
        }

        Console.WriteLine("Nothing happened");
    }

    public Memento CreateMemento()
    {
        Memento memento = new Memento(money);
        fruits.ForEach(fruit =>
        {
            if (fruit.StartsWith("Delicious"))
                memento.AddFruit(fruit);
        });

        return memento;
    }

    public void RestoreMemento(Memento memento)
    {
        this.money = memento.GetMoney();
        this.fruits = memento.GetFruit();
    }

    private string GetFruit()
    {
        string prefix = "";
        if (random.Next(0, 2) == 1)
        {
            prefix = "Delicious";
        }

        return prefix + fruitsName[random.Next(fruitsName.Length)];
    }

    public override string ToString()
    {
        return "[money = " + money + ", fruits = " + fruits + "]";
    }
}
