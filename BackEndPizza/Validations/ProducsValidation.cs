using FluentValidation;

namespace BackEndPizza.Validations
{
    public class ProducsValidation : AbstractValidator<Producs>
    {
        public ProducsValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Cannot be null");
            RuleFor(x => x.Price).NotEmpty().ExclusiveBetween(0.01M, decimal.MaxValue).WithMessage("Please enter a value bigger than 0.01");
        }
    }
}
