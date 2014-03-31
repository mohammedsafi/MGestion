using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGestion
{
    class Announce
    {
        //Attributs
        #region Attributs
            private String _Title;
            private DateTime _Time_Todif;
            private DateTime _Date_Topost;
            private String _About_Post;
            private String _About_Profil;
            private String _Address;
            private String _City;
            private String _Postal_Code;
            private String _Mail_Address;
            private String _Phone_Number;
            private String _Ctrat_Type;
            private String _Job_Cible;
            private String _Domain;
            private String _Author;
        #endregion

        //Accesseur
        #region Accesseur
            public String Author
            {
                get { return _Author; }
                set { _Author = value; }
            }
            public String Domain
            {
                get { return _Domain; }
                set { _Domain = value; }
            }
            public String Job_Cible
            {
                get { return _Job_Cible; }
                set { _Job_Cible = value; }
            }
            public String Ctrat_Type
            {
                get { return _Ctrat_Type; }
                set { _Ctrat_Type = value; }
            }
            public String Phone_Number
            {
                get { return _Phone_Number; }
                set { _Phone_Number = value; }
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
            public String About_Profil
            {
                get { return _About_Profil; }
                set { _About_Profil = value; }
            }
            public String About_Post
            {
                get { return _About_Post; }
                set { _About_Post = value; }
            }
            public DateTime Date_Topost
            {
                get { return _Date_Topost; }
                set { _Date_Topost = value; }
            }
            public DateTime Time_Todif
            {
                get { return _Time_Todif; }
                set { _Time_Todif = value; }
            }
            public String Title
            {
                get { return _Title; }
                set { _Title = value; }
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
