//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinQDemo.EFDbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class FactCurrencyRate
    {
        public int CurrencyKey { get; set; }
        public int DateKey { get; set; }
        public double AverageRate { get; set; }
        public double EndOfDayRate { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimCurrency DimCurrency { get; set; }
        public virtual DimDate DimDate { get; set; }
    }
}
