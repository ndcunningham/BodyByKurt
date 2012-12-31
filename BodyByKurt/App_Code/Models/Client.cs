using System;
using System.Collections.Generic;

namespace BodyByKurt.Models
{
    public class Client
    {
        public Client()
        {
            this.Diets = new List<Diet>();
        }

        public int Client_Id { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public System.DateTime DOB { get; set; }
        public string Tel { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Diet> Diets { get; set; }
    }
}
