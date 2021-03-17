using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace PizzaBox.Domain.Models
{
    [Serializable()]
    public class ChrisPizzaStore : AStore
    {
        
        
        

        public ChrisPizzaStore()
        {
            SetName("Chris' Pizza Store");
            this.storeAddress = new Address(123, "Main Street", "Pleasantview", "MI", 12345);
        }
    }
}