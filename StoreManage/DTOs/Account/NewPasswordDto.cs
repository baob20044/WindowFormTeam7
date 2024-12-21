namespace StoreManage.DTOs.Account
{
    public class NewPasswordDto
    {
        public string UserName { get; set; } 
        public string OldPassword { get; set; } 
        public string NewPassword { get; set; } 
        public string ConfirmNewPassword { get; set; }
    }
}
