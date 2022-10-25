using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDto>()
                .ReverseMap();

            CreateMap<Gender, GenderDto>()
                .ReverseMap();

            CreateMap<Address, AddressDto>()
                .ReverseMap();

        }
    }
}
