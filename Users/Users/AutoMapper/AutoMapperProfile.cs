using AutoMapper;
using Users.Contract.Model;
using Users.ModelView;

namespace Users.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserGet>();            
        }
    }
}
