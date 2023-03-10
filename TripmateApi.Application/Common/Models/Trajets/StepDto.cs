using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripmateApi.Application.Common.Mapping;
using TripmateApi.Domain.Entities;

namespace TripmateApi.Application.Common.Models.Trajets
{
    public class StepDto : IMapFrom<Step>
    {
        public DateTime DepartTime { get; set; }
        public PositionDto PositionDepart { get; set; }
        public PositionDto PositionArrival { get; set; }
        public int? Duration { get; set; }
        public int? Seats { get; set; }

        public void Mapping(Profile profile) => profile.CreateMap<StepDto, Step>().ReverseMap();
    }
}
