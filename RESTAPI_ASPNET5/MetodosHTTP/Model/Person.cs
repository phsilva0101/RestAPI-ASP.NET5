using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetodosHTTP.Model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("phone")]
        public string Phone { get; set; }

    }
}
