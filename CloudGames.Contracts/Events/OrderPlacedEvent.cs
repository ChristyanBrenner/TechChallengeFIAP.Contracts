using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudGames.Contracts.Events
{
    public record OrderPlacedEvent(
    int Id,
    int UserId,
    int GameId,
    string GameName,
    decimal Price
);
}
