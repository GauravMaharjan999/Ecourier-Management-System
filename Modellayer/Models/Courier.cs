using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modellayer.Models
{
    public class Courier
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Services { get; set; }
        public string Delivery { get; set; }
        public string Notification { get; set; }
        public string Address { get; set; }
        public string RecName { get; set; }
        public string RecPhone { get; set; }
        public string RecEmail { get; set; }
        public string PackageType { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public string DeliveryTo { get; set; }

        public int DeliveryManId { get; set; }

        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }


        [ForeignKey("DeliveryManId")]
        public DeliveryMan DeliveryMan { get; set; }

    }
}
