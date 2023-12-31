﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Learner.Shared.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
    }
}
