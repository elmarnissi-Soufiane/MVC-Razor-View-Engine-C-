using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Razor_View_Engine.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Saisire Votre Nom . ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Saisire Votre Adresse . ")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Sasire Votre Age . ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Saisire Votre Télèphone . ")]
        public string Tele { get; set; }

        public Customer() { }

        public Customer(int id, string name, string adresse, int age, string tele)
        {
            this.Id = id;
            this.Name = name;
            this.Adresse = adresse;
            this.Age = age;
            this.Tele = tele;
        }

    }
}