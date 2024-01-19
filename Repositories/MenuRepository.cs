using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject.Repositories;

public class MenuRepository(GraphQLDbContext context) : IMenuRepository
{

    public Menu Add(Menu menu)
    {
        menu.Id = default;
        context.Add(menu);
        context.SaveChanges();
        return menu;
    }

    public void Delete(int id)
    {
        var menu = context.Menus.Find(id);
        context.Menus.Remove(menu!);
        context.SaveChanges();
    }

    public List<Menu> GetAll()
    {
       return [..context.Menus.AsNoTracking()];
    }

    public Menu? GetById(int id)
    {
       return context.Menus.Find(id);
    }

    public Menu? Update(int id, Menu menu)
    {
        var update = context.Menus.Find(id)!;

        update.Name = menu.Name;
        update.Price = menu.Price;
        update.Description = menu.Description;

        context.Menus.Update(update);
        context.SaveChanges();
        return update;
    }
}