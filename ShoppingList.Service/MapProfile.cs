//using AutoMapper;
//using Librarians.Common.Dto;
//using Librarians.Repository.Entities;
//using Librarians.Service.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Linq;
//using Librarians.Service.Services;

//namespace Librarians.Service
//{
//    public class MapProfile : Profile
//    {
//        //private readonly IBorrowingService<BorrowingDto> _borrowingService;

//        //public MapProfile(IBorrowingService<BorrowingDto> bs)
//        public MapProfile()
//        {
//            //_borrowingService = bs;
//            CreateMap<Item, ItemDto>()
//.ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.ItemTag.Select(it => it.TagId)))
//.ForMember(dest => dest.Fname, opt => opt.MapFrom(src => src.User.Fname))
//    .ForMember(dest => dest.Sname, opt => opt.MapFrom(src => src.User.Sname))
//.ReverseMap()
//.ForMember(dest => dest.ItemTag, opt => opt.MapFrom(src => src.Tags.Select(tagId => new ItemTag { TagId = tagId })));
//            CreateMap<Item, PostItem>()
//     .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.ItemTag.Select(it => it.TagId)))
//     .ForMember(dest => dest.FilePath, opt => opt.Ignore())
//     .ReverseMap()
//     .ForMember(dest => dest.ItemTag, opt => opt.MapFrom(src => src.Tags.Select(tagId => new ItemTag { TagId = tagId })))
//.ForMember(dest => dest.FilePath, opt => opt.Ignore());
//            CreateMap<Item, PostBookItem>()
//.ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.ItemTag.Select(it => it.TagId)))
//.ReverseMap()
//.ForMember(dest => dest.ItemTag, opt => opt.MapFrom(src => src.Tags.Select(tagId => new ItemTag { TagId = tagId })));

//            CreateMap<Item, PostPhysicalItem>()
//.ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.ItemTag.Select(it => it.TagId)))
//.ReverseMap()
//.ForMember(dest => dest.ItemTag, opt => opt.MapFrom(src => src.Tags.Select(tagId => new ItemTag { TagId = tagId })));

//            CreateMap<AddNewRequests, AddNewRequestDto>()
//.ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.addNewRequestsTags.Select(it => it.TagId)))
//.ReverseMap()
//.ForMember(dest => dest.addNewRequestsTags, opt => opt.MapFrom(src => src.Tags.Select(tagId => new AddNewRequestsTag { TagId = tagId })));
           
//            CreateMap<AddNewRequests, PostAddNewRequest>()
//     .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.addNewRequestsTags.Select(it => it.TagId)))
//     .ForMember(dest => dest.FilePath, opt => opt.Ignore())
//     .ReverseMap()
//     .ForMember(dest => dest.addNewRequestsTags, opt => opt.MapFrom(src => src.Tags.Select(tagId => new AddNewRequestsTag { TagId = tagId })))
//.ForMember(dest => dest.FilePath, opt => opt.Ignore());
         
//            CreateMap<AddNewRequests, PostBookAddNewRequest>()
//.ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.addNewRequestsTags.Select(it => it.TagId)))
//.ReverseMap()
//.ForMember(dest => dest.addNewRequestsTags, opt => opt.MapFrom(src => src.Tags.Select(tagId => new AddNewRequestsTag { TagId = tagId })));



//            CreateMap<Task<Item>, Task<ItemDto>>().ReverseMap();
//            CreateMap<Task<List<Item>>, Task<List<ItemDto>>>().ReverseMap();
//            CreateMap<Task<Item>, Task<PostItem>>().ReverseMap();

//            CreateMap<Task<AddNewRequests>, Task<AddNewRequestDto>>().ReverseMap();
//            CreateMap<Task<List<AddNewRequests>>, Task<List<AddNewRequestDto>>>().ReverseMap();
//            CreateMap<Task<AddNewRequests>, Task<PostAddNewRequest>>().ReverseMap();

//            CreateMap<Tag, TagDto>().ReverseMap();
//            CreateMap<Task<Tag>, Task<TagDto>>().ReverseMap();
//            CreateMap<Task<List<Tag>>, Task<List<TagDto>>>().ReverseMap();

//            CreateMap<Borrowing, BorrowingDto>().ReverseMap();

//            CreateMap<Borrowing, BorrowingWithDetails>()
//            .ForMember(dest => dest.LibrarianFname, opt => opt.MapFrom(src => src.Librarian.Fname))
//            .ForMember(dest => dest.LibrarianSname, opt => opt.MapFrom(src => src.Librarian.Sname))
//            .ForMember(dest => dest.LibrarianEmail, opt => opt.MapFrom(src => src.Librarian.Email))
//            .ForMember(dest => dest.LibrarianPhoneNumber, opt => opt.MapFrom(src => src.Librarian.PhoneNumber))
//            .ForMember(dest => dest.LibrarianRole, opt => opt.MapFrom(src => src.Librarian.Role))
//            .ForMember(dest => dest.StudentFname, opt => opt.MapFrom(src => src.Student.Fname))
//            .ForMember(dest => dest.StudentSname, opt => opt.MapFrom(src => src.Student.Sname))
//            .ForMember(dest => dest.StudentEmail, opt => opt.MapFrom(src => src.Student.Email))
//            .ForMember(dest => dest.StudentPhoneNumber, opt => opt.MapFrom(src => src.Student.PhoneNumber))
//            .ForMember(dest => dest.ItemTitle, opt => opt.MapFrom(src => src.Book.Title))
//            .ForMember(dest => dest.ItemType, opt => opt.MapFrom(src => src.Book.ItemType))
//            .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
//            .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks));
//            CreateMap<Task<Borrowing>, Task<BorrowingWithDetails>>().ReverseMap();
//            CreateMap<Task<List<Borrowing>>, Task<List<BorrowingWithDetails>>>().ReverseMap();

//            CreateMap<BorrowRequest, BorrowRequestDto>()
//           .ForMember(dest => dest.ItemTitle, opt => opt.MapFrom(src => src.Item.Title))
//           .ForMember(dest => dest.ItemType, opt => opt.MapFrom(src => src.Item.ItemType))
//           .ForMember(dest => dest.StudentFname, opt => opt.MapFrom(src => src.User.Fname))
//           .ForMember(dest => dest.StudentSname, opt => opt.MapFrom(src => src.User.Sname))
//           .ForMember(dest => dest.StudentEmail, opt => opt.MapFrom(src => src.User.Email))
//           .ForMember(dest => dest.StudentPhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
//           .ForMember(dest => dest.StudentTZ, opt => opt.MapFrom(src => src.User.tz));
//           //.ForMember(dest => dest.StudentRequestCount, opt => opt.MapFrom(src => _context.Borrow_Requests.Count(br => br.UserId == src.UserId)));

//            CreateMap<Task<Borrowing>, Task<BorrowingDto>>().ReverseMap();
//            CreateMap<Task<List<Borrowing>>, Task<List<BorrowingDto>>>().ReverseMap();

            
//        }
//    } 
//}


