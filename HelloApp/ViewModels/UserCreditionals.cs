using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.ViewModels
{
    public partial class UserCreditionals : ObservableValidator
    {
        [ObservableProperty]
        [Required(ErrorMessage = "Логин обязателен")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Только латиница, цифры и '_'")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(20, ErrorMessage = "Максимум 20 символов")]
        [NotifyDataErrorInfo]
        private string login;

        [ObservableProperty]
        [Required(ErrorMessage = "Пароль обязателен")]
        [MinLength(8, ErrorMessage = "Минимум 8 символов")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage = "Нужны буквы разного регистра, цифры и спецсимволы")]
        [NotifyDataErrorInfo]
        private string password;

        [ObservableProperty]
        [Required(ErrorMessage = "Подтвердите пароль")]
        [NotifyDataErrorInfo]
        private string? confirmPassword;

        [ObservableProperty]
        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный Email")]
        [NotifyDataErrorInfo]
        private string email;

        [ObservableProperty]
        [Required(ErrorMessage = "Телефон обязателен")]
        [NotifyDataErrorInfo]
        private string phone;

        public void ValidateAll() => ValidateAllProperties();
    }
}
