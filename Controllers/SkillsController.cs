using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Chandan_Rajendra.Models;

namespace CV_Chandan_Rajendra.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills

        public static List<Skills> all_skills()
        {
            var skill1 = new Skills
            {
                Id = 1,
                Name = "Python",
                Skill_hyperlink = "https://www.python.org/",
                Experience = 2,
                Training_place = "Infosys",
                TP_hyplnk = "https://www.infosys.com/",
                Level = "Expert",
                No_of_projects = 4,
                Image_loc = "/Images/Python_logo.png"
            };

            var skill2 = new Skills
            {
                Id = 2,
                Name = "ASP.NET",
                Skill_hyperlink = "https://www.asp.net/",
                Experience = 2,
                Training_place = "Infosys",
                TP_hyplnk = "https://www.infosys.com/",
                Level = "Expert",
                No_of_projects = 2,
                Image_loc = "/Images/.NET_logo.jpg"
            };

            var skill3 = new Skills
            {
                Id = 3,
                Name = "Catia V5",
                Skill_hyperlink = "https://www.3ds.com/products-services/catia/",
                Experience = 2,
                Training_place = "Computer Paradise",
                TP_hyplnk = "https://www.linkedin.com/company/computer-paradise/",
                Level = "Expert",
                No_of_projects = 2,
                Image_loc = "/Images/Catia_logo.jpg"
            };

            var skill4 = new Skills
            {
                Id = 4,
                Name = "MATLAB & Simulink",
                Skill_hyperlink = "https://www.mathworks.com/products/simulink.html",
                Experience = 1,
                Training_place = "Politecnico di Torino",
                TP_hyplnk = "https://www.polito.it/",
                Level = "Advanced",
                No_of_projects = 1,
                Image_loc = "/Images/Matlab_logo.png"
            };

            var skill5 = new Skills
            {
                Id = 5,
                Name = "PVsyst",
                Skill_hyperlink = "https://www.pvsyst.com/",
                Experience = 1,
                Training_place = "Politecnico di Torino",
                TP_hyplnk = "https://www.polito.it/",
                Level = "Expert",
                No_of_projects = 6,
                Image_loc = "/Images/PVsyst_logo.png"
            };

            var skill6 = new Skills
            {
                Id = 6,
                Name = "WAsP",
                Skill_hyperlink = "https://www.wasp.dk/",
                Experience = 1,
                Training_place = "Politecnico di Torino",
                TP_hyplnk = "https://www.polito.it/",
                Level = "Expert",
                No_of_projects = 2,
                Image_loc = "/Images/WAsP_logo.png"
            };

            var skill7 = new Skills
            {
                Id = 7,
                Name = "MS Excel Automation",
                Skill_hyperlink = "https://support.microsoft.com/en-us/office/automate-tasks-with-the-macro-recorder-974ef220-f716-4e01-b015-3ea70e64937b",
                Experience = 2,
                Training_place = "Infosys",
                TP_hyplnk = "https://www.infosys.com/",
                Level = "Expert",
                No_of_projects = 1,
                Image_loc = "/Images/Excel_logo.png"
            };

            var skill8 = new Skills
            {
                Id = 8,
                Name = "HTML",
                Skill_hyperlink = "https://en.wikipedia.org/wiki/HTML",
                Experience = 2,
                Training_place = "Infosys",
                TP_hyplnk = "https://www.infosys.com/",
                Level = "Expert",
                No_of_projects = 2,
                Image_loc = "/Images/HTML_logo.png"
            };

            var skill9 = new Skills
            {
                Id = 9,
                Name = "SQL",
                Skill_hyperlink = "https://en.wikipedia.org/wiki/SQL",
                Experience = 2,
                Training_place = "Infosys",
                TP_hyplnk = "https://www.infosys.com/",
                Level = "Advanced",
                No_of_projects = 1,
                Image_loc = "/Images/SQL_logo.png"
            };
            var listSkills = new List<Skills>()
            {
                skill1, skill2, skill3, skill4, skill5, skill6,skill7, skill8, skill9
            };

            return listSkills;
        }


        public ActionResult Index()
        {
            
            var list_all_skills = all_skills();

            return View(list_all_skills);
        }
       

       
    }
}