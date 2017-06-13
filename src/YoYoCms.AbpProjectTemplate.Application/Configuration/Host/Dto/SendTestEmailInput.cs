﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using YoYoCms.AbpProjectTemplate.Authorization.Users;

namespace YoYoCms.AbpProjectTemplate.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}