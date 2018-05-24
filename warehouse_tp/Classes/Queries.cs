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



        public static string ShowRemnants = "select product.name, product.price, product_in_warehouse.current_count, product_in_warehouse.warehouse_id, warehouse.warehouse_address " +
            "from tp.product, tp.product_in_warehouse, tp.warehouse " +
            "where product.id = product_in_warehouse.product_id;";

        public static string ShowAllContractors = "select tp.contractor.fio, tp.contractor.role from tp.contractor;";

        public static string ShowRemnantsForWarehouseIn = "select product.name, product_in_warehouse.current_count, product.price " +
            "from tp.product, tp.product_in_warehouse " +
            "where product.id = product_in_warehouse.product_id;";

        //public static string ShowProductsNames = "select product.name from tp.product;";

        public static string ProductNameCheck = "select true from tp.product where product.name = @name";

        public static string GetProductId = "select tp.product.id, tp.product_in_warehouse.current_count " +
            "from tp.product, tp.product_in_warehouse " +
            "where tp.product.name = @name and tp.product_in_warehouse.product_id = tp.product.id;";

       //public static string GetProductCount = "select tp.product_in_warehouse.current_count from tp.product_in_warehouse where tp.product_in_warehouse.product_id = @id;";

        public static string ProductCountAndPriceUpdate = "update tp.product_in_warehouse set current_count = @count where tp.product_in_warehouse.product_id = @id;" +
            "update tp.product set price = @price where tp.product.id = @id";

        public static string AddNewProduct = "insert into tp.product(name, price) values (@name, @price);" +
            "insert into tp.product_in_warehouse(product_id, warehouse_id, current_count) values(last_insert_id(), 1, @count);";

        public static string AddNewContractor = "insert into tp.contractor(fio, role) values (@fio, @role);";

        public static string GetContractorId = "select tp.contractor.id from tp.contractor where tp.contractor.fio = @fio;";

        public static string ContractorUpdate = "update tp.contractor set fio = @fio, role = @role where tp.contractor.id = @id;";

        public static string DeleteContractor = "delete from tp.contractor where id = @id";
    }
}