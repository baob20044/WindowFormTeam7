using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Services
{
    public class TokenManager
    {
        private const string RegistryPath = @"HKEY_CURRENT_USER\Software\StoreManage";  // Đường dẫn Registry
        private const string TokenKey = "AccessToken";  // Tên key lưu token

        // Lưu token vào Registry
        public static void SaveToken(string token)
        {
            try
            {
                Registry.SetValue(RegistryPath, TokenKey, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving token: {ex.Message}");
            }
        }

        // Lấy token từ Registry
        public static string GetToken()
        {
            try
            {
                return (string)Registry.GetValue(RegistryPath, TokenKey, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving token: {ex.Message}");
                return null;
            }
        }
    }
}
