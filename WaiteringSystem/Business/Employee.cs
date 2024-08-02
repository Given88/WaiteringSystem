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
        private string _role;
        #endregion

        #region Properties
        public string Role { get { return _role; } set { _role = value; } }
        private string EmpNum { get { return _empNum; } set { _empNum = value; } }
        #endregion
    }
}
