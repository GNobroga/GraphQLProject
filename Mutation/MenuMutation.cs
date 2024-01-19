using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation;

public class MenuMutation : ObjectGraphType
{


    public MenuMutation(IMenuRepository menuRepository)
    {

        /*
            type Mutation {
                createMenu(input: ): MenuType
                updateMenu(id: Int data: MenuInputType): MenuType
                deleteMenu(id: Int)
            }
        */
        Field<MenuType>("createMenu")
            .Argument(typeof(MenuInputType), "data")
            .Resolve(context => {
               var menu = context.GetArgument<Menu>("data");
               return menuRepository.Add(menu);
            });

        Field<MenuType>("updateMenu")
            .Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }, new QueryArgument<MenuInputType> { Name = "data" }))
            .Resolve(context => {
                var menu = context.GetArgument<Menu>("data");
                var id = context.GetArgument<int>("id");
               return menuRepository.Update(id, menu);
            });

        Field<BooleanGraphType>("deleteMenu")
            .Argument(typeof(IntGraphType), "id")
            .Resolve(context => {
                var id = context.GetArgument<int>("id");
                menuRepository.Delete(id);
                return true;
            });
    }
}