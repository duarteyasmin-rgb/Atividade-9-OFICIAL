using Microsoft.AspNetCore.Mvc;
using CalculadoraIMC.Models;

namespace CalculadoraIMC.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(ImcModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resultado = model.Peso /
                    (model.Altura * model.Altura);

                if (model.Resultado < 18.5)
                    model.Classificacao = "Abaixo do peso";
                else if (model.Resultado < 25)
                    model.Classificacao = "Peso normal";
                else if (model.Resultado < 30)
                    model.Classificacao = "Sobrepeso";
                else
                    model.Classificacao = "Obesidade";

                return View(model);
            }

            return View(model);
        }
    }
}