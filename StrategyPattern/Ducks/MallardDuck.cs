public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new NormalQuack();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck!");
    }
}
