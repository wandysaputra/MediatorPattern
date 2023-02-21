namespace StructuralExample.Alternative;

public class ColleagueA : ColleagueV2
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague1 receives notification message: {message}");
    }
}