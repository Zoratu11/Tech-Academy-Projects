﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuoteMVCApp.ViewModels
{
    public class QuoteVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int MonthlyFee { get; set; }
    }
}