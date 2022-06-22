﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Suplier
    {
        //properties
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MoreInfo { get; set; }
        public DateTime ContractDate { get; set; }

        //constructor
        public Suplier() { }
    }
}
