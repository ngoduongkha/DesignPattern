import java.util.Date;

public class Person  implements Cloneable
    {   
        public final int id;
        public int Age;
        public Date BirthDate;
        public String Name;
        public IdInfo IdInfo;
        
        public Person() {
            id = 1;
        }
        
        public Person(Person person) {
            this.id = 2;
            this.Age = person.Age;
            this.BirthDate = person.BirthDate;
            this.Name = person.Name;
            this.IdInfo = person.IdInfo;
        }

        public Person ShallowCopy() throws CloneNotSupportedException
        {
            return (Person) super.clone();
        }

        public Person DeepCopy() throws CloneNotSupportedException
        {
            Person result = (Person) super.clone();
            result.IdInfo = new IdInfo(this.IdInfo.IdNumber);
            return result;
        }
    }