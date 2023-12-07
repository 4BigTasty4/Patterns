using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fasad.Entities.Classes;

class Provider
{
    private AnsweringMachine answeringMachine;
    private Access access;
    private Payment payment;

    public Provider()
    {
        answeringMachine = new AnsweringMachine();
        access = new Access();
        payment = new Payment();
    }

    public void ConnectionWithTheProvider()
    {
        answeringMachine.Receive();
        answeringMachine.Payment();
    }

    public void TruePaymentVerification()
    {
        payment.PaymentWentThrough();
    }

    public void FalsePaymentVerification()
    {
        payment.PaymentFailed();
    }

    public void TrueLineRecovery()
    {
        access.AccessIsAllowed();
    }

    public void FalseLineRecovery()
    {
        access.AccessIsDenied();
    }
}
