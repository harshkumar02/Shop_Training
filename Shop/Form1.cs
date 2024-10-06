using Microsoft.Data.SqlClient;
using System.Data;
namespace Shop
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("integrated Security=true; Server=(localdb)\\localDB1; database = shop");
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from product", conn);
            DataSet dsProduct = new DataSet();
            adapter.Fill(dsProduct, "Prod");
            dgvProd.DataSource = dsProduct;
            dgvProd.DataMember = "Prod";


        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

       
    }
}
