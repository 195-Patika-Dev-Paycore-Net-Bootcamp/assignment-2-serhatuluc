using StaffManagement.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.StaffOperations.GetStaffById
{
    public class GetStaffByIdQuery
    {
        private readonly List<Staff> _StaffList;
        public int StaffId;
        public GetStaffByIdQuery(List<Staff> StaffList)
        {
            _StaffList = StaffList;
        }

        public GetStaffByIdViewModel Handle()
        {
            //Handle metodu id ile eşleştirerek staff nesnesini bulur. ModelView kullanılmıştır.
            var Staff = _StaffList.SingleOrDefault(x=>x.id == StaffId);
            GetStaffByIdViewModel vm = new GetStaffByIdViewModel();
            vm.name = Staff.name;
            vm.lastname = Staff.lastname;
            vm.dateOfBirth = Staff.dateOfBirth.ToString();
            vm.email = Staff.email;
            vm.phoneNumber = Staff.phoneNumber;
            vm.salary = Staff.salary;
            return vm;
        }
    }

    public class GetStaffByIdViewModel
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string dateOfBirth { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public double salary { get; set; }
    }
}

