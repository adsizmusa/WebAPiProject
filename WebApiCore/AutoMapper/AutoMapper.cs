using AutoMapper;
using BussinesLayer.Entities;
using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.AutoMapper
{
    public class AutoMapper: Profile
    {
		public AutoMapper()
		{
			CreateMap<Member, MemberDTO>().ReverseMap();
			CreateMap<Order, OrderDTO>().ReverseMap();
			CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
			CreateMap<Brand, BrandDTO>().ReverseMap();
			CreateMap<Product, ProductDTO>().ReverseMap();



			//         CreateMap<HB.BO.WebAdmin.Pages, HB.BusinessDTO.WebAdmin.Pages>()
			//.ForMember(dto => dto.SectionsIDList, opt => opt.MapFrom(src => Newtonsoft.Json.JsonConvert.DeserializeObject<List<int>>(src.SectionsIDs)))
			// .ReverseMap()
			//    .ForMember(opt => opt.SectionsIDs, dto => dto.MapFrom(src => Newtonsoft.Json.JsonConvert.SerializeObject(src.SectionsIDList)));

		}
	}
}
