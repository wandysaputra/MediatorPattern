namespace StructuralExample.Alternative;

public class ConcreteMediatorV2 : MediatorV2
{
    private List<ColleagueV2> colleagues = new();

    public void Register(ColleagueV2 colleague)
    {
        colleague.SetMediator(this);
        colleagues.Add(colleague);
    }

    public T CreateColleague<T>() where T : ColleagueV2, new()
    {
        var c = new T();
        c.SetMediator(this);
        this.colleagues.Add(c);
        return c;
    }

    public override void Send(string message, ColleagueV2 colleague)
    {
        foreach (var col in this.colleagues.Where(w => w != colleague))
        {
            col.HandleNotification(message);
        }
    }
}