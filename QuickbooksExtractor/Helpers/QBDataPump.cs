using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickbooksExtractor.Models;
namespace QuickbooksExtractor.Helpers
{
    public static class QBDataPump
    {
        public static int PumpAllCustomers(string Company)
        {
            Console.WriteLine("Customers for Company " + Company);
            string sql = "SELECT * FROM Customer";
            List<QBCustomer> customers = new ODBCReaderToModel<QBCustomer>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Customer WHERE QBFile='" + Company + "'");
            }
            if (customers.Count > 0)
            {
                foreach (var QBcust in customers)
                {
                    if (QBcust.Name.Contains("00") || QBcust.Name.Contains("01") || QBcust.Name.Contains("02"))
                    {
                        Customer cust = QBcust.ConvertTo<Customer>();
                        Console.WriteLine("Customer " + cust.Name);

                        cust.QBFile = Company;
                        cust.Branch = cust.Name.Substring(0, 2);
                        new ModelToSQL<Customer>().WriteInsertSQL("Customer", cust, "CustomerID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return customers.Count;
        }

        public static int PumpAllEmployees(string Company)
        {
            Console.WriteLine("Employees for Company " + Company);
            string sql = "SELECT * FROM Employee";
            List<QBEmployee> employees = new ODBCReaderToModel<QBEmployee>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Employee WHERE QBFile='" + Company + "'");
            }
            if (employees.Count > 0)
            {
                foreach (var QBemp in employees)
                {
                    if (QBemp.PayrollInfoClassRefFullName != null && (QBemp.PayrollInfoClassRefFullName.Contains("00") || QBemp.PayrollInfoClassRefFullName.Contains("01") || QBemp.PayrollInfoClassRefFullName.Contains("02")))
                    {
                        Employee emp = QBemp.ConvertTo<Employee>(true,"Employee");
                        Console.WriteLine("Employee " + emp.LastName + "," + emp.FirstName);
                        emp.Branch = emp.PayrollInfoClassRefFullName.Substring(0, 2);

                        emp.QBFile = Company;
                        new ModelToSQL<Employee>().WriteInsertSQL("Employee", emp, "EmployeeID", CommonProcs.WCompanyConnStr,true);
                    }
                    else
                    {
                        Employee emp = QBemp.ConvertTo<Employee>(true, "Employee");
                        Console.WriteLine("Employee " + emp.LastName + "," + emp.FirstName);
                        emp.Branch = "00";

                        emp.QBFile = Company;
                        new ModelToSQL<Employee>().WriteInsertSQL("Employee", emp, "EmployeeID", CommonProcs.WCompanyConnStr);
                    }

                }
            }
            return employees.Count;
        }

        public static int PumpAllPayrollItems(string Company)
        {
            Console.WriteLine("PayrollItemWage for Company " + Company);
            string sql = "SELECT * FROM PayrollItemWage";
            List<QBPayrollItem> payItems = new ODBCReaderToModel<QBPayrollItem>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM PayrollItem WHERE QBFile='" + Company + "'");
            }
            if (payItems.Count > 0)
            {
                foreach (var QBpayItem in payItems)
                {
                    if (QBpayItem.Name.Contains("00") || QBpayItem.Name.Contains("01") || QBpayItem.Name.Contains("02"))
                    {
                        PayrollItem payItem = QBpayItem.ConvertTo<PayrollItem>();
                        Console.WriteLine("PayrollItem " + payItem.Name);
                        payItem.QBFile = Company;
                        payItem.Branch = payItem.Name.Substring(0, 2);

                        new ModelToSQL<PayrollItem>().WriteInsertSQL("PayrollItem", payItem, "payItemID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return payItems.Count;
        }

        public static int PumpAllClass(string Company)
        {
            Console.WriteLine("Classes for Company " + Company);
            string sql = "SELECT * FROM Class";
            List<QBClass> clsItems = new ODBCReaderToModel<QBClass>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Clss WHERE QBFile='" + Company + "'");
            }
            if (clsItems.Count > 0)
            {
                foreach (var QBclass in clsItems)
                {
                    if (QBclass.Name.Contains("00") || QBclass.Name.Contains("01") || QBclass.Name.Contains("02"))
                    {
                        Clss clss = QBclass.ConvertTo<Clss>();
                        Console.WriteLine("Class " + clss.Name);
                        clss.QBFile = Company;
                        clss.Branch = clss.Name.Substring(0, 2);
                        new ModelToSQL<Clss>().WriteInsertSQL("Clss", clss, "ClassID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return clsItems.Count;
        }

        public static int PumpAllVendors(string Company)
        {
            Console.WriteLine("Vendors for Company " + Company);
            string sql = "SELECT * FROM Vendor";
            List<QBVendor> vendors = new ODBCReaderToModel<QBVendor>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Vendor WHERE QBFile='" + Company + "'");
            }
            if (vendors.Count > 0)
            {
                foreach (var QBvend in vendors)
                {
                        Vendor vend = QBvend.ConvertTo<Vendor>(true, "Vendor");
                        Console.WriteLine("Vendor " + vend.Name);
                        vend.QBFile = Company;
                        new ModelToSQL<Vendor>().WriteInsertSQL("Vendor", vend, "VendorID", CommonProcs.WCompanyConnStr, true);

                }
            }
            return vendors.Count;
        }
    }
}
