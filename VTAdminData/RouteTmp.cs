//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTAdminData
{
    using System;
    using System.Collections.Generic;
    
    public partial class RouteTmp
    {
        public RouteTmp()
        {
            this.RouteStopTmps = new HashSet<RouteStopTmp>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string SessId { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string SystemId { get; set; }
        public string DeviceId { get; set; }
    
        public virtual ICollection<RouteStopTmp> RouteStopTmps { get; set; }
    }
}
