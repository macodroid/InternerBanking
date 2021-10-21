using System;
using System.Collections.Generic;
using System.Linq;
using InternetBanking.Model;
using InternetBanking.Services;
using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{
    [ApiController]
    [Route("api/transaction")]
    public class InternetBankingApi: ControllerBase
    {
        private ITransactionService TransactionService { get; }

        public InternetBankingApi(ITransactionService transactionService)
        {
            TransactionService = transactionService;
        }
        [HttpGet]
        public List<Transaction> GetAll()
        {
            return TransactionService.GetTransactions().ToList();
        }

        [HttpGet("{id:decimal}")]
        public Transaction Get(decimal id)
        {
            return TransactionService.GetTransaction(id);
        }

        [HttpPost]
        public IActionResult SaveTransaction(Transaction transaction)
        {
            try
            {
                TransactionService.SaveTransaction(transaction);
                return Created($"api/transaction/{transaction.TransactionId}",transaction.TransactionId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }
    }
}