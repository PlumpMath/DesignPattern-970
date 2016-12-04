using System.Collections.Generic;

public class Memento
{
    int money;
    List<string> fruits = new List<string>();

    public int GetMoney()
    {
        return money;
    }

    internal Memento(int money)
    {
        this.money = money;
    }

    internal void AddFruit(string fruit)
    {
        fruits.Add(fruit);
    }

    internal List<string> GetFruit()
    {
        var list = new List<string>();
        list.AddRange(fruits);

        return list;
    }
}
