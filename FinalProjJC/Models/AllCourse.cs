using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjJC.Models
{
    public class AllCourse
    {

        public string CourseNum { get; set; }
        public string CourseName { get; set; }

        public string PB_40 { get; set; }
        public string ME_40 { get; set; }
        public string CO_40 { get; set; }
        public string TI_40 { get; set; }
        public string EL_40 { get; set; }

        public string PB_10 { get; set; }
        public string ME_10 { get; set; }
        public string CO_10 { get; set; }
        public string TI_10 { get; set; }
        public string EL_10 { get; set; }

        public string PB_20 { get; set; }
        public string ME_20 { get; set; }
        public string CO_20 { get; set; }
        public string TI_20 { get; set; }
        public string EL_20 { get; set; }

    }
}
