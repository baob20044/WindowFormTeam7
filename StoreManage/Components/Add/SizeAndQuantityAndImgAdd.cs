using StoreManage.DTOs.Size;
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

namespace StoreManage.Components.Add
{
    public partial class SizeAndQuantityAndImgAdd : UserControl
    {
        public SizeAndQuantityAndImgAdd()
        {
            InitializeComponent();
            LoadSizes();
        }
        private async void LoadSizes()
        {
            try
            {
                string apiUrl = "http://localhost:5254/api/sizes";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var sizes = JsonSerializer.Deserialize<List<SizeDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (sizes != null && sizes.Count > 0)
                    {
                        // Gán dữ liệu vào ComboBox
                        cbSize.DataSource = sizes;
                        cbSize.DisplayMember = "SizeValue"; 
                        cbSize.ValueMember = "SizeId";     
                    }
                    else
                    {
                        MessageBox.Show("Không có kích thước nào được tải.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách size: {ex.Message}");
            }
        }
    }
}
