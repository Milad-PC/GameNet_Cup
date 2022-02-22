using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BijBijCup.Models
{
    public class RegisterUsers
    {
        [Key]
        public int UserID { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50,ErrorMessage ="تعداد کاراکتر وارد شده بیش از حد مجاز است")]
        public string FullName { get; set; }
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11, ErrorMessage = "شماره همراه باید 11 رقمی باشد")]
        [MinLength(11, ErrorMessage = "شماره همراه باید 11 رقمی باشد")]
        public string Phone { get; set; }
        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "کد ملی باید 10 رقمی باشد")]
        [MinLength(10, ErrorMessage = "کد ملی باید 10 رقمی باشد")]
        public string CodeMeli { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
        [Required]
        public int GameNetID { get; set; }
        public RegisterUsers()
        {

        }
        public virtual GameNet GameNet { get; set; }
    }
}