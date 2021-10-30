using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using cfeApp.Domain;



namespace cfeApp.Controller
{
    [Route("api/[controller]")]
    public class cfecontroller : ControllerBase
    {
        [HttpGet]
        [Route ("Calcular/{bn1}/{bn2}/{bn3}/{bn4}")] 
        public IActionResult ValorResistencia (string bn1, string bn2, int bn3, string bn4)
        {
            var rst = new CalResistencia();
            
            var resultado = rst.Calcular(bn1, bn2, bn3, bn4);
            
            return Ok($"el valor de la resistencia cuyo vaLor en franja tiene los valores {bn1}, {bn2}, {bn3}, {bn4} es de {resultado}");
        }
    }
}