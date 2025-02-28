using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseExpenseJson Execute(RequestExpenseJson request)
    {
        Validate(request);
        return new ResponseExpenseJson();
    }

    private void Validate(RequestExpenseJson request)
    {
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        if (titleIsEmpty)
        {
            throw new ArgumentException("Title is required");
        }

        if (request.Amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than zero");
        }

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        if (result > 0)
        {
            throw new ArgumentException("Expense cannot be in the future");
        }

        var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType),request.PaymentType);
        if (paymentTypeIsValid == false)
        {
            throw new ArgumentException("Payment type not valid");
        }
    }
}