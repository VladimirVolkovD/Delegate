













































public class Hospital
{
    public string Name { get; set; }
    public List<Person> persons;

    public Hospital(string name, List<Person> persons)
    {
        Name = name;
        this.persons = persons;
    }
}
