using System.ComponentModel.DataAnnotations;
using System;

namespace Sandwiches.Models
{
    public class Sammich
    {
        [Display(Name="Sammich Name:")]
        [Required(ErrorMessage="A sammich needs a name.")]
        [MinLength(5,ErrorMessage="The sammich name needs to be at least 5 characters.")]
        public string Name {get;set;}

        [Display(Name="Protien:")]
        [Required(ErrorMessage="Protien is required.")]
        public string Protien {get;set;}

        [Display(Name="# of Calories:")]
        [Required(ErrorMessage="Calories are required.")]
        [Range(1500,Int32.MaxValue,ErrorMessage="A sammich must be at least 1500 calories")]
        public int Calories {get;set;}

        [Display(Name="Type of Bread:")]
        [Required(ErrorMessage="Bread is required.")]
        public string Bread {get;set;}

        [Display(Name="Topping One:")]
        public string ToppingOne {get;set;}


        public string ToppingTwo {get;set;}


        public string Beverage {get;set;}

        
    }
}