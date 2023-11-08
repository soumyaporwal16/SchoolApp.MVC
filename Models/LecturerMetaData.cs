using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApp.MVC.Data;

public class LecturerMetaData{

    [Display(Name ="First Name")]
     public string FirstName { get; set; } = null!;


    [Display(Name ="Last Name")]

    public string LastName { get; set; } = null!;

}

[ModelMetadataType(typeof(LecturerMetaData))]
public partial class Lecture{

}