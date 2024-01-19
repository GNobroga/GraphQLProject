using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type;

public class MenuInputType : InputObjectGraphType
{
    public MenuInputType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("description");
        Field<FloatGraphType>("price");
    }
}