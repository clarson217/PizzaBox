using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        private static StoreSingleton _storeSingleton;
        public List<AStore> Stores { get; set; }
        public static StoreSingleton Instance 
        {
            get
            {
                if(_storeSingleton == null)
                {
                    _storeSingleton = new StoreSingleton();
                }

            return _storeSingleton;
            }
            
           
        }
        
        private StoreSingleton()
        {
            
            var stores = new List<AStore>
            {
                new FreddyPizzaStore() {Name = "freddy pizza"},
                new NewYorkPizzaStore() {Name = "New York Pizza"},
                new ChicagoPizzaStore() {Name = "Chicago Pizza"},
                new DetroitPizzaStore() {Name = "Detroit Pizza"}

            };
            var fs = new FileStorage();
            if(Stores == null)
            {
                Stores = fs.ReadFromXML<AStore>().ToList();
            }
        }
        /*public static StoreSingleton GetInstance()
        {
            if(_storeSingleton == null)
            {
                _storeSingleton = new StoreSingleton();
            }

            return _storeSingleton;
        }*/
    }
}  