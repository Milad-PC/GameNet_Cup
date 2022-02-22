using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BijBijCup.Models
{
    public class SMSHis
    {
        [Key]
        public int SMSID { get; set; }
        [Display(Name = "زمان ارسال")]
        public DateTime SendDate { get; set; } = DateTime.Now;
        [Display(Name = "شماره همراه")]
        public string Phone { get; set; }
        [Display(Name = "متن پیامک")]
        public string Text { get; set; }
        [Display(Name = "نتیجه ارسال")]
        public string Result { get; set; }
    }
}