using StoreManage.Controllers;
using StoreManage.DTOs.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components.Add
{
    public partial class AmountAdd : UserControl
    {
        private int ColorId;
        private int SizeId;
        private int ProductId;
        InventoryController inventoryController;
        public AmountAdd(int colorId, int sizeId, int productId)
        {
            InitializeComponent();
            ColorId = colorId; SizeId = sizeId; ProductId = productId;
            inventoryController = new InventoryController(new Services.ApiService());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            InventoryUpdateDto inventoryUpdateDto = new InventoryUpdateDto()
            {
                ColorId = ColorId,
                SizeId = SizeId,
                ProductId = ProductId,
                Quantity = Convert.ToInt32(txtQuantity.Text)
            };
            var resquest =  await inventoryController.UpdateAsync(inventoryUpdateDto);
            if(resquest != null) MessageBox.Show(resquest);
            this.Parent.Controls.Remove(this);
        }
    }
}
