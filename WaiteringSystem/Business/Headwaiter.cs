using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.Business
{
    public class Headwaiter:Role
    {
        #region data members
        private int salary;
        #endregion
        #region properties
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion
        #region Constructors
        public Headwaiter() : base() { 
            base.RoleID = Role_Type.Headwaiter;
            base.Description = "Headwaiter";
            salary = 0;
        }
        #endregion

        #region methods
        public override int Payment()
        {
            return salary;
        }
        #endregion
    }
}
