using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFCManager.Models
{
    public class DFCModel
    {
        private String Num { get; set; }
        private String NumDFC { get; set; }
        private String Famille { get; set; }
        private String Phase { get; set; }
        private String Fi { get; set; }
        private String Description { get; set; }
        private DateTime DateReception { get; set; }
        private DateTime DateReponse { get; set; }
        private Boolean Faisable { get; set; }
        private String Type { get; set; }
    }
}