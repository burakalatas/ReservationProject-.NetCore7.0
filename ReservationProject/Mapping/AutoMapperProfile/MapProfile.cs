using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.ContactDTOs;
using DTOLayer.DTOs.UserDTOs;
using EntityLayer.Concrete;

namespace ReservationProject.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Announcement, AnnouncementAddDTO>();
            CreateMap<AnnouncementAddDTO, Announcement>();

            CreateMap<Announcement, AnnouncementListDTO>();
            CreateMap<AnnouncementListDTO, Announcement>();

            CreateMap<Announcement, AnnouncementUpdateDTO>();
            CreateMap<AnnouncementUpdateDTO, Announcement>();

            CreateMap<AppUser, UserRegisterDTO>();
            CreateMap<UserRegisterDTO, AppUser>();

            CreateMap<AppUser, UserSignInDTO>();
            CreateMap<UserSignInDTO, AppUser>();

            CreateMap<ContactUs, SendMessageDto>().ReverseMap();

        }
    }
}
