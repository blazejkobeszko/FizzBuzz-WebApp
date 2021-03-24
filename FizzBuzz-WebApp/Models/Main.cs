using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_WebApp.Models
{
    public class Main
    {
        [Display(Name = " ")]
        [Required(ErrorMessage = "Podaj liczbę z przedziału 1-1000.")]
        [Range(1, 1000)]
        public int Liczba { get; set; }

        public string Wynik { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime Data
        {
            get; set;
        }
        public void Fizz()
        {
            Wynik = "Otrzymano: ";
            if (Liczba % 3 == 0)
                Wynik = Wynik+"Fizz";
            if (Liczba % 5 == 0)
                Wynik = Wynik + "Buzz";
            if (Liczba % 3 != 0 && Liczba % 5 != 0)
                Wynik = "Liczba "+Liczba.ToString()+ " nie spełnia kryteriów Fizz / Buzz";

            Data = DateTime.Now;
        }
    }
}

