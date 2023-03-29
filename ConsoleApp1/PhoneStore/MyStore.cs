public partial class Programm
{
    public class MyStore
    {
        public void SellNewPhones(Phone phone)
        {
            Console.WriteLine($"{phone.id} can buy only for {phone.price + 100}");

        }
    }
}
