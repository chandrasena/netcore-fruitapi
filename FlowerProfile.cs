using AutoMapper;
using fruit_api.Models;
using fruit_api.ViewModels;

public class FlowerProfile : Profile {
    public FlowerProfile()
    {
        CreateMap<Flower, FlowerViewModel>();
    }
}