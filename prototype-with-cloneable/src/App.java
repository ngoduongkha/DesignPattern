import java.text.SimpleDateFormat;

public class App {
    public static void main(String[] args) throws Exception {
       
        Person p1 = new Person();
        p1.Age = 42;
        p1.BirthDate = new SimpleDateFormat("dd/MM/yyyy").parse("31/12/1999"); 
        p1.Name = "Jack Daniels";
        p1.IdInfo = new IdInfo(666);

        // Perform a shallow copy of p1 and assign it to p2.
        Person p2 = (Person) p1.ShallowCopy();
        // Make a deep copy of p1 and assign it to p3.
        Person p3 = p1.DeepCopy();

        // Display values of p1, p2 and p3.
        System.out.println("Original values of p1, p2, p3:");
        System.out.println("   p1 instance values: ");
        DisplayValues(p1);
        System.out.println("   p2 instance values:");
        DisplayValues(p2);
        System.out.println("   p3 instance values:");
        DisplayValues(p3);

        // Change the value of p1 properties and display the values of p1,
        // p2 and p3.
        p1.Age = 32;
        p1.BirthDate = new SimpleDateFormat("dd/MM/yyyy").parse("20/10/2001"); 
        p1.Name = "Frank";
        p1.IdInfo.IdNumber = 7878;
        System.out.println("\nValues of p1, p2 and p3 after changes to p1:");
        System.out.println("   p1 instance values: ");
        DisplayValues(p1);
        System.out.println("   p2 instance values (reference values have changed):");
        DisplayValues(p2);
        System.out.println("   p3 instance values (everything was kept the same):");
        DisplayValues(p3);
    }

    public static void DisplayValues(Person p)
    {   
        SimpleDateFormat formatter = new SimpleDateFormat("MM/dd/yyyy");  
        System.out.print("      Id: "); 
        System.out.print(p.id);
        System.out.print("      Name: "); 
        System.out.print(p.Name);
        System.out.print("      Age: "); 
        System.out.print(p.Age); 
        System.out.print("      BirthDay: "); 
        System.out.print(formatter.format(p.BirthDate));
        System.out.print("      Id: "); 
        System.out.println( p.IdInfo.IdNumber);
    }
}

