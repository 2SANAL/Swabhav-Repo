
namespace CustomerApp
{
    class Custmor
    {
       
        private string _firstname;
        private string _lastname;
        private static int _id;
        private int nextcustomerid;
        
        static Custmor()
        {
            _id = 1000;
        }

        public Custmor(string firstname,string lastname)
        {
            
            _firstname = firstname;
            _lastname = lastname;
             _id+=1;
            nextcustomerid = _id;
        }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
        }
        public int CustmorId
        {
            get
            {
                return nextcustomerid;
            }
        }
    }
}
