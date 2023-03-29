public class Message
{
    public string text;
    public Message(string text) => this.text = text;

    public virtual void Print() => Console.WriteLine("Message: " + text);
}



