//using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
//using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
//{
//    internal class StudentService
//    {
//        private readonly StudentDao _studentDao = new StudentDao();

//        public string SaveStudent(Student student)
//        {
//            if (student == null) return "Student data is empty.";
//            if (string.IsNullOrWhiteSpace(student.FirstName)) return "First Name is required.";
//            if (string.IsNullOrWhiteSpace(student.LastName)) return "Last Name is required.";
//            if (student.DateOfBirth > DateTime.Now.AddYears(-3)) return "Invalid Date of Birth.";

//            bool success = _studentDao.AddStudent(student);
//            return success ? "Student registered successfully." : "Failed to register student.";
//        }

//        public string UpdateStudentInfo(Student student)
//        {
//            if (student.StudentId <= 0) return "Invalid Student ID.";

//            bool success = _studentDao.UpdateStudent(student);
//            return success ? "Student record updated." : "Update failed.";
//        }

//        public string RemoveStudent(Student student)
//        {
//            if (student == null) return "No student selected.";
//            return _studentDao.DeleteStudent(student.StudentId) ? "Student deleted." : "Delete failed.";
//        }

//        public List<Student> GetStudents()
//        {
//            return _studentDao.GetAllStudent();
//        }

//        public Student GetDetails(int id)
//        {
//            if (id <= 0) return null;
//            return _studentDao.GetStudentById(id);
//        }

//        public Student GetStudentByUserId(int userId)
//        {
//            if (userId <= 0) return null;

//            // We use LINQ to find the student that matches the logged-in UserID
//            return _studentDao.GetAllStudent().FirstOrDefault(s => s.UserId == userId);
//        }

//        public List<dynamic> GetViolationLogs()
//        {
//            return _studentDao.GetAllViolations();
//        }

//        public DataTable GetDebtRecords(int studentId, string searchKeyword = "")
//        {
//            if (studentId <= 0) return new DataTable();
//            return _studentDao.GetStudentDebts(studentId, searchKeyword);
//        }
//    }
//}

using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class StudentService
    {
        private readonly StudentDao _studentDao = new StudentDao();

        public string SaveStudent(Student student)
        {
            if (student == null) return "Student data is empty.";
            if (string.IsNullOrWhiteSpace(student.FirstName)) return "First Name is required.";
            if (string.IsNullOrWhiteSpace(student.LastName)) return "Last Name is required.";
            if (student.DateOfBirth > DateTime.Now.AddYears(-3)) return "Invalid Date of Birth.";

            bool success = _studentDao.AddStudent(student);
            return success ? "Student registered successfully." : "Failed to register student.";
        }

        public string UpdateStudentInfo(Student student)
        {
            if (student.StudentId <= 0) return "Invalid Student ID.";

            bool success = _studentDao.UpdateStudent(student);
            return success ? "Student record updated." : "Update failed.";
        }

        public string RemoveStudent(Student student)
        {
            if (student == null) return "No student selected.";
            return _studentDao.DeleteStudent(student.StudentId) ? "Student deleted." : "Delete failed.";
        }

        public List<Student> GetStudents()
        {
            return _studentDao.GetAllStudent();
        }

        public Student GetDetails(int id)
        {
            if (id <= 0) return null;
            return _studentDao.GetStudentById(id);
        }

        public Student GetStudentByUserId(int userId)
        {
            if (userId <= 0) return null;
            return _studentDao.GetAllStudent().FirstOrDefault(s => s.UserId == userId);
        }

        public List<dynamic> GetViolationLogs()
        {
            return _studentDao.GetAllViolations();
        }

        public DataTable GetDebtRecords(int studentId, string searchKeyword = "")
        {
            if (studentId <= 0) return new DataTable();
            return _studentDao.GetStudentDebts(studentId, searchKeyword);
        }

        public DataTable GetPaymentHistoryRecords(int studentId, string searchKeyword = "")
        {
            if (studentId <= 0) return new DataTable();
            return _studentDao.GetStudentPaymentHistory(studentId, searchKeyword);
        }

        public DataTable GetPublicExpenseTransparency()
        {
            return _studentDao.GetExpenseTransparencyLog();
        }
    }
}