using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pim.project.domain
{
    public class PeoplePhone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Number { get; set; }

        public int DddId { get; set; }

        public int PeoplePhoneTypeId { get; set; }
        
        public int PeopleId { get; set; }

    }
}
