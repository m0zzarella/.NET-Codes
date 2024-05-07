using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationDemo;

public partial class EmpInfo
{
    [Required(ErrorMessage="Employee Number Cannot be Left Blank!")]
    [Display(Name = "Employee Number")]
    public int EmpNo { get; set; }

    [StringLength(20,MinimumLength =3,ErrorMessage = "Name must be between 3 and 20 characters")]
    [Display(Name = "Employee Name")]
    public string EmpName { get; set; } = null!;

    [Display(Name = "Employee Designation")]
    public string EmpDesigantion { get; set; } = null!;

    [Range(8000,25000,ErrorMessage ="Salary must be in the range of 8000 to 25000")]
    [Display(Name = "Salary")]
    public int EmpSalary { get; set; }

    [Display(Name = "Permanent Status")]
    public bool EmpIsPermenant { get; set; }

    [System.ComponentModel.DataAnnotations.EmailAddress]
    [Display(Name = "Employee Email")]
    public string EmpEmail { get; set; } = null!;
}
