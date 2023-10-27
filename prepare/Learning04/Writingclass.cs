// Follow the same pattern as before by creating a new file for the WritingAssignment class.
using System;
// Create the class and set up the inheritance relationship.
public class WritingAssignment : Assignment
{
    // Add the member variables and set up the constructor as you did for the MathAssignment class.
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    // Add the GetWritingInformation() method.
    public string GetWritingInformation()
    {
        return _title;
    }
}
