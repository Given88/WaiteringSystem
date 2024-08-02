using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.Business
{
    internal class Employee:Person
    {
        #region data fields
        private string _empNum;
        public Role _role;
        #endregion

        #region Properties
        public Role Role { get { return _role; } set { _role = value; } }
        private string EmpNum { get { return _empNum; } set { _empNum = value; } }
        #endregion
        #region Constructors
        public Employee(Role roleValue)
        {
            switch (roleValue.Description)
            {
                case "Runner":
                    _role = new Runner();
                    break;
                case "Headwaiter":
                    _role = new Headwaiter();
                    break;
                case "Waiter":
                    _role = new Waiter();
                    break;
                default:
                    _role = new Role();
                    break;
            }
        }
        #endregion
    }
}
