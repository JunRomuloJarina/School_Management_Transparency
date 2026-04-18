using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Model
{
    internal class TransactionType
    {
        public int TransactionTypeId { get; set; }
        public string TypeName { get; set; }

        // 1. Default Constructor
        public TransactionType()
        {
        }

        // 2. Parameterized Constructor
        public TransactionType(int transactionTypeId, string typeName)
        {
            TransactionTypeId = transactionTypeId;
            TypeName = typeName;
        }

        // 3. ToString Method
        public override string ToString()
        {
            return $"Transaction Type ID: {TransactionTypeId} | Name: {TypeName}";
        }
    }
}
