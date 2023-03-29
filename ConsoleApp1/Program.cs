using static Programm;

public class EntryPoint
{
    public delegate Message MessageBuilder(string text);
    public delegate void EmailReceiver(EmailMessage message);
    public delegate void CalculateBonus(Employee employee);

    public delegate void Messages();
    public delegate int MathOperation(int r, int z);
    public delegate T MathOperation<T, K>(T r, K z);

    public static void Main()
    {
        //Co
        MessageBuilder builder = new MessageBuilder(WriteEmailMessage);
        Message message = builder("TMS");
        message.Print();

        //Contr
        EmailReceiver emailBox = ReceiveMessage;
        emailBox(new EmailMessage("EmailMessage box works with email"));

        List<Employee> employees = new List<Employee>()
        {
            new Employee(Position.Manager),
            new Employee(Position.Lead),
            new Employee(Position.ScrumMaster)
        };

        BonusHandler handler = new BonusHandler(GetBonusesByPosition);
        handler.CaCalculateBonuses(employees);

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.bonus);
        }

        Messages? nameDelegate1 = HelloWorld;
        nameDelegate1 += HelloWorld;


        if (nameDelegate1 is not null)
        {
            nameDelegate1();
        }

        nameDelegate1?.Invoke();

        Messages nameDelegate2 = new EntryPoint().HelloWorldWithoutStatic; ;

        Messages nameDelegate3 = nameDelegate1 - nameDelegate2;
        nameDelegate3();


        var programm = new EntryPoint();
        MathOperation mathDelegat1;
        mathDelegat1 = Add;

        MathOperation mathDelegat2 = new MathOperation(new EntryPoint().Multiply);

        MathOperation mathDelegat3;
        mathDelegat3 = Minus;

        MathOperation mathDelegat4 = mathDelegat1 + mathDelegat2;

        Console.WriteLine(mathDelegat4.Invoke(5, 11));

        MathOperation<int, decimal> math;
        math = Multiply;

        int magickNumber = 42;

        mathDelegat3 = delegate
        {
            return magickNumber;
        };

        var result = mathDelegat3(6, 6);

        Console.WriteLine(result);

        DoMagick(5, 6, delegate (int x, int y)
        {
            return x - y;
        });
    }


    static MathOperation SelectOPeration(string type)
    {
        if (type == "+")
        {
            return Add;
        }
        else
        {
            return Minus;
        }
    }

    static int DoMagick(int a, int b, Func<int, int, int> operation)
    {
        return operation(a, b);
    }

    public static int Multiply(int x, decimal y)
    {
        return (int)(x * y);
    }

    public void AddAndShow(ref int x, int y)
    {
        Console.WriteLine(x + y);
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Minus(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public static void HelloWorld()
    {
        Console.WriteLine("Hello World");
    }

    public void HelloWorldWithoutStatic()
    {
        Console.WriteLine("Hello World, I am not static");
    }

    public static EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);
    public static void ReceiveMessage(Message message) => message.Print();

    public static void GetBonusesByPosition(Employee employee)
    {
        switch (employee.position)
        {
            case Position.Manager:
                employee.bonus = 100;
                break;
            case Position.Lead:
                employee.bonus = 150;
                break;
            default:
                employee.bonus = 20;
                break;
        }

    }
}
