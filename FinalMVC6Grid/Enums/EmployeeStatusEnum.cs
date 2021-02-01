using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalMVC6Grid.Enums
{
    public enum EmployeeStatusEnum
    {
        [Display(AutoGenerateField = false, Name = "Inprogress", Description = "In progress")]
        Inprogress,
        [Display(AutoGenerateField = false, Name = "Closed", Description = "Closed")]
        Closed,
        [Display(AutoGenerateField = false, Name = "Open", Description = "Open")]
        Open
    }
}
