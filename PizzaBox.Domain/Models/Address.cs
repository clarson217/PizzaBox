namespace PizzaBox.Domain.Models
{
    public class Address
    {
        private int streetNumber = 0;
        private string streetName;
        private int roomNumber = 0;
        private string city;
        private string state;
        private int zipcode = 0;

        public Address(int snum, string sname, string city, string state, int zipcode)
        {
            streetNumber = snum;
            streetName = sname;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }
        public Address(int snum, string sname, int rnum, string city, string state, int zipcode)
        {
            streetNumber = snum;
            streetName = sname;
            roomNumber = rnum;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }
        
        public string getAddress()
        {
            
            if(streetNumber == 0 || string.IsNullOrEmpty(streetName) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || zipcode == 0){
                return "Address is not valid";
            }else{
                string address;
                if(roomNumber == 0)
                {
                    address = streetNumber + ' ' + streetName
                        + "/n" + city + ", " + state + " " + zipcode;
                }else{
                    address = streetNumber + ' ' + streetName + ' ' + roomNumber +
                        + "/n" + city + ", " + state + " " + zipcode;
                }
                return address;
            }
        }
    }
}