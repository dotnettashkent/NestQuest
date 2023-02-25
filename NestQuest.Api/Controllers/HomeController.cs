//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//Free to use Comfort and Peace
//=================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace NestQuest.Api.Controllers 
{ 

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello Mario, the princess is in another castle");
    }
}
