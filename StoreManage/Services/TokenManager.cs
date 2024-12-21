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
        private const string UsernameKey = "Username";  // Tên key lưu username
        private const string RefreshTokenKey = "RefreshToken";

        // Lưu token vào Registry
        public static void SaveToken(string token)
        {
            try
            {
                if (!string.IsNullOrEmpty(token))
                {
                    token = token.Trim('"');
                }

                Registry.SetValue(RegistryPath, TokenKey, token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving token: {ex.Message}");
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
                Console.WriteLine($"Error retrieving token: {ex.Message}");
                return null;
            }
        }

        // Xóa token khỏi Registry
        public static void RemoveToken()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\StoreManage", true);
                if (key != null && key.GetValue(TokenKey) != null)
                {
                    key.DeleteValue(TokenKey);
                    Console.WriteLine("Token removed successfully.");
                }
                else
                {
                    Console.WriteLine("Token not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing token: {ex.Message}");
            }
        }


        public static void SaveUsername(string username)
        {
            try
            {
                Registry.SetValue(RegistryPath, UsernameKey, username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving username: {ex.Message}");
            }
        }

        public static string GetUsername()
        {
            try
            {
                return (string)Registry.GetValue(RegistryPath, UsernameKey, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving username: {ex.Message}");
                return null;
            }
        }

        public static void SaveRefreshToken(string refreshtoken)
        {
            try
            {
                Registry.SetValue(RegistryPath, RefreshTokenKey, refreshtoken);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving refreshtoken: {ex.Message}");
            }
        }

        public static string GetRefreshToken()
        {
            try
            {
                return (string)Registry.GetValue(RegistryPath, RefreshTokenKey, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving refreshtoken: {ex.Message}");
                return null;
            }
        }
    }
}
