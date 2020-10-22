using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkillsTacker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        string websiteHeader = "<h1>Skills Tracker</h1>";
        List<string> skills = new List<string> { "JavaScript", "C#", "Java" };
        List<string> skillLevel = new List<string> {"<option value='beginner'>Beginner</option>",
            "<option value='intermediate'>Intermediate</option>",
            "<option value='professional'>Professional</option>"};
        

        [HttpGet]
        public IActionResult SkillsCouldBeWorkingOnView()
        {
            string result = websiteHeader +
                "<h2>Languages You Can Learn!</h2>" +
                "<ol>" +
                "<li>" + skills[0] + "</li>" +
                "<li>" + skills[1] + "</li>" +
                "<li>" + skills[2] + "</li></ol>";
            return Content(result, "text/html");
        }
        [HttpGet("form")]
        public IActionResult DisplayFormLearningProgress()
        {
            string form = "<form method='Post'>" +
                "date: <input type='date' name='date'/><br/>" +
                skills[0] + ":<select name='javascriptLevel'>" +
                    skillLevel[0] +
                    skillLevel[1] +
                    skillLevel[2] +
                "</select><br/>" +
                skills[1] + ":<select name='cSharpLevel'>" +
                    skillLevel[0] +
                    skillLevel[1] +
                    skillLevel[2] + 
                "</select><br/>" +
               skills[2] + ":<select name='javaLevel'>" +
                    skillLevel[0] +
                    skillLevel[1] +
                    skillLevel[2] +
                "</select><br/>" +
                "<input type='submit' value='Submit Form'/></form>";

            return Content(form, "text/html");
        }
        [HttpPost("form")]
        public IActionResult FormSentDisplay(string date, string javascriptLevel, string cSharpLevel, string javaLevel)
        {
            string result = websiteHeader+ 
                date + "<ol>" + 
                "<li>" + skills[0] + ": " + javascriptLevel + "</li>" +
                "<li>" + skills[1] + ": "+ cSharpLevel + "</li>" +
                "<li>" + skills[2] + ": " + javaLevel + "</li></ol>";

            return Content(result, "text/html");
        }
    }
}
