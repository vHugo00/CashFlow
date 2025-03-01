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
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);
    }
}