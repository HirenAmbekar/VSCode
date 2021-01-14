using System;
public class Student
{
	private string name;
	private int id;

	public string Name
	{
		get
		{return name;}
		set
		{name = value;}
	}
	public int Id
	{
		get 
		{ return id; }
		set 
		{ id = value; }
	}
}

class Test
{
	public static void Main (string[] args)
	{
		//creating object of students
		Student s = new Student();
		s.Name = "Sujay";
		s.Id = 10;
		Console.WriteLine("Name: " + s.Name + "ID:"+s.Id);
		Console.ReadLine();
	}
}
