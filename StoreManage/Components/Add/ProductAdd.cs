using StoreManage.DTOs.TargetCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StoreManage.Components.Add
{
    public partial class ProductAdd : UserControl
    {
        public ProductAdd()
        {
            InitializeComponent();
            LoadTargetCustomers();
        }

        private async void LoadTargetCustomers()
        {
            try
            {
                string apiUrl = "http://localhost:5254/api/targetCustomers";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var targetCustomers = JsonSerializer.Deserialize<List<TargetCustomerDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    

                    cBTargetCustomer.DataSource = targetCustomers;
                    cBTargetCustomer.DisplayMember = "TargetCustomerName"; 
                    cBTargetCustomer.ValueMember = "TargetCustomerId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng mục tiêu: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
