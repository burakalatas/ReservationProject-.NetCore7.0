using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutDescription).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
            RuleFor(x => x.AboutImage1).NotEmpty().WithMessage("Görsel kısmı boş geçilemez.");
            RuleFor(x => x.AboutDescription2).NotEmpty().WithMessage("Alt açıklama kısmı boş geçilemez.");
            RuleFor(x => x.AboutDescription).MaximumLength(1500).WithMessage("Açıklama kısmı 1500 karakterden fazla olamaz.");
            RuleFor(x => x.AboutDescription).MinimumLength(10).WithMessage("Açıklama kısmı 10 karakterden az olamaz.");
        }
    }
}
