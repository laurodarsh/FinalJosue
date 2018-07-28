using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Classes
{
    public class UserProfile
    {
        private string name;
        private bool active;
        private int id = 0;

        public UserProfile(string name, bool active)
        {
            this.name = name;
            this.active = active;
        }

        public UserProfile()
        {
        }

        public UserProfile(string name, bool active, int id)
        {
            this.name = name;
            this.active = active;
            this.id = id;
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
    }
}
