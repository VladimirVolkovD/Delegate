
var bLackList = new List<Person>()
{
    new Person("Piotr", 18),
    new Person("Maksim", 25),
};

var person = new List<Person>()
{
    new Person("Piotr", 18),
    new Person("Maksim", 25),
    new Person("Tom", 7),
    new Person("Marry", 22),
    new Person("Andrei", 36),
};

List<Hospital> hospitals = new List<Hospital>()
{
    new Hospital("One", bLackList),
    new Hospital("two", person),
};


var selected = from hospital in hospitals
               from persons in hospital.persons
               where persons.Age > 24
               select persons;


foreach (var p in selected)
{
    Console.WriteLine(p.Name + "   " + p.Age);
}


int[] numbers = { 4, 2, 8, 5, 3, 8, 4, };

var orderedNUmber = from n in numbers
                    orderby n descending
                    select n;

var orderedNames = person.OrderBy(x => x.Name, new CustomStringComparer());


foreach (var p in orderedNames)
{
    Console.WriteLine(p.Name + "   " + p.Age);
}


int age = person.Max(p => p.Age);

string[] name1 = { "Vladimir", "Anna", "Bob", "Draculu" };
string[] name2 = { "Vladimir", "Kataryna", "Ilya", "Anna", "Bob", "Anna", "Anna", "Bob" };

int[] number = { 1, 4, 67, 4, 322, 45, 6, 54, };


var count = name1.Where(n => n.Length > 4);
Console.WriteLine(count.Count());

name1[2] = "Adzxczxczxczxc";

Console.WriteLine(count.Count());





string query = name1.Aggregate("My string: ", (first, next) => $"{first} {next}");
Console.WriteLine(query);


var except = name2.Except(name1);

var intersect = name2.Intersect(name1);

foreach (var p in except)
{
    Console.WriteLine(p);
}

Console.WriteLine("\n\nAnother query\n\n");

foreach (var i in intersect)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n\nAnother query\n\n");

foreach (var i in name2.Distinct())
{
    Console.WriteLine(i);
}

var union = name2.Union(name1);


Console.WriteLine("\n\nAnother query\n\n");

foreach (var i in union)
{
    Console.WriteLine(i);
}







string[] people = { "Piotr", "Maksim", "Tom", "Marry" };

var selecetedPeople = (from p in people
                       where p.StartsWith("M")
                       select p).Count();

var selecetedPeopleMethods = people.Where(p => p.StartsWith("T"));

Console.WriteLine(selecetedPeople);

var adult = person.Where(p => p.Age > 18);
var adultSelect = person.Select(p => p.Name);

foreach (var a in adult)
{
    Console.WriteLine($"name: {a.Name}, age: {a.Age}");
}


foreach (var a in adultSelect)
{
    Console.WriteLine($"name: {a}, age: {a}");
}

var query1 = hospitals.SelectMany(h => h.persons);

query1 = from h in hospitals
         from p in h.persons
         select p;


foreach (var n in query1)
{
    Console.WriteLine(n.Name);
}



var name = from p in person
           from b in bLackList
           let newName = p.Name + p.Age
           select new
           {
               FirsrtName = p.Name,
               LastName = b.Name,
           };

var t = person.Select(p => p.Name);

foreach (var n in name)
{
    Console.WriteLine(n);
}




selected = from hospital in hospitals
               from persons in hospital.persons
               where persons.Age > 24
               select persons;


foreach (var p in selected)
{
    Console.WriteLine(p.Name + "   " + p.Age);
}


orderedNUmber = from n in numbers
                orderby n descending
                select n;

orderedNames = person.OrderBy(x => x.Name, new CustomStringComparer());


foreach (var p in orderedNames)
{
    Console.WriteLine(p.Name + "   " + p.Age);
}



except = name2.Except(name1);

intersect = name2.Intersect(name1);

foreach (var p in except)
{
    Console.WriteLine(p);
}

Console.WriteLine("\n\nAnother query\n\n");

foreach (var i in intersect)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n\nAnother query\n\n");

foreach (var i in name2.Distinct())
{
    Console.WriteLine(i);
}

union = name2.Union(name1);


Console.WriteLine("\n\nAnother query\n\n");

foreach (var i in union)
{
    Console.WriteLine(i);
}