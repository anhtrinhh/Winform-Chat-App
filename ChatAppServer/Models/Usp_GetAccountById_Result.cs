//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatAppServer.Models
{
    using System;
    
    public partial class Usp_GetAccountById_Result
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string avatar { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
    }
}
