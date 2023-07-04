using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV_Chandan_Rajendra.Models
{
    public class Home
    {
    }

    public class Skills
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skill_hyperlink { get; set; }
        public int Experience { get; set; }
        public string Training_place { get; set; }
        public string TP_hyplnk { get; set; }
        public string Level { get; set; }

        public int No_of_projects { get; set; }
        public string Image_loc { get; set; }
    }

    public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lan_or_tool { get; set; }
        public string Worked_for { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Path { get; set; }

        public string Proj_hyperlink { get; set; }
        public string Image_loc { get; set; }

    }

    public class Work
    {
        public int Id { get; set; }
        public string Company { get; set; }

        public string Company_link { get; set; }

        public double Experience { get; set; }

        public int Projects { get; set; }
        public List<string> list_skills { get; set; }

        public string Place { get; set; }

        public int Year { get; set; }
        public string Job_pos { get; set; }

        public string logo { get; set; }
        public string Description { get; set; }
    }

    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Course { get; set; }  
        public int Year { get; set; }   
        public string Address { get; set; }
        public string college_link { get; set; }

        public string logo { get; set; }

    }

    public class Catia_projects
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public string Image_loc { get; set; }

        public string Description { get; set; }

        public string img_loc2d { get; set; }


    }

}