using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudGames.Contracts.Events
{
    public record UserCreatedEvent(
    int UserId,
    string Email,
    DateTime CreatedAt
);
}
