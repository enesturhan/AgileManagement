using Common.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileManagement.Api.Controllers
{



    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(Response<T>response) where T : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };


        }
    }
}
