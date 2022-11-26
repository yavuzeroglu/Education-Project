using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Questions.Commands.CreateQuestion;
using Education.Application.Features.Questions.Commands.DeleteQuestion;
using Education.Application.Features.Questions.Commands.UpdateQuestion;
using Education.Application.Features.Questions.DTOs;
using Education.Application.Features.Questions.Models;
using Education.Domain.Entities;

namespace Education.Application.Features.Questions.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Question, CreateQuestionCommand>().ReverseMap();
            CreateMap<Question, CreateQuestionDto>().ReverseMap();

            CreateMap<Question, DeleteQuestionCommand>().ReverseMap();
            CreateMap<Question, DeleteQuestionDto>().ReverseMap();

            CreateMap<Question, UpdateQuestionCommand>().ReverseMap();
            CreateMap<Question, UpdateQuestionDto>().ReverseMap();

            CreateMap<IPaginate<Question>, QuestionListModel>().ReverseMap();
            CreateMap<Question, GetListQuestionDto>().ReverseMap();

            CreateMap<Question, GetByIdQuestionDto>().ReverseMap();
        }
    }
}
