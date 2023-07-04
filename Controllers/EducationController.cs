using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Chandan_Rajendra.Models;

namespace CV_Chandan_Rajendra.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            var list_all_edu = all_edu();

            return View(list_all_edu);
        }

        public static List<Education> all_edu()
        {
            var POLITO = new Education
            {
                Id = 1,
                Name = "Politecnico di Torino",
                Course = "Master of Science in Energy engineering",
                Year = 2022,
                Address = "Corso Duca degli Abruzzi, 24, Torino, Italy",
                college_link = "https://www.polito.it/",
                logo= "/Images/Polito_logo.jpg"
            };

            var VVCE = new Education
            {
                Id = 2,
                Name = "Vidyavardhaka college of engineering",
                Course = "Bachelor of Engineering in Mechanical",
                Year=2016,
                Address= " P.B. No.206, Kannada Sahithya Parishath Rd, III Stage, Gokulam, Mysuru, Karnataka 570002, India",
                college_link = "https://vvce.ac.in/",
                logo= "/Images/VVCE_logo.png"
            };

            var Infosys = new Education
            {
                Id=3,
                Name= "Infosys limited",
                Course = "Python and ASP.NET",
                Year = 2017,
                Address= " 9H6W+XHC, Infosys Rd, Hebbal Industrial Estate, Hebbal, Mysuru, Karnataka 570027, India",
                college_link= "https://www.infosys.com/",
                logo= "/Images/Infosys_logo.png"
            };

            var Computer_paradise = new Education
            {
                Id = 4,
                Name = "Computer Paradise",
                Course = "Catia V5 R20",
                Year = 2015,
                Address = " 7J9C+FXF, Sri Rampura II stage Madhuvana Layout Front of IOB Bank, behind Bramarambha choutry, Mysuru, Karnataka 570023, India",
                college_link = "https://www.linkedin.com/company/computer-paradise/",
                logo= "/Images/CP_logo.jpg"
            };

            var list_edu = new List<Education>()
            {
                POLITO,
                Infosys,
                VVCE,
                Computer_paradise
            };

            return list_edu;
        }
    }
}