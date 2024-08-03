using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiteringSystem
{
    public class Person
    {
        #region data members
        private string _id;
        private string _name;
        private string _phone;
        #endregion

        #region Properties
        public string ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        #endregion

        #region Constructors
        public Person() 
        {
            _id = "";
            _name = "";
            _phone = "";
        }
       
        public Person(string id, string name, string phone)
        {
            _id = id;
            _name = name;
            _phone = phone;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return _name +" "+ _phone;
        }
        #endregion
    }

    /*
   Characteristics of an abstract class"
    -It cannot be instanstiated
    -It contains methods which are declared without any implementation
    -Intended to be inherited
    */
}
