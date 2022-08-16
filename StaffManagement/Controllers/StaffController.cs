using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Controllers
{
    [Route("/[controller]s")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        static List<Staff> StaffList = new List<Staff>() {new Staff
        (){
             id = 1,
             name = "Deny",
             lastname = "Sellen",
             dateOfBirth = new DateTime(1989,01,01),
             email = "deny@gmail.com",
             phoneNumber = "555443366",
             salary = 4450

        }};
        

        [HttpGet]
        public List<Staff> GetStaffs()
        {
            var staffList = StaffList.OrderBy(x => x.id).ToList<Staff>();
            return staffList;
        }

        [HttpGet("{Id}")]
        public Staff GetStaffsById([FromQuery] int id)
        {
            var staff = StaffList.SingleOrDefault(x => x.id == id);
            return staff;
        }

        [HttpPost]
        public IActionResult AddStaff([FromBody]Staff newStaff)
        {
            var staff = StaffList.SingleOrDefault(x => x.name == newStaff.name);

            if (staff is not null)
            {
                return BadRequest();
            }

            StaffList.Add(newStaff);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var staff = StaffList.SingleOrDefault(x => x.id == id);
            if(staff is null)
            {
                return BadRequest();
            }
            StaffList.Remove(staff);
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult UpdateStaff(int id,[FromQuery] Staff updatedStaff)
        {
            var staff = StaffList.Single(x => x.id == updatedStaff.id);
            if(updatedStaff is null)
            {
                return BadRequest();
            }
           staff.name = updatedStaff.name != default ? updatedStaff.name:staff.name;
           staff.lastname = updatedStaff.lastname != default ? updatedStaff.lastname : staff.lastname;
           staff.email = updatedStaff.email != default ? updatedStaff.email : staff.email;
           staff.dateOfBirth = updatedStaff.dateOfBirth != default ? updatedStaff.dateOfBirth : staff.dateOfBirth;
           staff.phoneNumber = updatedStaff.phoneNumber != default ? updatedStaff.phoneNumber : staff.phoneNumber;
           staff.salary = updatedStaff.salary != default ? updatedStaff.salary : staff.salary;
           return Ok();
        }
    }
}
