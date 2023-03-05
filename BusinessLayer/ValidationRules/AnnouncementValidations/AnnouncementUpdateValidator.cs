using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidations
{
    public class AnnouncementUpdateValidator:AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.AnnouncementTitle).NotEmpty().WithMessage("Duyuru başlığı boş geçilemez");
            RuleFor(x => x.AnnouncementContent).NotEmpty().WithMessage("Duyuru içeriği boş geçilemez");
            RuleFor(x => x.AnnouncementTitle).MinimumLength(3).WithMessage("Lütfen başlık için en az 3 karakter girişi yapınız");
            RuleFor(x => x.AnnouncementTitle).MaximumLength(30).WithMessage("Lütfen başlık için 30 karakterden fazla değer girişi yapmayınız");
        }
    }
}
