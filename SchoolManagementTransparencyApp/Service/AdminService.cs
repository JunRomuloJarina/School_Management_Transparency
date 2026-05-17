using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class AdminService
    {
        private readonly AdminDao _adminDao = new AdminDao();

        public DataTable GetFinancialReportData()
        {
            return _adminDao.GetOverallFinancialSummary();
        }

        public DataTable GetTopViolatorsData()
        {
            // Make sure to call the instance of the DAO where you placed the method above
            return _adminDao.GetTopViolatorsReport();
        }
    }
}
