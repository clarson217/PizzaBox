using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace PizzaBox.Domain.Models
{
    [Serializable()]
    public class ChicagoPizzaStore : AStore
    {
        //Store location = Chicago
        
       
        
        
        public ChicagoPizzaStore()
        {
            SetName("Chicago Pizza Store");
            this.storeAddress = new Address(231, "Main Street", "Chicago", "IL", 23451);
        }
    }
}