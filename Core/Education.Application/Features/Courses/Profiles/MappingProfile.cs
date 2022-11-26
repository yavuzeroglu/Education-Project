using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Courses.Commands.CreateCourse;
using Education.Application.Features.Courses.Commands.DeleteCourse;
using Education.Application.Features.Courses.Commands.UpdateCourse;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Models;
using Education.Domain.Entities;

namespace Education.Application.Features.Courses.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Command Mapping

            CreateMap<Course, CreateCourseCommand>().ReverseMap();
            CreateMap<CreateCourseDto, Course>().ReverseMap();

            CreateMap<Course, UpdateCourseCommand>().ReverseMap();
            CreateMap<Course, UpdateCourseDto>().ReverseMap();

            CreateMap<Course, DeleteCourseCommand>().ReverseMap();
            CreateMap<DeleteCourseDto, Course>().ReverseMap();

            // Queries Mapping
            
            CreateMap<IPaginate<Course>, CourseListModel>().ReverseMap();
            CreateMap<Course, ListCourseDto>()
                .ForMember(d => d.Lessons, opt => opt.MapFrom(m => m.Lessons.Select(s => s.Name)))
                .ReverseMap();
                

            CreateMap<Course, GetByIdCourseDto>();


        }
    }
}
