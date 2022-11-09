namespace homework;
public class Person
{
    public string  Name { get; set; }
    public string  Address { get; set; }
    
    public Person(string name, string address)
    {
        Name=name;
        Address=address;
    }
    public string getName()
    {
        return Name;
    }
    public string getAddress()
    {
        return Address;
    }
    public void setAddress(string address)
    {
       Address = address;
    }
   public override string ToString()
   {
    return $"{Name} , {Address}";
   }

}