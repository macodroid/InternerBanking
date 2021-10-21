using System.Collections.Generic;
using System.Linq;
using InternetBanking.Model;
using InternetBanking.Repositories;

namespace InternetBanking.Services
{
    public interface ITransactionService
    {
        IList<Transaction> GetTransactions();
        Transaction GetTransaction(decimal id);
        void SaveTransaction(Transaction transaction);
    }

    public class TransactionService : ITransactionService
    {
        private ITransactionRepository TransactionRepository { get; }

        public TransactionService()
        {
            TransactionRepository = new TransactionRepository();
        }
        
        public IList<Transaction> GetTransactions()
        {
            return TransactionRepository.GetTransactions().ToList();
        }

        public Transaction GetTransaction(decimal id)
        {
            return TransactionRepository.GetTransactions().ToList().FirstOrDefault(t => t.TransactionId == id);
        }

        public void SaveTransaction(Transaction transaction)
        {
            TransactionRepository.CreateTransaction(transaction);
        }
    }
}