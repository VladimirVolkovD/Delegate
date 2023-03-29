public class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine("SmsMessage: " + text);
}



