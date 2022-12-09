using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookItHotellSystem.WPF.Model
{
    class GuestModel
    {
        public Guid GuestId {get;}

        public string Name { get; }
        
        public string Booking { get; }
        public DateOnly CheckedIn { get; }
        public DateOnly CheckedOut { get; }

     
    }
}
