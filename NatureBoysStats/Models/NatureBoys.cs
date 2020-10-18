using System;
using System.Collections.Generic;

namespace NatureBoysStats.Models
{
    public partial class NatureBoys
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Goals { get; set; }
        public int? Assist { get; set; }
        public int? Points { get; set; }
        public int? PenaltyMinutes { get; set; }
        public int? BeersBefore { get; set; }
        public int? BeersDuring { get; set; }
        public int? BeersAfter { get; set; }
        public string NickName { get; set; }

        public NatureBoys()
        {

        }
        public NatureBoys(int _id, string _nickName)
        {
            Id = _id;
            NickName = _nickName;
            Goals = 0;
            Assist = 0;
            Points = 0;
            PenaltyMinutes = 0;
            BeersAfter = 0;
            BeersDuring = 0;
            BeersBefore = 0;

        }
    }
}
