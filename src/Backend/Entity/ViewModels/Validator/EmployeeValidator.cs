using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels.Validator
{
    public class EmployeeValidator : AbstractValidator<EmployeeViewModel>
    {
        public EmployeeValidator()
        {
            RuleFor(model => model.Name).NotNull().WithMessage("Employee Name can't be null");

        }
    }
}
