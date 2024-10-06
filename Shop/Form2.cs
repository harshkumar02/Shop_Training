using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("integrated Security=true; Server=(localdb)\\localDB1; database = shop");
        SqlDataAdapter adapter;
        int catid;
        int f = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT vDescription, iCatID FROM Category", conn);
            DataSet dsCategory = new DataSet();
            adapter.Fill(dsCategory, "Category");

            
            comboBoxCategory.DataSource = dsCategory.Tables[0];
            comboBoxCategory.DisplayMember = "vDescription";  
            comboBoxCategory.ValueMember = "iCatID";

            f = 1;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (f == 1)
            {
                catid = Convert.ToInt32(comboBoxCategory.SelectedValue);

                if (catid == 1)
                {
                    adapter = new SqlDataAdapter($"select * from Product ", conn);

                }

                else
                {
                    adapter = new SqlDataAdapter($"select * from Product where iCatID={catid}", conn);

                }


                DataSet dsproduct = new DataSet();
                adapter.Fill(dsproduct, "prod");
                dgvDisplay.DataSource = dsproduct;
                dgvDisplay.DataMember = "prod";

            }


        }
    }
}
