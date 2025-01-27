public class Student
{
    // composite
    Generate studentNumber = new Generate();
    
    // Create properties of Student
    public string FName { get; set; }
    //field
    private int _id;
    public string Grade { get; set; }
    // contructor
    public Student(string fname, int id, string grade)
    {
        this.FName = fname;
        this._id = id;
        this.Grade = grade;
    }

    // with two parmaeters 
    public Student(string fname, string grade)
    {
        this.FName = fname;
        this.Grade = grade;
        this._id = studentNumber.getNumber();
    }


    // property to student ID
    public int GetId
    {
        get { return _id; }
        set { _id = value; }
    }
    public string summary()
    {
        return ($"student information: \n {FName} {Grade} {_id} \n");
    }


}

// class to generate Student_Id 
public class Generate
{
    //empty constructor
    public Generate() { }

// method to generator studentID 
public int getNumber()
    {
        Random randum = new Random();
        return (randum.Next(1500, 9990));
    }
}