using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.DAL.Models
{
    internal class Department
    {
        public int Id { get; set; }

        //[Required(ErrorMessage ="Sorry, Code is required")] // it is not Correct to make model work with view Model (PL) Direct
        public string Code { get; set; }

        //[Required] // Default Name is Required, if you not change it
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
