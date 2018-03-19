using System.Collections.Generic;

namespace PizzaStore.lib.Models
{
    public class DeliveryStore
    {
        public int id {get;set;}
        public Location location {get;set;}
        public Phone phone {get;set;}
        protected List<PizzaOrder> orders {get;set;}
    }
}