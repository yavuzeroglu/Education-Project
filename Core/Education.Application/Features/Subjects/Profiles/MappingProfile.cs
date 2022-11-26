using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Subjects.Commands.CreateSubject;
using Education.Application.Features.Subjects.Commands.DeleteSubject;
using Education.Application.Features.Subjects.Commands.UpdateSubject;
using Education.Application.Features.Subjects.DTOs;
using Education.Application.Features.Subjects.Models;
using Education.Application.Features.Subjects.Queries.GetByIdSubject;
using Education.Domain.Entities;

namespace Education.Application.Features.Subjects.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Subject, CreateSubjectCommand>().ReverseMap();
            CreateMap<Subject, CreateSubjectDto>().ReverseMap();

            CreateMap<Subject, DeleteSubjectCommand>().ReverseMap();
            CreateMap<Subject, DeleteSubjectDto>().ReverseMap();

            CreateMap<Subject, UpdateSubjectDto>().ReverseMap();
            CreateMap<Subject, UpdateSubjectCommand>().ReverseMap();

            CreateMap<IPaginate<Subject>, SubjectListModel>().ReverseMap();
            CreateMap<Subject, GetListSubjectDto>().ReverseMap();

            CreateMap<Subject, GetByIdSubjectDto>().ReverseMap();
            CreateMap<Subject, GetByIdSubjectQuery>().ReverseMap();

        }
    }
}
