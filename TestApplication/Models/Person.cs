using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    [Table("PersonsTable")]//specify the table used in the database for this model.
                           //otherwise the table name will be the model name + s. example: 'Person' model will use a table named 'Persons'

    public class Person
    {
        [Key]//specify the primary key which is automatically created by the database
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
