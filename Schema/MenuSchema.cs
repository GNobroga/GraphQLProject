using GraphQLProject.Query;

namespace GraphQLProject.Schema;

public class MenuSchema : GraphQL.Types.Schema
{
    public MenuSchema(MenuQuery menuQuery)
    {
        Query = menuQuery;
    }
}