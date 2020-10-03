namespace API.Entities
{
    public class Appuser
    {
        public int Id { get; set; }
        public string UserName{get;set;}

       
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        

    }
}