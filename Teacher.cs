namespace homework;
public class Teacher : Person
{ 
    public int  numCourses = 0 ;
    public string [] courses = {} ;
    private List<string> list;
    public Teacher( string name, string address) : base(name, address)
    {
        list= new List<string>();
    }
    public void addCourse(string courses)
    {
        list.Add(courses);
    }
    public void removeCourse(string courses)
    {
        foreach (var item in list)
        {
            if ( item == courses ){
                list.Remove(item);
                return;
            }
        }
    }
    public override string ToString()
    {
        return Name + " " +Address;
    }
    
}