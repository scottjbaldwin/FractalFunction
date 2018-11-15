using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FractalFunction.Models;

namespace FractalFunction.Controllers
{

    [Route("api/[controller]")]
    public class FractalController : Controller
    {
        [HttpPost]
        public async Task<string> Post([FromBody]FractalCreateModel fractalCreate)
        {
            return await Task.FromResult(
                $"Parameters passed were Iterations: {fractalCreate.Iterations} X1: {fractalCreate.BottomLeftX} Y1 {fractalCreate.BottomLeftY} X2 {fractalCreate.TopRightX} Y2 {fractalCreate.TopRightY}"
            );
        }
    }
}