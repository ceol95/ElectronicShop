using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{

    [MetadataTypeAttribute(typeof(Employee))]
    public partial class Employee
    {
        internal sealed class EmployeeMetadata
        {

        }
    }
}

