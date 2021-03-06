//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thesis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public Task()
        {

        }

        public Task(DateTime start, DateTime end, int ID, bool isAccomplished, decimal TargetCourse, bool isSellRate, bool isBuyRate,decimal Tolerance)
        {
            this.StartDate = start;
            this.EndDate = end;
            this.CCID = ID;
            this.IsAccomplished = isAccomplished;
            this.TargetCourse = TargetCourse;
            this.SellRate = isSellRate;
            this.BuyRate = isBuyRate;
            this.Tolerance = Tolerance;
        }

        public int ID { get; set; }
        public bool IsAccomplished { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int CCID { get; set; }
        public decimal TargetCourse { get; set; }
        public Nullable<bool> SellRate { get; set; }
        public Nullable<bool> BuyRate { get; set; }
        public Nullable<decimal> Tolerance { get; set; }
    
        public virtual CurrencyCode CurrencyCode { get; set; }
    }
}
