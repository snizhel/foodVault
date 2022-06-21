namespace DataAccessLayer_DAL
{
    public class InputInfo
    {
        //properties
        public int Id { get; set; }
        public int IdFood { get; set; }
        public int IdInput { get; set; }
        public int CountInput { get; set; }
        public float InputPrice { get; set; }
        public string StatusInput { get; set; }


        //constructor
        public InputInfo() { }
    }
}
