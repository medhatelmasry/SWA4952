using System;

namespace SchooplLib.Models;

public class Student
{
    public int StudentId { get; set; }
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public String? School { get; set; }
    public String? Gender { get; set; }
    // public DateTime? DateOfBirth { get; set; }
    public DateOnly? DateOfBirth { get; set; }

}
