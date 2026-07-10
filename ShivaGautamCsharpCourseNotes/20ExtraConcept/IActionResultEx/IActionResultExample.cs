using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._20ExtraConcept.IActionResultEx
{
    internal class IActionResultExample
    {
        /*
         IActionResult is an interface in ASP.NET Core that represents the result of an action method in a controller. It is used to define the response
        that will be sent back to the client after processing a request. IActionResult allows developers to return different types of responses,
        such as JSON, HTML, or status codes, based on the outcome of the action method.

        Methods of IActionResult:
        ok(): Returns a 200 OK response with the specified content.
        404 Not Found: Returns a 404 Not Found response.
        400 Bad Request: Returns a 400 Bad Request response.


        First, tell me which project you created.
        Is it:
                ✅ ASP.NET Core Web API
                ✅ ASP.NET Core MVC
                ❌ Console Application
                ❌ Class Library
               IActionResult only exists in ASP.NET Core MVC/Web API projects.
         */


        //In Console Application, we cannot use IActionResult because it is specific to ASP.NET Core MVC/Web API projects.
        //public IActionResult GetMessage()
        //{
        //    return Ok("Welcome Vishal");
        //}
    }
}
