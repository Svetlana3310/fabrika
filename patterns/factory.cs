using System;

// Базовий клас для створюваних об'єктів
public abstract class Product
{
    public abstract void Display();
}

// Конкретна реалізація продукту
public class ConcreteProductA : Product
{
    public override void Display()
    {
        Console.WriteLine("Product A");
    }
}

// Інша конкретна реалізація продукту
public class ConcreteProductB : Product
{
    public override void Display()
    {
        Console.WriteLine("Product B");
    }
}

// Фабричний метод
public abstract class Creator
{
    public abstract Product FactoryMethod();
}

// Конкретний творець, який реалізує фабричний метод
public class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

// Інший конкретний творець
public class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

class Program
{
    static void Main()
    {
        // Клієнтський код використовує фабричний метод для створення об'єктів
        Creator creatorA = new ConcreteCreatorA();
        Product productA = creatorA.FactoryMethod();
        productA.Display();

        Creator creatorB = new ConcreteCreatorB();
        Product productB = creatorB.FactoryMethod();
        productB.Display();
    }
}