using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        /*
         * The template method pattern defines the skeleton
         * of an algorithm in a method, deferring some steps to
         * subclasses.  Template method lets subclasses redefine
         * certain steps of an algorithm without chaing the 
         * algorithm's structure.
         */
        var tea = new Tea();
        var coffee = new Coffee();

        Console.WriteLine("Making tea");
        tea.PrepareRecipe();

        Console.WriteLine("Making coffee");
        coffee.PrepareRecipe();
    }
}

public abstract class CaffeineBeverage
{
    
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    public abstract void Brew();
    public abstract void AddCondiments();
    public void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }
    public void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    public virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}

public class Tea : CaffeineBeverage
{
    public override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }

    public override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }
}

public class Coffee : CaffeineBeverage
{
    public override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    public override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    public override bool CustomerWantsCondiments()
    {
        YesNoResponse answer = GetUserYesNoResponse("Do you want milk and sugar? (Yes/No)");
        if (answer == YesNoResponse.Yes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private YesNoResponse GetUserYesNoResponse(string question)
    {
        Console.WriteLine(question);
        bool resultValid = false;
        string result = "";
        while (!resultValid)
        {
            result = Console.ReadLine();
            result = result.ToLower();
            if (result == "y" || result == "yes")
            {
                return YesNoResponse.Yes;
            }
            else if (result == "n" || result == "no")
            {
                return YesNoResponse.No;
            }
            else
            {
                Console.WriteLine("Invalid response, try again.");
            }
        }
        return YesNoResponse.No;
    }

    private enum YesNoResponse{
        Yes,
        No,
    }
}