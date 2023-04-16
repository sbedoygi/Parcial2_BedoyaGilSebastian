using Microsoft.EntityFrameworkCore;
using Parcial2_BedoyaGilSebastian.DAL;

namespace Parcial2_BedoyaGilSebastian.Views.Tickets
{
    public class TicketService
    {
        private readonly DataBaseContextcs _context;

        public TicketService(DataBaseContextcs context)
        {
            _context = context;
        }

        public void CrearTickets()
        {
            for (int i = 0; i < 50000; i++)
            {
                var ticket = new Tickets
                {
                    Id = Guid.NewGuid(),
                    UseDate = null,
                    IsUsed = false,
                    EntranceGate = null,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = null
                };
                _context.Ticketes.Add(ticket);
            }
            _context.SaveChangesAsync();
        }
    }
}
