public abstract class TeamMember
{
    private ChatRoom chatRoom;
    public string Name { get; }

    protected TeamMember(string name)
    {
        Name = name;
    }

    internal void SetChatRoom(ChatRoom room)
    {
        this.chatRoom = room;
    }

    public void Send(string message)
    {
        this.chatRoom.Send(this.Name, message);
    }

    public void SendTo<T>(string message) where T : TeamMember
    {
        this.chatRoom.SendTo<T>(this.Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"from {from}: '{message}'");
    }

}