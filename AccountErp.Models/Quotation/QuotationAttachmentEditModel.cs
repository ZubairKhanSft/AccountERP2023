﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Models.Quotation
{
    public class QuotationAttachmentEditModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
    }
}
