using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public class ThuVien
    {

        public void FuncLoadButton(ListView lvCategory) 
        {
            string connectString = "server=.; database= RestaurantManagement; Integrated Security= true;";
            
            SqlConnection sqlConnection = new SqlConnection(connectString);

            SqlCommand sqlCommand= sqlConnection.CreateCommand();

            string query = "SELECT ID, Name,  Type FROM Category";
            sqlCommand.CommandText = query;

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            this.DisplayCategory(sqlDataReader, lvCategory);
        }

        private void DisplayCategory(SqlDataReader reader, ListView lvCategory)
        {
            lvCategory.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                lvCategory.Items.Add(item);

                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        public void FuncAddButton()
        {

        }


    }
}
