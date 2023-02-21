public class TeamChatRoom : ChatRoom
{
    private List<TeamMember> members = new();
    public override void Register(TeamMember member)
    {
        member.SetChatRoom(this);
        members.Add(member);
    }

    public override void Send(string from, string message)
    {
        this.members.ForEach(m => m.Receive(from, message));
    }

    public override void SendTo<T>(string from, string message)
    {
        foreach (var member in this.members.OfType<T>())
        {
            member.Receive(from, message);
        }
    }

    public void RegisterMembers(params TeamMember[] members)
    {
        foreach (var member in members)
        {
            this.Register(member);
        }
    }
}