using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(DEPARTMENT department)
        {
            db.DEPARTMENT.InsertOnSubmit(department);


            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
