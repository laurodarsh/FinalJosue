using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Classes
{
    public class User
    {
        private int id = 0;
        private string name;
        private string password;
        private string email;
        private bool active;
        private UserProfile userProfile;

        public User(string name, string password, string email, bool active, UserProfile userProfile)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.active = active;
            this.userProfile = userProfile;
        }

        public User()
        {
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public UserProfile UserProfile
        {
            get
            {
                return userProfile;
            }

            set
            {
                userProfile = value;
            }
        }
    }
}
