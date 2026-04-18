using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class EnrollmentService
    {
        private readonly EnrollmentDao _enrollmentDao = new EnrollmentDao();

        public string ValidateAddEnrollment(Enrollment enrollment)
        {
            if (enrollment == null) return "Enrollment data is missing.";
            if (enrollment.StudentId <= 0) return "Please select a valid student.";
            if (enrollment.CourseId <= 0) return "Please select a valid course.";

            // Speed-typing tip: Check for duplicates here or handle the MySQL unique constraint exception
            if (_enrollmentDao.AddEnrollment(enrollment))
            {
                return "Successfully enrolled student.";
            }

            return "Failed to enroll. Student might already be in this course.";
        }

        public string ValidateDeleteEnrollment(Enrollment enrollment)
        {
            if (enrollment == null || enrollment.EnrollmentId <= 0)
                return "Invalid enrollment record.";

            return _enrollmentDao.DeleteEnrollment(enrollment)
                ? "Enrollment removed."
                : "Error removing enrollment.";
        }

        public List<Enrollment> GetAll() => _enrollmentDao.GetAllEnrollments();
    }
}
