using System.ComponentModel.DataAnnotations;

namespace Sandwiches.Models
{
    public class Sammich
    {
        [Display(Name="Sammich Name:")]
        public string Name {get;set;}

        [Display(Name="Protien:")]
        public string Protien {get;set;}

        [Display(Name="# of Calories:")]
        public int Calories {get;set;}

        [Display(Name="Type of Bread:")]
        public string Bread {get;set;}

        [Display(Name="Topping One:")]
        public string ToppingOne {get;set;}

        public string ToppingTwo {get;set;}
        public string Beverage {get;set;}
    }
}