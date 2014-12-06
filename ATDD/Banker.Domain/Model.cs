using System;

namespace Banker.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal Value { get; set; }
        public DateTime Time { get; set; }
    }
}
