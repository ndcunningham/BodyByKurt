using System;
using System.Collections.Generic;

namespace BodyByKurt.Models
{
    public class Diet
    {
        public int Diet_Id { get; set; }
        public string Food { get; set; }
        public System.DateTime Date_Time { get; set; }
        public int Client_Id { get; set; }
        public virtual Client Client { get; set; }
    }
}
