using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retain.Handlers.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class RetainController : BaseController
    {
        /// <summary>
        ///     Get Book.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBookById()
        {
            var list = await Mediator.Send(new GetBookByIdQuery());
            return Ok(list);
        }

    }
}
