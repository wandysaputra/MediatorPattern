namespace StructuralExample.Alternative;

public class ColleagueB : ColleagueV2
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague2 receives notification message: {message}");
    }
}