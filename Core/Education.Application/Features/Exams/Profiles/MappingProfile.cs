using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Exams.Commands.CreateExam;
using Education.Application.Features.Exams.Commands.DeleteExam;
using Education.Application.Features.Exams.Commands.UpdateExam;
using Education.Application.Features.Exams.DTOs;
using Education.Application.Features.Exams.Models;
using Education.Domain.Entities;

namespace Education.Application.Features.Exams.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Exam, CreateExamCommand>().ReverseMap();
            CreateMap<Exam, CreateExamDto>().ReverseMap();

            CreateMap<Exam, UpdateExamCommand>().ReverseMap();
            CreateMap<Exam, UpdateExamDto>().ReverseMap();

            CreateMap<Exam, DeleteExamCommand>().ReverseMap();
            CreateMap<Exam, DeleteExamDto>().ReverseMap();

            CreateMap<IPaginate<Exam>, ExamListModel>().ReverseMap();
            CreateMap<Exam, GetListExamDto>()
                .ForMember(d => d.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                .ForMember(d => d.Course, opt => opt.MapFrom(src => src.Courses.Select(s => s.Name)))
                .ReverseMap();

            CreateMap<Exam, GetByIdExamDto>()
                .ForMember(d => d.Course, opt => opt.MapFrom(src => src.Courses.Select(s => s.Name)))
                .ForMember(d => d.SubjectName, opt=> opt.MapFrom(src => src.Subject.Name))
                .ReverseMap();
        }
    }
}
