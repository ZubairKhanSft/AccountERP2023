﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Entities
{
    public class COA_Account
    {
        public int Id { get; set; }
        public int COA_AccountTypeId { get; set; }
        public string AccountName { get; set; }
        public string AccountCode { get; set; }
        public string Description { get; set; }
    }
}
