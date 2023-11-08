using System;
using System.Collections.Generic;

namespace SchoolApp.MVC.Data;

public partial class Class
{
    public int Id { get; set; }

    public int? LecturerId { get; set; }

    public int? CoursesId { get; set; }

    public TimeSpan? Time { get; set; }

    public virtual Course? Courses { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual Lecture? Lecturer { get; set; }
}
