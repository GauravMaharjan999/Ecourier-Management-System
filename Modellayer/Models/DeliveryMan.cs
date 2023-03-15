using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modellayer.Models
{
    public class DeliveryMan
    {


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string TempAddress { get; set; }
        public string PermanentAddress { get; set; }

        [Range(18,90,ErrorMessage ="Age must be between 18-90")]
        public int Age { get; set; }
    }
}
