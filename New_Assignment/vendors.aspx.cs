using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace New_Assignment
{
    public partial class vendors : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridDataShow();
        }
        void GridDataShow()
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand("select * from Vendor", connect);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if (dr.HasRows == true)
                {
                    //GridVendor.DataSource = dr;
                    //GridVendor.DataBind();
                }
            }
        }
        void City()
        {
            using (SqlConnection Connect = new SqlConnection(con))
            {
                Connect.Open();
                SqlCommand command2 = new SqlCommand("select City from CityName", Connect);
                SqlDataReader reader1 = command2.ExecuteReader();
                while (reader1.Read())
                {
                    //this.DropDownList1.Items.Add(reader1["CityName"].ToString());
                }
                reader1.Close();
            }
        }
    }
}