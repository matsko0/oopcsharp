namespace ATM
{
    public class CardHolder
    {
        private String cardNum;
        private int pin;
        private String firstName;
        private String lastName;
        private double balance;
        private long cardNumber;
        private int v;

        public CardHolder(String cardNum, int pin, String firstName, String lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public CardHolder(long cardNumber, int pin, string firstName, string lastName, int v)
        {
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.v = v;
        }

        public string GetCardNum() => cardNum;
        public int GetPin() => pin;
        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;
        public double GetBalance() => balance;

        public void SetCardNum(string newCardNum) => cardNum = newCardNum;
        public void SetPin(int newPin) => pin = newPin;
        public void SetFirstName(string newFirstName) => firstName = newFirstName;
        public void SetLastName(string newLastName) => lastName = newLastName;
        public void SetBalance(double newBalance) => balance = newBalance;
        public bool ValidatePin(int inputPin) => pin == inputPin;
    }
}