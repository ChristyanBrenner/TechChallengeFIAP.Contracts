namespace CloudGames.Contracts.Events
{
    public record PaymentProcessedEvent(
    int UserId,
    int GameId,
    string GameName,
    PaymentStatus Status
);

    public enum PaymentStatus
    {
        Approved,
        Rejected
    }
}
