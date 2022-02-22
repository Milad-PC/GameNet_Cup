using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BijBijCup.Models
{
    public class GameNet
    {
        [Key]
        public int GameNetID { get; set; }
        [Display(Name = "نام گیم نت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50,ErrorMessage ="تعداد کاراکتر وارد شده بیش از حد مجاز است")]
        public string GameNetName { get; set; }
        [Display(Name = "ظرفیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Range(1,500,ErrorMessage = "مقدار {0} باید بین {1} و {2} باشد")]
        public int Capacity { get; set; }
        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11,ErrorMessage ="شماره همراه باید 11 رقمی باشد")]
        [MinLength(11, ErrorMessage = "شماره همراه باید 11 رقمی باشد")]
        public string Phone { get; set; }
        public GameNet()
        {

        }
        public virtual List<RegisterUsers> Users { get; set; }
    }
}