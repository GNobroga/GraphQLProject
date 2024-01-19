using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query;

public class MenuQuery : ObjectGraphType
{
    public MenuQuery(IMenuRepository menuRepository)
    {
        Field<ListGraphType<MenuType>>("menus").Resolve(context => {
            return menuRepository.GetAll();
        });

        Field<MenuType>("menu")
            .Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }))
            .Resolve(context => {
                var id = context.GetArgument<int>("id");
                return menuRepository.GetById(id);
            });
    }
}