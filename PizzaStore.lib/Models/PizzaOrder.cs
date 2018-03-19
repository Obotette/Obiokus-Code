using System;
using PizzaStore.lib.Enums;

namespace PizzaStore.lib.Models
{
    public class PizzaOrder
    {
        public int id {get;set;}
        public UserAccount user {get;set;}
        public Location place {get;set;}
        public Order order {get;set;}
        public OrderStatus status {get;set;}
        public Pizza pizza {get;set;}
        public DateTime time {get;set;}

        PizzaOrder()
        {

        }

        public void Add()
        {

        }

        public void Delete()
        {
            
        }
    }
}