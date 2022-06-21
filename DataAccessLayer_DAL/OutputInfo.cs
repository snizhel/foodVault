namespace DataAccessLayer_DAL
{
    public class OutputInfo
    {
        //properties
        public int Id { get; set; }
        public int IdFood { get; set; }
        public int IdOutput { get; set; }
        public int IdInputInfo { get; set; }
        public int IdCustomer { get; set; }
        public int CountOutput { get; set; }
        public float OutputPrice { get; set; }
        public string StatusOutput { get; set; }

        //constructor
        public OutputInfo() { }
    }
}
