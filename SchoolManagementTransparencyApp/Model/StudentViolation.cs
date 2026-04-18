using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class StudentViolation
    {
        public int StudentViolationId { get; set; }
        public int StudentId { get; set; }
        public int ViolationTypeId { get; set; }
        public DateTime DateIssued { get; set; }
        public string Status { get; set; }

        // 1. Default Constructor
        public StudentViolation()
        {
        }

        // 2. Parameterized Constructor
        public StudentViolation(int studentViolationId, int studentId, int violationTypeId, DateTime dateIssued, string status)
        {
            StudentViolationId = studentViolationId;
            StudentId = studentId;
            ViolationTypeId = violationTypeId;
            DateIssued = dateIssued;
            Status = status;
        }

        // 3. ToString Method
        public override string ToString()
        {
            return $"Violation ID: {StudentViolationId} | Student ID: {StudentId} | Type: {ViolationTypeId} | Date: {DateIssued:yyyy-MM-dd} | Status: {Status}";
        }
    }
}
