using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Ad alanını boş bırakmayınız.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş bırakmayınız.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter giriniz.");
        }
    }
}
