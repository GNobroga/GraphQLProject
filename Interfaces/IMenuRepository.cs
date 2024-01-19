using GraphQLProject.Models;

namespace GraphQLProject.Interfaces;

public interface IMenuRepository 
{
    List<Menu> Menus { get; }

    List<Menu> GetAll();

    Menu? GetById(int id);

    Menu Add(Menu menu);

    Menu? Update(int id, Menu menu);

    void Delete(int id);
}