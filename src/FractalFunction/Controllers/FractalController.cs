using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FractalFunction.Models;
using FractalFunction;

namespace FractalFunction.Controllers
{

    [Route("api/[controller]")]
    public class FractalController : Controller
    {
        public async Task<string> Get()
        {
            return await Task.FromResult("You got it");
        }

        [HttpPost]
        public async Task<object> Post(FractalCreateModel fractalCreate)
        {
            var mandelbrot = new Mandelbrot();
            return await Task.FromResult(
                mandelbrot.CalculateArea(
                    fractalCreate.Iterations,
                    fractalCreate.BottomLeftX,
                    fractalCreate.BottomLeftY,
                    fractalCreate.TopRightX,
                    fractalCreate.TopRightY,
                    fractalCreate.Steps,
                    fractalCreate.Steps)
            );
        }
    }
}