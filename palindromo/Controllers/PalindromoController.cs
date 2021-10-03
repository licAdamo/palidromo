 /* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 3, Ejercicio 3: Palindromo
    Nombre de la alumna: Ada Nazcais Martin Morales
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;
using palindromo.Entities;

namespace Palindromo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
         [HttpPost]

        public string Post (frase dto)
        {
            string Frase = dto.Frase.Replace(" ", "").ToLower();
            string palabra;
            string reverso = "";
            string texto;

            int i = Frase.Length;
            MatchCollection wordColl = Regex.Matches(dto.Frase, @"[\W]+");

            for(int x = (i - 1); x >= 0; x--)
            {
                palabra= Frase.Substring(x, 1);
                reverso = reverso + palabra;
            }

            if (Frase == reverso)
            {
                texto = "es palindromo";
            }
            else
            {
                texto = "no es palindromo";
            }
            return (texto+ "cantidad de palabras:"+(wordColl.Count+1));
          
        }

    }
}