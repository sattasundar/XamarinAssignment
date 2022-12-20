using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeKTech.Models
{
    public class Patient
    {
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public int IsChecked { get; set; }
    }
}
