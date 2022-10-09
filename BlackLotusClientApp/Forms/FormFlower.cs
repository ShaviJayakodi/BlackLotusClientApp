using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Net.Http;
using System.Xml.Linq;

namespace BlackLotusClientApp.Forms
{
    public partial class FormFlower : Form
    {
        public FormFlower()
        {
            InitializeComponent();
       
       
        }

        private void LoadTheame()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = TheamColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = TheamColor.SecondaryColor;
                }
            }
        }
        //Refresh
        public  void LoadData()
        {
            string uri = "https://localhost:44372/api/flower";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvFlower.DataSource = (new JavaScriptSerializer().Deserialize<List<Flower>>(json));

        }

        //set data to dgv from API
        public void FormFlower_Load(object sender, EventArgs e)
        {
            string uri = "https://localhost:44372/api/flower";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvFlower.DataSource = (new JavaScriptSerializer().Deserialize<List<Flower>>(json));
            
        }
        //Add new Flower
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUri = "https://localhost:44372/api/flower";
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                Flower flower = new Flower();
                flower.flowerName = txtFlowerName.Text;
                flower.description = txtFlowerDescription.Text;
                flower.price = Convert.ToDecimal(txtPrice.Text);
                flower.status = 1;
                flower.categoryId = Convert.ToInt32(txtCategory.Text);
                String info = (new JavaScriptSerializer()).Serialize(flower);
                string up = client.UploadString(apiUri, info);
                MessageBox.Show("SuccessFully Added");
                LoadData();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        //Find By Id
        private void btnGet_Click(object sender, EventArgs e)
        {
            

            
            try
            {
                int flowerId = Convert.ToInt32(txtFlowerID.Text);
                string apiUri = "https://localhost:44372/api/flower/" + flowerId;
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                String json = client.DownloadString(apiUri);
                MessageBox.Show(json);

            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }
        //set data to text boxes onclick dgv row
        private void dgvFlower_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row  =this.dgvFlower.Rows[e.RowIndex];
                txtFlowerID.Text = row.Cells[0].Value.ToString();
                txtFlowerName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtCategory.Text = row.Cells[3].Value.ToString();
            }
        }
        //Flower Delete
        private async void button3_Click(object sender, EventArgs e)
        {
            var Response = await Delete(txtFlowerID.Text);
        }
        public static async Task<string> Delete(String id)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44372/api/flower/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show("Deleted");

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

        private void btnReFress_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //Flower Update
        private void button2_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44372/api/flower/" + txtFlowerID.Text;
            HttpClient client = new HttpClient();
            Flower getFlower = new Flower();
            getFlower.flowerName = txtFlowerName.Text;
            getFlower.status = 1;
            getFlower.price = Convert.ToDecimal(txtPrice.Text);
            getFlower.flowerId = Convert.ToInt32(txtFlowerID);
            getFlower.description = txtFlowerDescription.Text;

            String info = (new JavaScriptSerializer()).Serialize(getFlower);
            var stringContent = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
            var response = client.PutAsync(uri, stringContent);

            response.Wait();

            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {

                LoadData();
            }
            else
                MessageBox.Show("Fail to Update");
        }
    }
    //Flower Object
    public class Flower
    {
        public int flowerId { get; set; }
        public string flowerName { get; set; }
        public Decimal price { get; set; }
        //public int stock { get; set; }
        public int categoryId { get; set; }
        public string description { get; set; }
        public int status { get; set; }

    }
}
