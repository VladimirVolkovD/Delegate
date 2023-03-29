

using static EntryPoint;
using static Programm;

public class BonusHandler
{
    public CalculateBonus CalculateBonusForEmployee { get; set; }

    public BonusHandler(CalculateBonus calculateBonusForEmployee)
    {
        CalculateBonusForEmployee = calculateBonusForEmployee;
    }

    public void CaCalculateBonuses(IEnumerable<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            CalculateBonusForEmployee(employee);
        }
    }

}
