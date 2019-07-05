﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.Business.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
