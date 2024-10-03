// See https://aka.ms/new-console-template for more information
using AutoMapper;
using ConsoleAutoMapper_0.DomainEntities;
using ConsoleAutoMapper_0.DTOClasses;


MapperConfiguration configuration = new MapperConfiguration(x =>
{
    x.CreateMap<Category, CategoryDTO>().ReverseMap(); ;
  
});


IMapper mapper = configuration.CreateMapper();


CategoryDTO cdto = new CategoryDTO
{
    CategoryName = "Test",
    Description = "Test"
};


Category c = mapper.Map<Category>(cdto);

//_catRep.Add(mapper.Map<Category>(cdto));




Console.WriteLine($"{c.CategoryName}");
