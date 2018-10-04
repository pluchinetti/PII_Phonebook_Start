namespace Library
{
    public interface IMessageChannel
    {
        Message CreateMessage(Contact from, Contact to, string text);
        void Send(Message message);
    }
}