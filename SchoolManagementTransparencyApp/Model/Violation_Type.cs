using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Violation_Type
    {

        public int ViolationTypeId { get; set; }
        public string ViolationName { get; set; }
        public decimal Fee { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        // 1. Default Constructor
        public Violation_Type()
        {
        }

        // 2. Parameterized Constructor
        public Violation_Type(int violationTypeId, string violationName, decimal fee, string category, string description)
        {
            ViolationTypeId = violationTypeId;
            ViolationName = violationName;
            Fee = fee;
            Category = category;
            Description = description;
        }

        // 3. ToString Method
        public override string ToString()
        {
            return $"[{Category}] {ViolationName} - Fee: {Fee:C} | {Description}";
        }
    }
}
