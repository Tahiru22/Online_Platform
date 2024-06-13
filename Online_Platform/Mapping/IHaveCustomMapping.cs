using AutoMapper;

namespace Online_Platform.Mapping
{
    public interface IHaveCustomMapping
    {
        void ConfigureMapping(IProfileExpression mapper);
    }
}
