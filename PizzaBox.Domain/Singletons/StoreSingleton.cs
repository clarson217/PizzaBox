using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.IO;
using PizzaBox.Storing;
using System;
using System.Xml.Serialization;
using System.Linq;

namespace PizzaBox.Domain.Singletons
{
    
    public class StoreSingleton
    {
        private readonly string _storePath = @"store.xml";
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
                 new ChrisPizzaStore(),
                 new NewYorkPizzaStore(),
                 new ChicagoPizzaStore(),
                 new DetroitPizzaStore()

            };
            //fs Could be wrong
            FileStorage fs = new FileStorage();

            if(Stores == null)
            { 
                
                try{
                    Stores = fs.ReadFromXML<AStore>(_storePath).ToList();
                }catch(Exception e){
                    fs.WriteToXML(stores, _storePath);
                    Stores = fs.ReadFromXML<AStore>(_storePath).ToList();
                }
            }
        }
    }
}  