using School_Management_Transparency.SchoolManagementTransparencyApp.Dao;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Service
{
    internal class FundCategoryService
    {

        private readonly FundCategoryDao _fundDao = new FundCategoryDao();

        public string ValidateAndAdd(FundCategory fund)
        {
            if (fund == null) return "Fund data is missing.";
            if (string.IsNullOrWhiteSpace(fund.FundName)) return "Fund name cannot be empty.";
            if (fund.FundName.Length < 3) return "Fund name is too short (minimum 3 characters).";

            return _fundDao.AddFundCategory(fund) ? "Fund Category Added Successfully!" : "Failed to save Fund Category.";
        }

        public string ValidateAndUpdate(FundCategory fund)
        {
            if (fund == null || fund.FundId <= 0) return "Invalid Fund selected.";
            if (string.IsNullOrWhiteSpace(fund.FundName)) return "Fund name cannot be empty.";

            return _fundDao.UpdateFundCategory(fund) ? "Fund Category Updated!" : "Update failed.";
        }

        public string ValidateAndDelete(FundCategory fund)
        {
            if (fund == null || fund.FundId <= 0) return "Select a fund to delete.";
            // before deleting to prevent orphaned financial records.
            return _fundDao.DeleteFundCategory(fund) ? "Fund Category Removed." : "Delete failed.";
        }

        public List<FundCategory> GetList() => _fundDao.GetAllFundCategories();
    }
}
