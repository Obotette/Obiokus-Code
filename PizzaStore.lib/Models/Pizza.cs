using System.Collections.Generic;
using PizzaStore.lib.Enums;

namespace PizzaStore.lib.Models
{
    public class Pizza
    {
        public int id {get;set;}
        public PizzaSize size {get;set;}
        public PizzaCrust crust {get;set;}
        public PizzaSauce sauce {get;set;}
        public Cheese cheese {get;set;}
        public List<Meats> meats {get;set;}
        public List<Veggies> veggies {get;set;}
    }
}