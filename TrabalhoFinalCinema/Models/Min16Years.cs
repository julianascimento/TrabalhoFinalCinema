using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Min16Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var empregado = (Empregados)validationContext.ObjectInstance;

            if (empregado.Idade == null) // se o usuário não informou Birthdate
            {
                return new ValidationResult("O campo Idade é obrigatório");
            }

            // cálculo básico de idade
            //var age = DateTime.Today.Year - empregado.Idade.Value.Year;

            return (empregado.Idade >= 16)
                ? ValidationResult.Success
                : new ValidationResult("O Empregado deve ter, ao menos, 16 anos, para trabalhar.");
        }
    }
}