namespace ProjBibR.Entidades
{
    public class User
    {
        public int Id { get; set; }//pk
        public string name { get; set; }
        public int age { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool remember { get; set; }
        public bool terms { get; set; }


    }
}
