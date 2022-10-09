using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BlackLotusClientApp.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        //Load Data
        public void LoadData()
        {
            string uri = "https://localhost:44372/api/category";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvCategory.DataSource = (new JavaScriptSerializer().Deserialize<List<Category>>(json));

        }

        //Set data to textboxes from dgv onclick
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                txtCategorId.Text = row.Cells[0].Value.ToString();
                txtCategoryName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();

            }
        }


        //Load dgv ON FormLoading
        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //Add New Category
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUri = "https://localhost:44372/api/category";
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                Category getCategory = new Category();
                getCategory.categoryName = txtCategoryName.Text;
                getCategory.categoryDescription = txtDescription.Text;
                String info = (new JavaScriptSerializer()).Serialize(getCategory);
                string up = client.UploadString(apiUri, info);
                MessageBox.Show("Successfully Added.!");
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Please try again.");
            }

        }
        //Update Category
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44372/api/category/"+txtCategorId.Text;
            HttpClient client = new HttpClient();
            Category updateCategory = new Category();
            updateCategory.categoryName = txtCategoryName.Text;
            updateCategory.categoryDescription = txtDescription.Text;
            updateCategory.categoryId = Convert.ToInt32(txtCategorId.Text);

            string Info = (new JavaScriptSerializer()).Serialize(updateCategory);
            var stringContetnt = new StringContent(Info, UnicodeEncoding.UTF8, "application/json");
            var response = client.PutAsync(uri, stringContetnt);

            response.Wait();

            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                MessageBox.Show("Successfull Updated");
                LoadData();
            }
            else
                MessageBox.Show("Fail to Update");

        }

        //Delete Category
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }

    //Object
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
    }
}
