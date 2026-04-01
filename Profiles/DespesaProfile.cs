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
       
        }
    }
}
