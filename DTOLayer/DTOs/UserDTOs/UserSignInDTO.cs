﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.UserDTOs
{
    public class UserSignInDTO
    {
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
