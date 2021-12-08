//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Position { get; set; }
        public System.DateTime Joining_Date { get; set; }
        public System.DateTime Contract_Year { get; set; }
        public int Performance_Id { get; set; }
        public int Salary_Id { get; set; }
        public int Fitness_Id { get; set; }
    
        public virtual Fitness Fitness { get; set; }
        public virtual Performance Performance { get; set; }
        public virtual Salary Salary { get; set; }
    }
}