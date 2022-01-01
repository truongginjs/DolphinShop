using AutoMapper;
using WebApi.DTOs.Requests;
using WebApi.DTOs.Requests.Auth;
using WebApi.DTOs.Responses;
using WebApi.DTOs.Responses.Auth;
using WebApi.Models;

namespace WebApi
{

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Comment
            CreateMap<Comment, CommentResDTO>();
            CreateMap<CommentReqDTO, Comment>();
            // .ForMember(des => des.GroupType,
            // act => act.MapFrom(src => src.GroupType.ToString()));
            #endregion
            #region Media
            CreateMap<Media, MediaResDTO>();
            CreateMap<MediaReqDTO, Media>();
            #endregion

            #region Post
            CreateMap<Post, PostResDTO>();
            CreateMap<PostReqDTO, Post>();
            #endregion

            #region Role
            CreateMap<Role, RoleResDTO>();
            CreateMap<RoleReqDTO, Role>();
            #endregion

            #region Tag
            CreateMap<Tag, TagResDTO>();
            CreateMap<TagReqDTO, Tag>();
            #endregion

            #region User
            CreateMap<User, UserResDTO>();
            CreateMap<UserReqDTO, User>();

            CreateMap<UserRegisterReqDTO, User>();

            CreateMap<User, UserDataResDTO>();

            #endregion
        }
    }
}