using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem.Business
{
    public class Runner:Role
    {
        #region data fields
        private int tips;
        private int rate;
        private int noOfShifts;
        #endregion
        #region properties
        public int Tips { get { return tips; } set { tips = value; } }
        public int Rate { get { return rate; } set { rate = value; } }
        public int NoOfShifts { get { return noOfShifts; } set { noOfShifts = value; } }
        #endregion
        #region constructors
        public Runner() : base()
        {
            base.RoleID = Role_Type.Runner;
            base.Description = "Runnner";
            tips = 0;
            rate = 0;   
            noOfShifts = 0;
        }
        #endregion
        #region methods
        public override int Payment()
        {
            return rate*noOfShifts;
        }
        public override int Payment(int _tips)
        {
           
            return rate * noOfShifts + _tips;
        }
        #endregion
    }
}
