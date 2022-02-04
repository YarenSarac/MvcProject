using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar ad alanını boş bırakmayınız.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı alanını boş bırakmayınız.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan alanını boş bırakmayınız.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen 50 karakterden az giriniz.");
        }
    }
}
