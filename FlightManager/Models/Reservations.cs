using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public int IdentifiactionalNumber { get; set; }
        public int PhoneNumber { get; set; }
        public enum Nationality
        {
            Bulgaria,
            USA
        }
        public enum TicketType
        {
            Economy,
            Business
        }
        
        public string Email { get; set; }
    }
}
