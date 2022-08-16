using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Controllers
{
    public class Staff 
    {
        public int id { get; set; }

        [StringLength(maximumLength:250,MinimumLength =3,ErrorMessage ="Name length must be in range of 3-250")]
        [RegularExpression(@"^[a-z/A-Z]*", ErrorMessage = "Special characters and numbers are not allowed.")]
        public string name { get; set; }

        [StringLength(maximumLength: 250, MinimumLength = 3, ErrorMessage = "Lastname length must be in range of 3-250")]
        [RegularExpression(@"^[a-z/A-Z]*",ErrorMessage = "Special characters and numbers are not allowed.")]
        public string lastname { get; set; }

        [Range(typeof(DateTime), "1/2/2004", "3/4/2004",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }


        [RegularExpression("^[a-zA-Z/(.@)]*",ErrorMessage="Special characters are not allowed except '.'")]
        [EmailAddress]
        public string email { get; set; }


        [RegularExpression(@"^((\d{2})-(\d{3})-(\d{3})-(\d{2})-(\d{2}))$", ErrorMessage = "Error")]
        public string phoneNumber { get; set; }



        [Range(minimum:2000, maximum:9000, ErrorMessage = "please enter a value between 2000 - 9000")]
        public double salary { get; set; }

       
    }
}
