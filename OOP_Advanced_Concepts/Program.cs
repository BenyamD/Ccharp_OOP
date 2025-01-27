using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {

        Student studentInfo = new Student("Benyam", 1234, "Graduate");
        Console.WriteLine(studentInfo.summary());

        studentInfo.GetId = 123;
        Console.WriteLine(studentInfo.summary());

        // when I have two argument taken student Id is generated from Generate Class and injected in the constructor
        Student studentInfo1 = new Student("Benyam", "Graduate");
        Console.WriteLine(studentInfo1.summary());
        studentInfo1.GetId = 123;
        Console.WriteLine(studentInfo1.summary());

    }
}