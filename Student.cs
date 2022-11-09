namespace homework;
public class Student : Person
{
    public int  numCourses = 0 ;
    private List<string>list;
    public string [] courses ={};
    public int  [] grades = {} ;
    public Student( string name, string address) : base(name, address)
    {
         list = new List<string>();
    }
    public override string ToString()
    {
        return Name + " " +Address;
    }

    public List<Object> GetList()
    {
        return list;
    }
    public void AddCourseGread(string courses, int grades, List<object> list)
    {
        numCourses++;
        list.Add(courses , grades);
    }
    public void printGrades()
    {
        foreach (var item in list)
        {
            System.Console.WriteLine(item.grades);
        }
    }

}