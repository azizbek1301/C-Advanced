using OOP_interfacelar_._.Enums;

namespace OOP_interfacelar_._
{
    public class User:Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        private decimal _balance;
        public decimal Balance 
        { 
            get
            {
                return _balance;
            }
            set { _balance = value/2; }
        }
       

    }
}
