using System;
using System.Collections.Generic;
using System.Text;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Disease { get; set; }
    public string Phone { get; set; }

    public Patient(int id, string name, int age, string disease, string phone)
    {
        Id = id;
        Name = name;
        Age = age;
        Disease = disease;
        Phone = phone;
    }
}