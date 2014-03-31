using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGestion
{
    class Society
    {
        //Attributs
        #region Attributs
            private String _Nom;
            private String _Social_Reason;
            private String _Address;
            private String _City;
            private String _Postal_Code;
            private String _Mail_Address;
            private String _Type;
            private String _Phone_Number;
        #endregion

        //Accesseur
        #region Accesseur
            public String Phone_Number
            {
                get { return _Phone_Number; }
                set { _Phone_Number = value; }
            }
            public String Type
            {
                get { return _Type; }
                set { _Type = value; }
            }
            public String Mail_Address
            {
                get { return _Mail_Address; }
                set { _Mail_Address = value; }
            }
            public String Postal_Code
            {
                get { return _Postal_Code; }
                set { _Postal_Code = value; }
            }
            public String City
            {
                get { return _City; }
                set { _City = value; }
            }
            public String Address
            {
                get { return _Address; }
                set { _Address = value; }
            }
            public String Social_Reason
            {
                get { return _Social_Reason; }
                set { _Social_Reason = value; }
            }
            public String Nom
            {
                get { return _Nom; }
                set { _Nom = value; }
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
