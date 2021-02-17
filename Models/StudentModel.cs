using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoManager_Blazor.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
