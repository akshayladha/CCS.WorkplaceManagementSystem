using System;

namespace CCS.WorkplaceManagementSystem.Models
{
    public class Desk
    {
        public string DeskNumber { get; set; }
        public string DeskLocation { get; set; }
        public Guid Id { get; set; }

        public override string ToString()
        {
            return "Desk Number : " + DeskNumber;
        }
    }
}
