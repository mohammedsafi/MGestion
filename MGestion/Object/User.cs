using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGestion
{
    class User
    {
        //Attributs
        #region Attributs
            private String _Fam_Name;
            private String _Name;
            private DateTime _Birhtdate;
            private String _Fax_Number;
            private String _Address;
            private String _Metier;
            private String _Phone_Number;
            private String _Password;
            private String _Website;
        #endregion

        //Accesseur
        #region Accesseur
            public String Fam_Name
            {
                get { return _Fam_Name; }
                set { _Fam_Name = value; }
            }
            public String Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public DateTime Birthdate
            {
                get { return _Birhtdate; }
                set { _Birhtdate = value; }
            }
            public String Fax_Number
            {
                get { return _Fax_Number; }
                set { _Fax_Number = value; }
            }
            public String Address
            {
                get { return _Address; }
                set { _Address = value; }
            }
            public String Metier
            {
                get { return _Metier; }
                set { _Metier = value; }
            }
            public String Phone_Number
            {
                get { return _Phone_Number; }
                set { _Phone_Number = value; }
            }
            public String Password
            {
                get { return _Password; }
                set { _Password = value; }
            }
            public String Website
            {
                get { return _Website; }
                set { _Website = value; }
            }
        #endregion

        //Constructeur
        #region Constructeur

        #endregion

        //Methodes
        #region Methodes

        #endregion
    }
}
