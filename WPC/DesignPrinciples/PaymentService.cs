﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int paymentAccountId, float amount)
        {
            var account = FindPaymentAccountById(paymentAccountId);
            /*if (account == null)
            {
                return false;
            }*/
            return account?.Charge(amount) ?? false;
        }

        private PaymentAccount FindPaymentAccountById(int paymentAccountId)
        {
            return PaymentAccounts.SingleOrDefault(x => x.Id == paymentAccountId);
        }

        public void Fund(int paymentAccountId, float amount)
        {
            var account = FindPaymentAccountById(paymentAccountId);
            /*if (account == null)
            {
                return;
            }*/
            account?.Fund(amount);
        }
    }
}
