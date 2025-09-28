namespace OOP;

internal class Program
{
    static void Main(string[] args)
    {
       /* Person person1 = new Person("Yuta", 24, "Especial", null, new DateTime(2001, 3, 7));
        Person person2 = new Person("Toji", 24, "Atadura", null, new DateTime(1989, 12, 31));
        Person person3 = new Person("1989", 24, "Especial", null, new DateTime(1989, 12, 7));

        person1.Introduce();
        person2.Introduce();
        person3.Introduce();
       */

          Employee employee1 = new Employee("Satoru", 28, "Gojo", null, new DateTime(1996, 12, 7), "Teacher", 5000);
            employee1.Introduce();

    }
}

public class Person { 

public string Name { get; set; } = string.Empty;    

private int _age;

public int Age 
    { 
        get { return _age; } 
        set 
        { 
            if (value < 0) 
            {
                throw new ArgumentException("Age cannot be negative");
            }
            _age = value; 
        }
    }

public string Nickname { get; init; } = "no Nickname";

public int? Couple { get; set; } = null;

public readonly DateTime BirthDay = DateTime.Now;

public static int Population { get; private set; } = 0;

public Person() 
    {
        if (this.Name.Length == 0)
        this.Name = "no name";
        
        Population++;
    }

    public Person(string name, int age, string nickname, int? couple, DateTime birthDay): this()
    {
        Name = name;
        Age = age;
        Nickname = nickname;
        Couple = couple;
        BirthDay = birthDay;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}, I'm {Age} years old");
    }
}

public class Employee : Person { 
public string Position { get; set; } = "Unemployed";
public decimal Salary { get; set; } = 0;

public Employee(string name, int age, string nickname, int? couple, DateTime birthDay, string position, decimal salary) 
    : base(name, age, nickname, couple, birthDay)
    {
        Position = position;
        Salary = salary;
    }
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I work as a {Position} and earn {Salary:C}");
    }

}
