using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademicDatabaseSystem.DataRepository
{
    public class Validations
    {
        private static readonly string RgxName = @"^[a-zA-Z]+$";
        private static readonly string RgxPhone = @"^(010|011|012|015)\d{8}$";
        private static readonly string RgxNumber = @"^\d+$";
        private static readonly string RgxSalary = @"^\d+(\.\d{1,2})?$";
        private static readonly string RgxDate = @"^(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01])/\d{4}$";
        public static bool CheckName(string name)
        {
            return Regex.IsMatch(name, RgxName);
        }
        public static bool CheckNumber(string num)
        {
            return Regex.IsMatch(num, RgxNumber);
        }
        public static bool CheckPhone(string phone)
        {
            return Regex.IsMatch(phone, RgxPhone);
        }
        public static bool CheckSalary(string salary)
        {
            return Regex.IsMatch(salary, RgxSalary);
        }
        public static bool CheckDate(string date)
        {
            return Regex.IsMatch(date, RgxDate);
        }
    }
}
