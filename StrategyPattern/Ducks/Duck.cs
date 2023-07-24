public abstract class Duck
{
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;
    public Duck() { }
    public abstract void Display();
    public void PerformFly()
    {
        FlyBehavior.Fly();
    }
    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
    public void SetFlyBehavior(IFlyBehavior behavior)
    {
        FlyBehavior = behavior;
    }
    public void SetQuackBehavior(IQuackBehavior behavior)
    {
        QuackBehavior = behavior;
    }
}
