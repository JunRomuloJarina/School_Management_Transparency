using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class ViolationTypeService
    {

        private readonly ViolationTypeDao _violationDao = new ViolationTypeDao();

        public string CreateViolationType(ViolationType violation)
        {
            if (violation == null) return "Violation data is missing.";
            if (string.IsNullOrWhiteSpace(violation.ViolationName)) return "Violation name is required.";
            if (violation.Fee < 0) return "Fee cannot be a negative amount.";

            bool success = _violationDao.AddViolationType(violation);
            return success ? "Violation Type added successfully." : "Failed to save to database.";
        }

        public string UpdateViolationType(ViolationType violation)
        {
            if (violation == null || violation.ViolationTypeId <= 0) return "Invalid selection.";
            if (violation.Fee < 0) return "Fee cannot be negative.";

            return _violationDao.UpdateViolationType(violation) ? "Update successful." : "Update failed.";
        }

        public string DeleteViolationType(int id)
        {
            if (id <= 0) return "Invalid violation type ID.";

            // Check if this violation is currently being used in student_violation table 
            // is usually handled by foreign key constraints in your SQL.
            return _violationDao.DeleteViolationType(id) ? "Violation Type removed." : "Delete failed.";
        }

        public List<ViolationType> GetList()
        {
            return _violationDao.GetAllViolationTypes();
        }

        public ViolationType GetDetails(int id)
        {
            if (id <= 0) return null;
            return _violationDao.GetViolationTypeById(id);
        }
    }
}
