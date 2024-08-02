using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WaiteringSystem.Business
{
    public class Role
    {
        #region data field
        private string _description;
        private Role_Type _roleID;
        #endregion

        #region enum role type
        public enum Role_Type
        {
            None =0,
            Headwaiter =1,
            Waiter = 2,
            Runner = 3,

        }
        #endregion

        #region Property
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public Role_Type RoleID { 
            get { return _roleID; }
            set { _roleID = value; } 
        }
        #endregion

        #region Constructors

        public Role()
        {
       _roleID = Role_Type.None;
         _description = "no role";
        }
        #endregion

        #region methods
        public virtual int Payment()
        {
            return 0;
        }

        public virtual int Payment(int arg)
        {
            return 0;
        }
        #endregion
    }


}