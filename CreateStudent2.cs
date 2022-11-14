using System;
using static System.Console;
class CreateStudents2
{
	static void Main()
	{
		Student first = new Student();
		Student second = new Student();
		Student third = new Student(456, "Marco", 2.4);
		Student fourth = new Student();
		first.IdNumber = 123;
		first.LastName = "Anderson";
		first.GradePointAverage = 3.5;
		second.IdNumber = 789;
		second.LastName = "Daniels";
		second.GradePointAverage = 4.1;
		Display(first);
		Display(second);
		Display(third);
		Display(fourth);
	}
	
	static void Display(Student stu)
	{
		WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
	}
}




class Student
{
	private int idNumber;
	private string lastName;
	private double gradePointAverage;
	public const double HIGHEST_GPA = 4.0;
	public const double LOWEST_GPA = 0.0;
	public int IdNumber
	{
		get
		{
			return idNumber;
		}
		set
		{
			idNumber = value;
		}
	}
	public string LastName
	{
		get
		{
			return lastName;
		}
		set
		{
			lastName = value;
		}
	}
	public double GradePointAverage
	{
		get
		{
			return gradePointAverage;
		}
		set
		{
			if(value >= LOWEST_GPA && value <= HIGHEST_GPA)
				gradePointAverage = value;
			else
				gradePointAverage = LOWEST_GPA;
		}
	}	

	public Student(int id, string name, double gpa)
	{
		IdNumber = id;
		LastName = name;
		GradePointAverage = gpa;
	}

	public Student() : this(0, "XXX", 0.0)
	{

	}
}