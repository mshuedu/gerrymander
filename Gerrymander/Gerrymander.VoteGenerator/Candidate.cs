//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gerrymander.VoteGenerator
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Party { get; set; }
        public int VotingDistrict { get; set; }
        public int VoteCount { get; set; }
    
        public virtual Party Party1 { get; set; }
        public virtual VotingDistrict VotingDistrict1 { get; set; }
    }
}
