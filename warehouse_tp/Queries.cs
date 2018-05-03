using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_tp
{
    class Queries
    {
        public static string ShowAllEmployees = "select * from tp.employees;";

        public static string AddEmployee = "insert into tp.employees(login, password) values (@login, @password);";

        public static string DeleteEmployee = "delete from tp.employees where id = @ID;";

        public static string UpdateEmployee = "update tp.employees set login = @login, password = @password where ID = @ID;";

        public static string PasswordCheck = "select true from tp.employees where login = @login and password = @password;";
    }
}
