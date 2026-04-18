using MySql.Data.MySqlClient;
using School_Management_Transparency.SchoolManagementTransparencyApp.Model;
using School_Management_Transparency.SchoolManagementTransparencyApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Dao
{
    internal class TransactionTypeDao
    {

        DatabaseConnection dbConn = new DatabaseConnection();

        public bool AddTransactionType(TransactionType type)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO transaction_type (type_name) VALUES (@TypeName)",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@TypeName", type.TypeName);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool UpdateTransactionType(TransactionType type)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE transaction_type SET type_name=@TypeName WHERE transaction_type_id=@TransactionTypeId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@TypeName", type.TypeName);
                command.Parameters.AddWithValue("@TransactionTypeId", type.TransactionTypeId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public bool DeleteTransactionType(int typeId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM transaction_type WHERE transaction_type_id=@TransactionTypeId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@TransactionTypeId", typeId);

                dbConn.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return false;
        }

        public List<TransactionType> GetAllTransactionTypes()
        {
            List<TransactionType> typeList = new List<TransactionType>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM transaction_type", dbConn.getconnection);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransactionType type = new TransactionType
                        {
                            TransactionTypeId = Convert.ToInt32(reader["transaction_type_id"]),
                            TypeName = reader["type_name"].ToString()
                        };
                        typeList.Add(type);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return typeList;
        }

        public TransactionType GetTransactionTypeById(int transaction_type_id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM transaction_type WHERE id = @TransactionTypeId",
                    dbConn.getconnection);

                command.Parameters.AddWithValue("@TransactionTypeId", transaction_type_id);

                dbConn.openConnect();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TransactionType type = new TransactionType
                        {
                            TransactionTypeId = Convert.ToInt32(reader["transaction_type_id"]),
                            TypeName = reader["type_name"].ToString()
                        };

                        return type;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.closeConnect();
            }
            return null;
        }

    }
}
