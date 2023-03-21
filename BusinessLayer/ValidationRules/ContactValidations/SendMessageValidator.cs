using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactValidations
{
    public class SendMessageValidator:AbstractValidator<SendMessageDto>
    {
        public SendMessageValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.UserMail).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj boş geçilemez");
        }
    }
}
