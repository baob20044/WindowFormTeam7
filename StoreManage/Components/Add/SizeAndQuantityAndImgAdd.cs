using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Size;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components.Add
{
    public partial class SizeAndQuantityAndImgAdd : UserControl
    {
        private ColorDto currentColor;
        private List<string> imageUrls = new List<string>();
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

        public void LoadData(List<(SizeDto size, int quantity)> data, List<string> imageUrls)
        {
            flowLayoutPanel1.Controls.Clear(); 

            foreach (var item in data)
            {
                Panel itemPanel = new Panel
                {
                    Size = new Size(flowLayoutPanel1.Width - 20, 30),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblSize = new Label
                {
                    Text = $"Size: {item.size.SizeValue}",
                    AutoSize = true,
                    Location = new Point(5, 5)
                };

                Label lblQuantity = new Label
                {
                    Text = $"Quantity: {item.quantity}",
                    AutoSize = true,
                    Location = new Point(150, 5)
                };
                
                itemPanel.Controls.Add(lblSize);
                itemPanel.Controls.Add(lblQuantity);

                flowLayoutPanel1.Controls.Add(itemPanel);
            }
            this.imageUrls = imageUrls;

            DisplayImages(imageUrls);
        }

        private void DisplayImages(List<string> imageUrls)
        {
            // Xóa tất cả PictureBox cũ
            flowLayoutPanel2.Controls.Clear();

            int[] xPositions = { 29, 204, 380, 561, 732 };
            int yPosition = 360;
            int width = 133;
            int height = 62;

            for (int i = 0; i < imageUrls.Count; i++)
            {
                if (i >= xPositions.Length) break; // Giới hạn số lượng PictureBox theo số lượng vị trí

                string imageUrl = imageUrls[i];

                PictureBox pictureBox = new PictureBox
                {
                    Width = width,
                    Height = height,
                    ImageLocation = imageUrl ?? "default-image.png", // Nếu URL không hợp lệ thì sử dụng ảnh mặc định
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(xPositions[i], yPosition)
                };

                flowLayoutPanel2.Controls.Add(pictureBox); 
            }
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            var selectedSize = cbSize.SelectedItem as SizeDto;
            string sizeValue = selectedSize?.SizeValue ?? "N/A";
            string quantityText = txtQuantity.Text;

            if (string.IsNullOrEmpty(quantityText) || !int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel itemPanel)
                {
                    Label lblSize = itemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Size:"));

                    if (lblSize != null && lblSize.Text.Contains(sizeValue))
                    {
                        Label lblQuantity = itemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Quantity:"));

                        if (lblQuantity != null)
                        {
                            lblQuantity.Text = $"Quantity: {quantity}";
                            MessageBox.Show($"Cập nhật size {sizeValue} với số lượng mới: {quantity}");
                            return;
                        }
                    }
                }
            }

            Panel newItemPanel = new Panel
            {
                Size = new Size(flowLayoutPanel1.Width - 20, 30), 
                BorderStyle = BorderStyle.FixedSingle
            };

            Label newLblSize = new Label
            {
                Text = $"Size: {sizeValue}",
                AutoSize = true,
                Location = new Point(5, 5) 
            };

            Label newLblQuantity = new Label
            {
                Text = $"Quantity: {quantity}",
                AutoSize = true,
                Location = new Point(150, 5) 
            };

            newItemPanel.Controls.Add(newLblSize);
            newItemPanel.Controls.Add(newLblQuantity);

            flowLayoutPanel1.Controls.Add(newItemPanel);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public event Action<ColorDto, List<string>, List<(SizeDto size, int quantity)>> OnSave;

        public void SetColor(ColorDto color)
        {
            currentColor = color; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<(SizeDto size, int quantity)> data = new List<(SizeDto size, int quantity)>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel itemPanel)
                {
                    Label lblSize = itemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Size:"));
                    Label lblQuantity = itemPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Quantity:"));

                    if (lblSize != null && lblQuantity != null)
                    {
                        SizeDto size = cbSize.Items.OfType<SizeDto>().FirstOrDefault(s => s.SizeValue == lblSize.Text.Replace("Size: ", "").Trim());
                        int quantity = int.Parse(lblQuantity.Text.Replace("Quantity: ", "").Trim());

                        data.Add((size, quantity));
                    }
                }
            }

            OnSave?.Invoke(currentColor, imageUrls, data);

            this.Parent.Controls.Remove(this);
        }

        private void btnOkImgUrl_Click(object sender, EventArgs e)
        {
            string imageUrl = txtImageUrl.Text;

            // Xử lý URL để đảm bảo hợp lệ
            imageUrl = SanitizeImageUrl(imageUrl);

            // Thêm URL vào danh sách ảnh
            imageUrls.Add(imageUrl);

            // Hiển thị ảnh lên các PictureBox
            DisplayImages(imageUrls);
        }

        private string SanitizeImageUrl(string url)
        {
            // Giải mã URL để thay thế các ký tự mã hóa (ví dụ: %20 => khoảng trắng)
            string decodedUrl = Uri.UnescapeDataString(url);

            // Loại bỏ các phần không hợp lệ trong URL (ví dụ: "filters:format(webp)")
            string sanitizedUrl = decodedUrl.Split('?')[0];  // Loại bỏ các tham số sau dấu hỏi nếu có

            // Đảm bảo URL kết thúc bằng .jpg, .png, hoặc .jpeg
            if (!sanitizedUrl.EndsWith(".jpg") && !sanitizedUrl.EndsWith(".png") && !sanitizedUrl.EndsWith(".jpeg"))
            {
                // Thêm phần mở rộng .jpg nếu URL không có định dạng ảnh hợp lệ
                sanitizedUrl += ".jpg";
            }

            return sanitizedUrl;
        }

    }
}
