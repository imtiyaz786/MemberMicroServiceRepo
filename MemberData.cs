using MemberMicroservice.Models;
using System;
using System.Collections.Generic;

namespace MemberMicroservice
{
    public class MemberData
    {
        public static List<Member> members = new List<Member>()
        {
            new Member()
            {
                MemberID = 1,
                MemberName = "Nandan",
                MemberAddress1 = "123 Arjun Park",
                MemberAddress2 = "Dwarka",
                MemberCity = "Delhi",
                MemberPhone = 0124345454,
                Username = "nandan",
                Password = "Training@123"
            },
            new Member()
            {
                MemberID = 2,
                MemberName = "Imtiyaz",
                MemberAddress1 = "Aeroli",
                MemberAddress2 = "Thane",
                MemberCity = "Mumbai",
                MemberPhone = 0432345242,
                Username = "imtiyaz",
                Password = "mypass@123"
            }

        };
        public static List<MemberPremium> premiumDetails = new List<MemberPremium>()
        {
            new MemberPremium()
            {
                MemberID = 1,
                PolicyID = 1,
                PremiumDue = 43242.0,
                PaymentDetails = "UPI Mode",
                DueDate = new DateTime(2020, 12, 20),
                LastPremiumPaidDate = new DateTime(2019, 12, 21)
            },
            new MemberPremium()
            {
                MemberID = 2,
                PolicyID = 1,
                PremiumDue = 54342.0,
                PaymentDetails = "Cheque Mode",
                DueDate = new DateTime(2021, 04, 16),
                LastPremiumPaidDate = new DateTime(2020, 04, 22)
            }
        };
    }
}
