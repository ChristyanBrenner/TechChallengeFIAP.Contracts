namespace CloudGames.Contracts.Events
{
    public record PaymentProcessedEvent(
    int UserId,
    int GameId,
    string GameName,
    decimal GamePrice,
    PaymentStatus Status
);

    public enum PaymentStatus
    {
        Approved,
        Rejected
    }
}
