public partial class Programm
{
    public class IStore
    {

        public event Action<Phone> notify;

        public void GetNewPhones(IEnumerable<Phone> phones)
        {
            foreach (var phone in phones)
            {
                Console.WriteLine($"{phone.id} in IStore  can buy for  {phone.price} in IStore");
                notify(phone);
            }

        }
    }
}
