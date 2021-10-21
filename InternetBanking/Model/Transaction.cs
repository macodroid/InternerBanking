using System;

namespace InternetBanking.Model
{
    public class Transaction
    {
        public decimal TransactionId { get; set; }
        public string FullName { get; set; }
        public TransactionType TransactionType { get; set; }
        public string AccountNumber { get; set; }
        public string BankCode { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Amount { get; set; }
    }

    public class TransactionWithdraws : Transaction
    {
        public string CardNo { get; set; }
        public string Place { get; set; }
    }
    public enum TransactionType
    {
        Incoming = 0,
        Outgoing = 1,
        Withdraws = 2
    }
}