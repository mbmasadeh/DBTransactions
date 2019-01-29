using AutoMapper;
using DBTransactions.Models;
using DBTransactions.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Utilites
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentsViewModel, Students>();
        }
    }
}
