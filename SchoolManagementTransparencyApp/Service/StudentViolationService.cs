using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class StudentViolationService
    {

        private readonly StudentViolationDao _violationDao = new StudentViolationDao();

        public string RecordViolation(StudentViolation violation)
        {
            if (violation == null) return "Violation data is missing.";
            if (violation.StudentId <= 0) return "Please select a valid student.";
            if (violation.ViolationTypeId <= 0) return "Please select a violation type.";

            // Set default date if none provided
            if (violation.DateIssued == DateTime.MinValue)
                violation.DateIssued = DateTime.Now;

            // Ensure status starts as UNPAID
            if (string.IsNullOrEmpty(violation.Status))
                violation.Status = "UNPAID";

            bool success = _violationDao.AddStudentViolation(violation);
            return success ? "Violation successfully recorded." : "Database error: Could not save violation.";
        }

        public string UpdateViolation(StudentViolation violation)
        {
            if (violation.StudentViolationId <= 0) return "Invalid ID.";
            return _violationDao.UpdateStudentViolation(violation) ? "Updated successfully." : "Update failed.";
        }

        public string DeleteViolation(int id)
        {
            if (id <= 0) return "Invalid ID.";
            return _violationDao.DeleteStudentViolation(id) ? "Violation deleted." : "Delete failed.";
        }

        public List<StudentViolation> GetAll() => _violationDao.GetAllStudentViolationsNormal();

        // Used for the "Collect Payment" screen
        public List<StudentViolation> GetUnpaidViolations()
        {
            return _violationDao.GetAllStudentViolationsNormal().FindAll(v => v.Status == "UNPAID");
        }

        public List<StudentViolation> GetPaidViolations()
        {
            return _violationDao.GetAllStudentViolationsNormal().FindAll(v => v.Status == "PAID");
        }
    }
}
