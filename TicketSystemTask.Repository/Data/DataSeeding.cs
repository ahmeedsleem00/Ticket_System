using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System_Task.Helpers;
using TicketSystemTask.Core.Models;

namespace TicketSystemTask.Repository.Data
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Ahmed", PhoneNumber = "01157084165" },
                new User { Id = 2, Name = "Mohamed", PhoneNumber = "01234580797" },
                new User { Id = 3, Name = "Omar", PhoneNumber = "01047878945" },
                new User { Id = 4, Name = "Hassan", PhoneNumber = "01546864548" },
                new User { Id = 5, Name = "Sayed", PhoneNumber = "01254678654" },
                new User { Id = 6, Name = "Mahmoud", PhoneNumber = "01246084846" },
                new User { Id = 7, Name = "Diaa", PhoneNumber = "01157876484" },
                new User { Id = 8, Name = "Nada", PhoneNumber = "01576864656" },
                new User { Id = 9, Name = "Sara", PhoneNumber = "01546765165" },
                new User { Id = 10, Name = "Amin", PhoneNumber = "01154676470" }

                );
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/10500891.jpg");
            string base64Image = ImageHelper.ConvertImageToBase64(imagePath);

            modelBuilder.Entity<Ticket>().HasData(
           new Ticket { Id = 1, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 1 },
           new Ticket { Id = 2, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 2 },
           new Ticket { Id = 3, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 3 },
           new Ticket { Id = 4, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 4 },
           new Ticket { Id = 5, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 5 },
           new Ticket { Id = 6, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 6 },
           new Ticket { Id = 7, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 7 },
           new Ticket { Id = 8, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 8 },
           new Ticket { Id = 9, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 9 },
           new Ticket { Id = 10, TicketImage = $"<html><body><img src='{base64Image}' alt='Ticket Image'/></body></html>", UserId = 10 }

              );
        }
    }

}
