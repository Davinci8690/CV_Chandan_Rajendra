using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Chandan_Rajendra.Models;

namespace CV_Chandan_Rajendra.Controllers
{
    public class CatiaController : Controller
    {
        // GET: Catia
        public ActionResult Index()
        {
            return View();
        }

        public static List<Catia_projects> list_catia_Projects()
        {
            var project1 = new Catia_projects
            {
                Id = 7,
                Name = "Part 1",
                Description = "Shell, Mirror, Edge fillet, Pocket",
                Image_loc = "/Images/Catia_projects/3D/part1.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Part1_2D.jpg"


            };

            var project2 = new Catia_projects
            {
                Id = 9,
                Name = "Part 2",
                Description = "Groove, Pocket, Edge fillet",
                Image_loc = "/Images/Catia_projects/3D/part4.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Part4_2D.jpg"
            };

            var Curved_handle = new Catia_projects
            {
                Id = 4,
                Name = "Curved handle",
                Description = "Intersect, Extract, Close surface, Multi Section surface",
                Image_loc = "/Images/Catia_projects/3D/curved_handle.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Curved_handle_2D.jpg"
            };

            var Piston_head = new Catia_projects
            {
                Id = 8,
                Name = "Piston head",
                Description = "Slot, Pocket, Hole, Circular Pattern, Chamfer",
                Image_loc = "/Images/Catia_projects/3D/Piston_head.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Piston_head_2D.jpg"
            };

            var Handle = new Catia_projects
            {
                Id = 6,
                Name = "Handle",
                Description = "Translate, Extrude, Intersect, Extract, Multi section surface, Join",
                Image_loc = "/Images/Catia_projects/3D/Handle.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Handle_2D.jpg"
            };

            var Fire_Ex_handle = new Catia_projects
            {
                Id = 3,
                Name = "Fire Extinguisher Handle",
                Description = "Fill, Symmetry, Join, Thick surface, Rib",
                Image_loc = "/Images/Catia_projects/3D/Fire_EX_handle.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Fire_extinguisher_handle_2D.jpg"
            };

            var Twin_pipe = new Catia_projects
            {
                Id = 2,
                Name = "Twin Pipe",
                Description = "Sweep, Combine, Thick surface, Symmetry, Trim, Pocket",
                Image_loc = "/Images/Catia_projects/3D/Twin_pipe.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Twin_pipe_2D.jpg"
            };

            var Twisted_bar = new Catia_projects
            {
                Id = 5,
                Name = "Twisted Bar",
                Description = "Multi section surface, Spline, Edge fillet, Pocket",
                Image_loc = "/Images/Catia_projects/3D/Twisted_bar.jpg",
                img_loc2d = "/Images/Catia_projects/2D/Twisted_bar_2D.jpg"
            };

            var Von_misses = new Catia_projects
            {
                Id = 1,
                Name = "Von misses stress analysis and Deformation",
                Description = "Applying restraints, Loads and " +
                "Calucation of Deformation and stress analysis",
                Image_loc = "/Images/Catia_projects/3D/Von_misses_Stress_analysis.jpg",
                img_loc2d = "/Images/Catia_projects/3D/deformation.jpg"


            };
            





            var list_catia_Projects = new List<Catia_projects>() { Von_misses,Twin_pipe, Fire_Ex_handle, Curved_handle,Twisted_bar, Handle,project1, Piston_head,project2 };

            return list_catia_Projects;
        }
    }
}