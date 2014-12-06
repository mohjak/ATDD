using Banker.Domain.TDD.Infrastructure;
using Banker.Domain.TDD.Model;

namespace Banker.Domain.TDD.Services
{
    public class AccountantService
    {
        private IAccountsRepository _accountRepo;
        private ITransactionRepository _transactionRepo;

        public AccountantService(IAccountsRepository accountRepo, ITransactionRepository transactionRepo)
        {
            _accountRepo = accountRepo;
            _transactionRepo = transactionRepo;
        }

        public Account Withdraw(int accountId, decimal amount)
        {
            Account account = _accountRepo.Get(accountId);
            account.Balance -= amount;
            _accountRepo.Update(account);
            _transactionRepo.Create(accountId, amount);
            return account;
        }
    }
}
