using System;

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class HumanWorker : IWorkable, IEatable, ISleepable
{
    public void Work()
    {
        Console.WriteLine("Human is working.");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Human is sleeping.");
    }
}

public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HumanWorker human = new HumanWorker();
        human.Work();
        human.Eat();
        human.Sleep();
        
        RobotWorker robot = new RobotWorker();
        robot.Work();
    }
}