using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Extensions
{
    public static class ExtensionTestMethods
    {
        //Bu extension eğer değer 0 ise false döndürür. UpdateStaffCommandValidator ' de kullanıldı.
        public static bool IsZero(this double x)
        {
            if (x == 0)
            {
                return false;
            }
            return true;
        }

        //Bu extension eğer tarih bugün ise false döndürür. UpdateStaffCommandValidator ' de kullanıldı.
        public static bool IsNow(this DateTime y)
        {
            //Güvende kalmak için tarih aralığının son günü kullanılmıştır.
            if (y < new DateTime(2002,10,10))
            {
                return false;
            }
            return true;
        }
    }
}
