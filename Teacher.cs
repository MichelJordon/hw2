namespace homework;
public class Teacher : Person
{
    private int myCourses = 0;
    private List<string> courses;
    private string course;
    public Teacher(string name, string address) : base( name, address)
    {
        courses = new List<string>();
    }
    public bool AddCourse(string course)
    {
        int used = 0;
        foreach (var item in courses)
        {
            if (item != course || courses.Count()==0) 
            {
                 used ++;
                 courses.Add(course);
            }
        }
        if (used == false)
        {
            return true;
        }
        return false;

    }
    public bool removeCourse(string course)
    {
        bool used = false;
        foreach (var item in courses)
        {
            if ( item == course ){

                courses.Remove(item);
                used = true;
            }
        }
        if ( used == false )
        {
            return used;
        }
        return true;
    }
    public override string ToString()
    {
        return Name + " " +Address;
    }
    
}