using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Members
    {
        public static List<Members> mList = new List<Members>();
        string name;
        string username;
        string password = null;
        string cPassword;
        bool c;
        public string state;
        Trails trail; 
        public Members(string name, string username, string password, string email, string cPassword)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            c = false;
            this.cPassword = cPassword;
            state = " ";
            
        }
        public bool ControlAccount
        {
            get
            {
                return c;
            }
        }
        public string userName
        {
            get
            {
                return username;
            }
        }
        public string passWord
        {
            get
            {
                return password;
            }
        }
        public string Announ(string error, string code)
        {
            switch(error)
            {
                case "emptyfield":
                {
                        switch(code)
                        {
                            case "email": return "You have to input a correct e-mail adress.";
                            case "username": return "You have to input a username.";
                            case "password": return "You have to input a password.";
                        }
                        return "An error occured.";
                }
                case "PasswordNotConfirmed": return "The password you entered is not confirmed.";
            }
            mList.Add(this);
            c = true;
            return "Registration is completed successfully.";

        }
        public string Check()
        {
            if (username == "") return Announ("emptyfield", "username");
            if (name == "") return Announ("emptyfield", "email");
            if (password == "") return Announ("emptyfield", "password");
            //if (password.CompareTo(cPassword) != 0) return Announ("PasswordNotConfirmed", "none");
            Trails tObject = new Trails();
            return Announ("success", "sc");

        }

    }
        
}