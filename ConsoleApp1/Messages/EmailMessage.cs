﻿public class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine("EmailMessage: " + text);
}



