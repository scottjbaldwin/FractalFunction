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
        [HttpPost]
        public async Task<object> Post([FromBody]FractalCreateModel fractalCreate)
        {
            var mandelbrot = new Mandelbrot();
            return await Task.FromResult(
                mandelbrot.CalculateArea(
                    fractalCreate.Iterations,
                    fractalCreate.BottomLeftX,
                    fractalCreate.BottomLeftY,
                    fractalCreate.TopRightX,
                    fractalCreate.TopRightY,
                    1000,
                    1000)
            );
        }
    }
}