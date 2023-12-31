﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Dtos.ScreenAccess
{
    public class ScreenAccessDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int UserRoleId { get; set; }
        public int ScreenId { get; set; }
        public bool CanAccess { get; set; }
        public string ScreenName { get; set; }
        public string ScreenUrl { get; set; }
    }
}
