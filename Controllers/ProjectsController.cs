using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Chandan_Rajendra.Models;
using CV_Chandan_Rajendra.Controllers;


namespace CV_Chandan_Rajendra.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects

        public ActionResult RES_Tool()
        {                        
            var all_proj = all_projects();
            var RES = all_proj[0];

            return View(RES);  
        }

        public ActionResult Excel_merger()
        {
            var all_proj = all_projects();
            var excel_merger = all_proj[2];
            return View(excel_merger);
        }

        public ActionResult PVsyst()
        {
            var all_proj = all_projects();
            var PVsyst = all_proj[3];

            return View(PVsyst);
        }

        public ActionResult Financial_assessment()
        {
            var all_proj = all_projects();
            var financial_assessment = all_proj[3];
            return View(financial_assessment);
            
        }

        public ActionResult WAsP()
        {
            var all_proj = all_projects();
            var WAsP = all_proj[5];

            return View(WAsP);
        }

        public ActionResult Catia()
        {
           var all_catia_proj = CV_Chandan_Rajendra.Controllers.CatiaController.list_catia_Projects();
            
           return View(all_catia_proj);
        }

        public ActionResult Matlab()
        {
            var all_proj = all_projects();
            var Matlab = all_proj[5];
            return View(Matlab);
        }

        public ActionResult Index()
        {
            

            var lis_all_projects = all_projects();

            return View(lis_all_projects);
        }

        public static List<Projects> all_projects()
        {
            var project1 = new Projects
            {
                Id = 1,
                Name = "RES Tool",
                Worked_for = "Polito",
                Lan_or_tool = "Python",
                Description = "Python tool built with proper formulation with precise and accurate simulation for Energy and Economic " +
                "Analysis of Solar and Wind plants.",
                Year = 2022,
                Proj_hyperlink = "https://www.python.org/",
                Path = "/Projects/RES_Tool",
                Image_loc = "/Project_Images/RES_tool.jpg"

            };

            var catia_project = new Projects
            {
                Id = 2,
                Name = "Catia V5 projects",
                Worked_for = "Infosys",
                Lan_or_tool = "Catia V5",
                Description = "3D modelling of products for intuitive specification driven modeling for Solid, Hybrid and Sheetmetal Part design, Assembly design and integrated Drafting.",
                Year = 2016,
                Proj_hyperlink = "/Home/Skills",
                Image_loc = "/Images/Catia_projects/3D/Twin_pipe.jpg",
                Path = "/Projects/Catia"


            };

            

            var project3 = new Projects
            {
                Id=3,
                Name = "Financial Assessment Calculator",
                Worked_for = "Politecnico di Torino",
                Lan_or_tool = "Python",
                Description = "Tool to calculate the Internal return rate(IRR), Payback time(PBT), Net present value of the tool(NPV) and " +
                "levelised cost of energy(LCOE) of the Plant/Project.",
                Year = 2022,
                Proj_hyperlink = "/Home/Skills",
                Image_loc = "/Images/Financial_assessment_tool.jpg",
                Path= "/Projects/Financial_assessment"

            };
            var Pvsyst_project = new Projects
            {
                Id = 4,
                Name = "PVsyst Projects",
                Worked_for = "C.V.A.s.p.a",
                Lan_or_tool = "PVsyst V7.2",
                Description = "PVsyst 7.2 is a PC software package for the study, sizing and data analysis of complete PV systems. It deals with grid-connected, stand-alone, pumping and DC-grid (public transportation) PV systems, and includes extensive meteo and PV systems components databases, as well as general solar energy tools.",
                Year=2022,
                Proj_hyperlink = "/Home/Skills",
                Image_loc = "/Images/PVsyst_tool.jpg",
                Path = "/Projects/PVsyst"
            };


            var WASP_project = new Projects
            {
                Id = 5,
                Name = "WAsP Projects",
                Worked_for = "C.V.A.s.p.a",
                Lan_or_tool = "WAsP",
                Description = "The WAsP software suite is the industry-standard for wind resource assessment, siting and energy yield calculation for wind turbines and wind farms. The WAsP software suite is used for sites located in all kinds of terrain all over the world.",
                Year = 2022,
                Proj_hyperlink = "/Home/Skills",
                Image_loc = "/Images/WASP_project.jpg",
                Path= "/Projects/WAsP"

            };

            var Matlab_project = new Projects
            {
                Id = 6,
                Name = "EV battery simulation",
                Worked_for = "Politecnico di Torino",
                Lan_or_tool = "MATLAB and Simulink",
                Description = "Simulation of battery charge and discharge in an electric vehicle",
                Year = 2021,
                Proj_hyperlink = "/Home/Skills",
                Image_loc = "/Images/EV_project.jpg",
                Path = "/Projects/Matlab"

            };

            var project2 = new Projects
            {
                Id = 7,
                Name = "Excel Merger",
                Worked_for = "C.V.A.s.p.a",
                Lan_or_tool = "Python",
                Description = "Python tool to merge different Excel files",
                Year = 2022,
                Proj_hyperlink = "/Home/Skills",
                Image_loc = "/Images/Excel_merger.jpg",
                Path = "/Projects/Excel_merger"


            };


            var listProjects = new List<Projects>() { project1, catia_project, project2, project3, Pvsyst_project, WASP_project, Matlab_project  };

            return listProjects;
        }
    }
}