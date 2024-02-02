namespace LibreriaObjetos1
{
    public class Customer
    {
        private string _name;
        private int _dni;
        private DateTime _birthDay;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int dni
        {
            get { return _dni;}
            set { _dni = value; }
        }
        public DateTime BirthDay
        {
            get { return _birthDay;}
            set { _birthDay = value; }
        }
    }
}