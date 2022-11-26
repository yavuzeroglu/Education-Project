using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Students.Commands.CreateStudent;
using Education.Application.Features.Students.Commands.DeleteStudent;
using Education.Application.Features.Students.Commands.UpdateStudent;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Models;
using Education.Domain.Entities;

namespace Education.Application.Features.Students.Profiles
{
    internal class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Student, CreateStudentCommand>().ReverseMap(); 
            CreateMap<CreateStudentDto, Student>().ReverseMap();

            CreateMap<Student, UpdateStudentCommand>().ReverseMap();
            CreateMap<UpdateStudentDto, Student>().ReverseMap();

            CreateMap<Student, DeleteStudentCommand>().ReverseMap();
            CreateMap<DeleteStudentDto, Student>().ReverseMap();
            
            CreateMap<Student, GetListStudentDto>().ReverseMap();
            CreateMap<IPaginate<Student>, StudentListModel>().ReverseMap();

            CreateMap<Student, GetByIdStudentDto>();


        }
    }
}
