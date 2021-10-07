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
            #region Type mappings
            CreateMap<SocialType, SocialTypeDto>().ReverseMap();
            CreateMap<SocialType, CreateSocialTypeDto>().ReverseMap();
            #endregion

            #region Request mappings
            CreateMap<SocialRequest, SocialRequestDto>().ReverseMap();
            CreateMap<SocialRequest, CreateSocialRequestDto>().ReverseMap();
            CreateMap<SocialRequest, UpdateSocialRequestDto>().ReverseMap();
            #endregion

            #region Result mappings
            CreateMap<SocialResult, SocialResultDto>().ReverseMap();
            CreateMap<SocialResult, CreateSocialResultDto>().ReverseMap();
            CreateMap<SocialResult, UpdateSocialResultDto>().ReverseMap();
            #endregion
        }
    }
}
