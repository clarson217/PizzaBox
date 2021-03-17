using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace PizzaBox.Domain.Models
{
    [Serializable()]
    public class Address
    {
        
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public int RoomNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        
        public Address()
        {
            StreetNumber = 0;
            StreetName = "";
            RoomNumber = 0;
            City = "";
            State = "";
            Zipcode = 0;
        }
        public Address(int snum, string sname, string city, string state, int zipcode)
        {
            StreetNumber = snum;
            StreetName = sname;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        public Address(int snum, string sname, int rnum, string city, string state, int zipcode)
        {
            StreetNumber = snum;
            StreetName = sname;
            RoomNumber = rnum;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        
        // public string GetAddress()
        // {
            
        //     if(StreetNumber == 0 || string.IsNullOrEmpty(StreetName) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(State) || Zipcode == 0){
        //         return "Address is not valid";
        //     }else{
        //         string address;
        //         if(RoomNumber == 0)
        //         {
        //             address = StreetNumber + ' ' + StreetName
        //                 + "/n" + City + ", " + State + " " + Zipcode;
        //         }else{
        //             address = (StreetNumber + ' ' + StreetName + ' ' + RoomNumber 
        //             + "/n" + City + ", " + State + " " + Zipcode);
        //         }
        //         return address;
        //     }
        // }
        public override string ToString()
        {
            if(RoomNumber == 0)
            {
                return (StreetNumber + " " + StreetName + "\n" + City + ", " + State + " " + Zipcode);
            }else{
                return (StreetNumber + " " + StreetName + RoomNumber + "\n" +City + ", " + State + " " + Zipcode);
            }
            
        }
    }
}