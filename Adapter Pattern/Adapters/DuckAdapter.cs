public class DuckAdapter : ITurkey
{
    private IDuck _duck;

    public DuckAdapter(IDuck duck)
    {
        _duck = duck;
    }
    public void Fly()
    {
        Random rand = new Random();
        if (rand.Next(1, 5) == 5)
            _duck.Fly();
    }

    public void Gobble()
    {
        _duck.Quack();
    }
}