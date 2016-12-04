using System.Collections.Generic;

public abstract class NumberGenerator
{
    private List<Observer> observers = new List<Observer>();

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void DeleteObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        observers.ForEach(obsever => obsever.Update(this));
    }

    public abstract int GetNumber();
    public abstract void Execute();
}
