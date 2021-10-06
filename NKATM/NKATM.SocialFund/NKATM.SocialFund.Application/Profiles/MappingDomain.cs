using AutoMapper;
using NKATM.SocialFund.Application.DTOs.SocialRequest;
using NKATM.SocialFund.Application.DTOs.SocialResult;
using NKATM.SocialFund.Application.DTOs.SocialType;
using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Profiles
{
    public class MappingDomain : Profile
    {
        public MappingDomain()
        {
            CreateMap<SocialType, SocialTypeDto>().ReverseMap();
            CreateMap<SocialRequest, SocialRequestDto>().ReverseMap();
            CreateMap<SocialResult, SocialResultDto>().ReverseMap();
        }
    }
}
