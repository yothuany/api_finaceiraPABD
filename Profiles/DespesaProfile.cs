using AutoMapper;
using ApiFinanceiro.Dtos;
using ApiFinanceiro.Models;

namespace ApiFinanceiro.Profiles
{
    public class DespesaProfile: Profile
    {
        public DespesaProfile()
        {
            CreateMap<DespesaDto, Despesa>()
                .ForMember(dest => dest.Situacao,
                opt => opt.MapFrom(scr => "pendente")
                );

            CreateMap<DespesaUpdateDto, Despesa>()
                .ForMember(dest => dest.DataPagamento,
                opt => opt.MapFrom(src => src.DataPagamento.ToDateTime(TimeOnly.FromDateTime(DateTime.Now))
                )
                );


        }
    }
}
