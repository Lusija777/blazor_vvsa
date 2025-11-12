namespace blazor_FE.Entities;

public class Transaction
{
    public decimal TransactionId { set; get; }
    public required string FullName { set; get; }
    public required string TransactionType { set; get; }
    public required string AccountNumber { set; get; }
    public required string BankCode { set; get; }
    public DateTime IssueDate { set; get; }
    public decimal Amount { set; get; } 

    public Transaction() { }

}