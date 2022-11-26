using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Lessons.Commands.CreateLesson;
using Education.Application.Features.Lessons.Commands.DeleteLesson;
using Education.Application.Features.Lessons.Commands.UpdateLesson;
using Education.Application.Features.Lessons.DTOs;
using Education.Application.Features.Lessons.Models;
using Education.Domain.Entities;

namespace Education.Application.Features.Lessons.Profiles
{
public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lesson, CreateLessonCommand>().ReverseMap();
            CreateMap<CreateLessonDto, Lesson>().ReverseMap();

            CreateMap<Lesson, UpdateLessonCommand>().ReverseMap();
            CreateMap<Lesson, UpdateLessonDto>().ReverseMap();

            CreateMap<Lesson, DeleteLessonDto>().ReverseMap();
            CreateMap<DeleteLessonCommand, Lesson>().ReverseMap();
            
            
            CreateMap<IPaginate<Lesson>, LessonListModel>().ReverseMap();
            CreateMap<Lesson, GetListLessonDto>().ReverseMap();

            CreateMap<Lesson, GetByIdLessonDto>().ReverseMap();
        }
    }
}
