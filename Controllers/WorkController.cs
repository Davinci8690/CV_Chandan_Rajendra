using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Chandan_Rajendra.Models;

namespace CV_Chandan_Rajendra.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Index2()
        {
            var List_All_Work = All_Work();

            return View(List_All_Work);
        }

        public static List<Work> All_Work()
        {
            var work1 = new Work()
            {
                Id = 1, 
                Company = "Infosys ltd",
                Experience=2.3,
                Place = "Mysore, India",
                Projects = 4,
                list_skills = new List<string>() { "Python, ","ASP.NET, ","Catia V5"}, 
                Year = 2017,
                Job_pos="Systems Engineer",
                Company_link = "https://www.infosys.com/",
                logo = "/Images/Infosys_logo.png",
                Description = "Worked on more than 5 projects" +
                "1.Automation of CATIA V5 application using VB.net Framework for Mitsubishi Regional Jets. " +
                "2.Automation of CATIA V5 application using VB.net Framework for Boeing. " +
                "3.Automation of MS Excel tool. " +
                "4.Testing of Autocad application."


            };

            var work2 = new Work()
            {
                Id = 2,
                Company = "CVA SPA",
                Experience = 0.1,
                Place = "Chatillon, Italy",
                Projects = 2,
                list_skills = new List<string>() { "PVsyst, ", "WAsP" },
                Year = 2022,
                Job_pos = "RES Engineer(Intern)",
                Company_link= "https://cvaspa.it/",
                logo = "/Images/CVA_logo.jpg",
                Description = "In this internship, I modelled some photovoltaic and wind plants, with the tools such as PV syst and WAsP, " +
                "for which we could make available field data for validation.Then compare the models with our methodologies for potential " +
                "optimization. Also built a Python tool for merging all monthly excel files of anemometric data into a Yearly excel file."

            };

            var List_All_Work = new List<Work>() { work1, work2 };

            return List_All_Work;
        }
    }
}