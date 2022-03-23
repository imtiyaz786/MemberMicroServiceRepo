﻿using System;

namespace MemberMicroservice.Models
{
    public class MemberPolicy
    {

        public int MemberID { get; set; }
        public int PolicyID { get; set; }
        public int PolicyNO { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public int Tenure { get; set; }
        public double CapAmountBenefits { get; set; }

    }
}
