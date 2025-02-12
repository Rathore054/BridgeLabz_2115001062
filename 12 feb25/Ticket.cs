using System;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public string BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, string seatNumber, string bookingTime)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }
}

class TicketReservationSystem
{
    private Ticket head;
    private Ticket tail;

    public void BookTicket(int ticketID, string customerName, string movieName, string seatNumber, string bookingTime)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
        if (head == null)
        {
            head = newTicket;
            tail = newTicket;
            tail.Next = head;
        }
        else
        {
            tail.Next = newTicket;
            tail = newTicket;
            tail.Next = head;
        }
    }

    public void CancelTicket(int ticketID)
    {
        if (head == null) return;

        Ticket temp = head, prev = null;

        if (head.TicketID == ticketID)
        {
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Next;
            tail.Next = head;
            return;
        }

        do
        {
            prev = temp;
            temp = temp.Next;
        } while (temp != head && temp.TicketID != ticketID);

        if (temp == head) return;

        prev.Next = temp.Next;
        if (temp == tail)
        {
            tail = prev;
        }
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket temp = head;
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + ", Booking Time: " + temp.BookingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.BookTicket(1, "Alice", "Avengers", "A1", "10:00 AM");
        system.BookTicket(2, "Bob", "Batman", "B2", "12:00 PM");
        system.BookTicket(3, "Charlie", "Superman", "C3", "02:00 PM");

        Console.WriteLine("All Tickets:");
        system.DisplayTickets();

        Console.WriteLine("\nCanceling Ticket ID 2:");
        system.CancelTicket(2);
        system.DisplayTickets();
    }
}
