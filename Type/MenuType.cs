using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type;

public class MenuType : ObjectGraphType<Menu>
{
    public MenuType()
    {
        Field(x => x.Id);
        Field(x => x.Name);
        Field(x => x.Price);
        Field(x => x.Description);
    }
}