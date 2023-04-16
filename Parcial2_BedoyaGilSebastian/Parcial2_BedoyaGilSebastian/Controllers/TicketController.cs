using Microsoft.AspNetCore.Mvc;
using Parcial2_BedoyaGilSebastian.Views.Tickets;

public class TicketController : Controller
{
    private readonly TicketService _ticketService;

    public TicketController(TicketService ticketService)
    {
        _ticketService = ticketService;
    }

    public IActionResult CrearTickets()
    {
        _ticketService.CrearTickets();
        return RedirectToAction("Index", "Home");
    }
}
