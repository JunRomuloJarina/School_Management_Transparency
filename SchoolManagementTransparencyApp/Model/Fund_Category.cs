using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class Fund_Category
    {

        public int FundId { get; set; }
        public string FundName { get; set; }

        // 1. Default Constructor
        public Fund_Category()
        {
        }

        // 2. Parameterized Constructor (for attributes)
        public Fund_Category(int fundId, string fundName)
        {
            FundId = fundId;
            FundName = fundName;
        }

        // 3. ToString Method
        public override string ToString()
        {
            return $"Fund ID: {FundId}, Fund Name: {FundName}";
        }
    }
}
