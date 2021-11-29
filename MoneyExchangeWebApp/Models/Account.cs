﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyExchangeWebApp.Models
{
    public class Account
    {
        [Required]
        public int account_id {get; set;}
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string role { get; set; }
        [Required]
        public DateTime date_created { get; set; }
        [Required]
        public int deleted { get; set; }
        public string deleted_by { get; set; }
    }
}


