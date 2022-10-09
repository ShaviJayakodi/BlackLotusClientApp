using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BlackLotusClientApp.Forms
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }
        //Data Loa
        public void LoadData()
        {
            string uri = "https://localhost:44372/api/stock";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvStock.DataSource = (new JavaScriptSerializer().Deserialize<List<Stock>>(json));
        }

        //set to dgv data From API 
        private void FormStock_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        //Set Data to textBoxes from onclick dgvRow
        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStock.Rows[e.RowIndex];
                txtStockID.Text = row.Cells[0].Value.ToString();
                txtStockName.Text = row.Cells[1].Value.ToString();
                txtQuentity.Text = row.Cells[2].Value.ToString();
                txtFlowerID.Text = row.Cells[3].Value.ToString();
            }
        }
        //Add New Stock
        private void btdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                stock.FlowerId = Convert.ToInt32(txtFlowerID.Text);
                stock.quientity = Convert.ToInt32(txtQuentity.Text);
                stock.stockName = txtStockName.Text;
                string apiUri = "https://localhost:44372/api/stock/flower/" + txtFlowerID.Text + "/stock";
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                String info = (new JavaScriptSerializer()).Serialize(stock);
                string up = client.UploadString(apiUri, info);
                MessageBox.Show("SuccessFully Added");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please try again.");
            }
        }
        //Refrsh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //Stock Delete
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var Response = await Delete(txtStockID.Text);
            LoadData();

        }
        public static async Task<string> Delete(String stockId)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44372/api/stock/" + stockId))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show("Successfully Deleted");

                        string data = await content.ReadAsStringAsync();


                        if (data != null)
                        {
                            return data;
                        }
                    }


                }
            }

            return string.Empty;
        }


        //Stock Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44372/api/stock/flower/"+txtFlowerID.Text+"/stock/"+txtStockID.Text;
            HttpClient client = new HttpClient();
            Stock getStock = new Stock();
            getStock.stockName = txtStockName.Text;
            getStock.stockId = Convert.ToInt32(txtStockID.Text);
            getStock.FlowerId = Convert.ToInt32(txtFlowerID.Text);
            getStock.quientity = Convert.ToInt32(txtQuentity.Text);

            String info = (new JavaScriptSerializer()).Serialize(getStock);
            var stringContent = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
            var response = client.PutAsync(uri, stringContent);

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



        
        


    }
    //Stock object
    public class Stock
        {

            public int stockId { get; set; }
            public string stockName { get; set; }
            public int quientity { get; set; }
            public int FlowerId { get; set; }

        }
}
