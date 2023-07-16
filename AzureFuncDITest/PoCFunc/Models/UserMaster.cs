using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Function.Models
{
    [Table("UserMaster")]
    public class UserMaster
    {
        [Column("Id")]
        public string Id { get; set; }
        [Column("UserName")]
        public string Name { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Tel")]
        public string Tel { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("IsAdmin")]
        public bool IsAdmin {get; set;}
        [Column("EntryDateTime")]
        public DateTime EntryDateTime {get; set;}
        [Column("UpdateDateTime")]
        public DateTime UpdateDateTime {get; set;}
        [Column("IsDeleteFlag")]
        public bool IsDeleteFlag {get; set;}
    }
}