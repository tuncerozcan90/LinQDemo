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
    
    public partial class FactCallCenter
    {
        public int FactCallCenterID { get; set; }
        public int DateKey { get; set; }
        public string WageType { get; set; }
        public string Shift { get; set; }
        public short LevelOneOperators { get; set; }
        public short LevelTwoOperators { get; set; }
        public short TotalOperators { get; set; }
        public int Calls { get; set; }
        public int AutomaticResponses { get; set; }
        public int Orders { get; set; }
        public short IssuesRaised { get; set; }
        public short AverageTimePerIssue { get; set; }
        public double ServiceGrade { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimDate DimDate { get; set; }
    }
}
