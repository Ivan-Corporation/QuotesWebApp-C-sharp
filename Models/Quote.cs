﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesWebApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Quotes { get; set; }
        public string QuotesAuthor { get; set; }

        public Quote()
        {

        }
    }
}
