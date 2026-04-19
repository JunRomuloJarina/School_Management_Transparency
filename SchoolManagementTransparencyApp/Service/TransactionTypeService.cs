using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class TransactionTypeService
    {
        Here is the TransactionTypeService implementation.This service provides the business logic for managing the classification of money(Income vs. Expense), which is the foundation of your system's "Transparency" logic.

1. TransactionTypeService Implementation
C#
using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
    {
        internal class TransactionTypeService
        {
            private readonly TransactionTypeDao _typeDao = new TransactionTypeDao();

            public List<TransactionType> GetAllTypes()
            {
                return _typeDao.GetAllTransactionTypes();
            }

            public TransactionType GetTypeById(int id)
            {
                if (id <= 0) return null;
                return _typeDao.GetTransactionTypeById(id);
            }

            public string CreateType(TransactionType type)
            {
                if (type == null) return "Type data is missing.";
                if (string.IsNullOrWhiteSpace(type.TypeName)) return "Transaction type name is required.";

                // Standardizing to uppercase (e.g., INCOME, EXPENSE)
                type.TypeName = type.TypeName.Trim().ToUpper();

                return _typeDao.AddTransactionType(type)
                    ? "Transaction Type added successfully."
                    : "Failed to add type.";
            }

            public string UpdateType(TransactionType type)
            {
                if (type == null || type.TransactionTypeId <= 0) return "Invalid selection.";
                if (string.IsNullOrWhiteSpace(type.TypeName)) return "Name cannot be empty.";

                type.TypeName = type.TypeName.Trim().ToUpper();

                return _typeDao.UpdateTransactionType(type)
                    ? "Transaction Type updated."
                    : "Update failed.";
            }

            public string RemoveType(int id)
            {
                if (id <= 0) return "Select a valid type to delete.";

                // NOTE: Usually, you shouldn't delete 'INCOME' or 'EXPENSE' 
                // if transactions already exist, as it will break the ledger.
                return _typeDao.DeleteTransactionType(id)
                    ? "Transaction Type deleted."
                    : "Delete failed. Check if this type is still being used by transactions.";
            }
        }
}
