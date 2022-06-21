using System;

namespace DataAccessLayer_DAL
{
    public class Customer
    {
        //properties
        public int CustomerId { get; set; }
        public string DisplayNameCustomer { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MoreInfo { get; set; }
        public DateTime ContractDate { get; set; }

        //constructor
        public Customer() { }
    }
}
