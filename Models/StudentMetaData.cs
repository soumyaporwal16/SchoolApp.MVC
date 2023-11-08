using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApp.MVC.Data;

public class StudentMetaData{

    [Display(Name ="First Name")]
     public string FirstName { get; set; } = null!;


    [Display(Name ="Last Name")]

    public string LastName { get; set; } = null!;

    [Display(Name ="Date Of Birth")]

    public DateTime? DateOfBirth { get; set; }

}

[ModelMetadataType(typeof(StudentMetaData))]
public partial class Student{

}