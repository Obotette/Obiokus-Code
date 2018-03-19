namespace PizzaStore.lib.Models
{
    public class Phone
    {
        public int id {get;set;}
        public string area {get;set;}
        public string digits {get;set;}

        Phone()
        {

        }

        Phone(string n)
        {
            area = n.Substring(0,3);
            digits = n.Substring(3);

        }

    }

}