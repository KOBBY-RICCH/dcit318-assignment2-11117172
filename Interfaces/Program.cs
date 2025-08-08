using System;

// Define the interface
interface IMovable
{
    void Move(); 
}

// Car implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Interface Implementation: IMovable ===");

        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();

        myCar.Move();      
        myBicycle.Move();  
    }
}
