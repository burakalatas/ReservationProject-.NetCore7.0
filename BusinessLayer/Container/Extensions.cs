using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUow;
using BusinessLayer.ValidationRules.AnnouncementValidations;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependency(this IServiceCollection Services)
        {
            Services.AddScoped<ICommentService, CommentManager>();
            Services.AddScoped<ICommentDal, EfCommentDal>();
            
            Services.AddScoped<IDestinationService, DestinationManager>();
            Services.AddScoped<IDestinationDal, EfDestinationDal>();
            
            Services.AddScoped<IAppUserService, AppUserManager>();
            Services.AddScoped<IAppUserDal, EfAppUserDal>();
            
            Services.AddScoped<IReservationService, ReservationManager>();
            Services.AddScoped<IReservationDal, EfReservationDal>();

            Services.AddScoped<IGuideService, GuideManager>();
            Services.AddScoped<IGuideDal, EfGuideDal>();

            Services.AddScoped<IExcelService, ExcelManager>();

            Services.AddScoped<IPdfService, PdfManager>();

            Services.AddScoped<IContactUsService, ContactUsManager>();
            Services.AddScoped<IContactUsDal, EFContactUsDal>();

            Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            Services.AddScoped<IAccountService, AccountManager>();
            Services.AddScoped<IAccountDal, EfAccountDal>();
            
            Services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

        }
        public static void CustomValidator(this IServiceCollection Services)
        {
            Services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementAddValidator>();
            Services.AddTransient<IValidator<AnnouncementUpdateDTO>, AnnouncementUpdateValidator>();
        }
    }
}
