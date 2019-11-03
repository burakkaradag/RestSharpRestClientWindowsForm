using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getproduct();
            cmbboxsehir.DataSource = getcity();
            cmbboxsehir.DisplayMember = "sehirAd";
            cmbboxsehir.ValueMember = "sehirId";

            
         
        }
        

        public List<Product> getproduct()
        {
            var client = new RestClient("http://localhost:1618/");
            var request = new RestRequest("personel/liste", Method.GET);
            var response = client.Execute<List<Product>>(request);
            return response.Data;
        }

        public List<Product> getcity()
        {
            var client = new RestClient("http://localhost:1618/");
            var request = new RestRequest("sehir/liste", Method.GET);
            var response = client.Execute<List<Product>>(request);
            return response.Data;
        }

        public void ProductCreat(Product product)
        {
            var client = new RestClient("http://localhost:1618/");
            var request = new RestRequest("personel/Ekle", Method.POST);
            request.AddJsonBody(product);
            client.Execute(request);
        }

        public void ProductUpdate(Product product)
        {
            var client = new RestClient("http://localhost:1618/");
            var request = new RestRequest("personel/Guncel", Method.POST);
            request.AddJsonBody(product);
            client.Execute(request);
        }

        public void ProductDelete(int id)
        {
            var client = new RestClient("http://localhost:1618/");
            var request = new RestRequest("personel/Sil/"+id, Method.DELETE);
            client.Execute(request);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int personelId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string personelAd = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string personelSoyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int sehirAd = (int)dataGridView1.CurrentRow.Cells[4].Value;
            txtboxıd.Text = personelId.ToString();
            txtboxad.Text = personelAd;
            txtboxsoyad.Text = personelSoyad;
            cmbboxsehir.SelectedValue = sehirAd;
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            var product = new Product();
            product.personelAd = txtboxad.Text;
            product.personelSoyad = txtboxsoyad.Text;
            product.sehirAd = cmbboxsehir.SelectedValue.ToString();
            product.sehirId = cmbboxsehir.SelectedIndex;

            ProductCreat(product);

            Form1_Load(null, null);
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.personelId = Convert.ToInt32(txtboxıd.Text);
            product.personelAd = txtboxad.Text;
            product.personelSoyad = txtboxsoyad.Text;
            product.sehirId = Convert.ToInt32(cmbboxsehir.SelectedValue);

            ProductUpdate(product);

            Form1_Load(null, null);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ProductDelete(Convert.ToInt32( txtboxıd.Text));
            Form1_Load(null, null);

        }
    }
}       
