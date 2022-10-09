using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BlackLotusClientApp.Forms
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        //Load Data
        public void LoadData()
        {
            string uri = "https://localhost:44372/api/Orders";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvOrder.DataSource = (new JavaScriptSerializer().Deserialize<List<Orders>>(json));
            
        }
        //SetData to Text boxes onclick data grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrder.Rows[e.RowIndex];
                txtOrderID.Text = row.Cells[0].Value.ToString();
                txtCustomerName.Text = row.Cells[1].Value.ToString();
                txtCustomerPhone.Text = row.Cells[2].Value.ToString();
                txtPlace.Text = row.Cells[4].Value.ToString();


            }
        }
        //Load form
        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Add new Order
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string apiUri = "https://localhost:44372/api/Orders";
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                Orders getOrder = new Orders();
                getOrder.customerName = txtCustomerName.Text;
                getOrder.customerPhone=txtCustomerPhone.Text; 
                getOrder.place = txtPlace.Text;
                getOrder.dilevaryDate = dtpDeliveryDate.Value.Date.ToString("O");
                String info = (new JavaScriptSerializer()).Serialize(getOrder);
                string up = client.UploadString(apiUri, info);
                MessageBox.Show("Successfully Added.!");
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Please try again");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            /*https://localhost:44372/api/Orders/1004*/
            string uri = "https://localhost:44372/api/Orders/" + txtOrderID.Text;
            HttpClient client = new HttpClient();
            Orders updateOrder = new Orders();
            updateOrder.orderId = Convert.ToInt32(txtOrderID.Text);
            updateOrder.customerName = txtCustomerName.Text;
            updateOrder.customerPhone = txtCustomerPhone.Text;
            updateOrder.place = txtPlace.Text;
            updateOrder.dilevaryDate=dtpDeliveryDate.Value.Date.ToString("O");
            string Info = (new JavaScriptSerializer()).Serialize(updateOrder);
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
        //Delete  Order
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var Response = await Delete(txtOrderID.Text);
            LoadData();
        }
        public static async Task<string> Delete(String orderId)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44372/api/Orders/" + orderId))
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
    }
    public class Orders
    {
        public int orderId { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string dilevaryDate { get; set; }
        public string place { get; set; }
    }
}
