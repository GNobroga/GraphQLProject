using GraphQLProject.Mutation;
using GraphQLProject.Query;

namespace GraphQLProject.Schema;

public class MenuSchema : GraphQL.Types.Schema
{
    public MenuSchema(MenuQuery menuQuery, MenuMutation menuMutation)
    {
        Query = menuQuery;
        Mutation = menuMutation;
    }
}