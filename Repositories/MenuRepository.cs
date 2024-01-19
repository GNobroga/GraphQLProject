using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Repositories;

public class MenuRepository : IMenuRepository
{
    public List<Menu> Menus => [
        new Menu { Id = 1, Name = "Classic Burger", Description = "A juicy char-grilled beef patty with lettuce, tomato, and special sauce on a sesame seed bun." },
        new Menu { Id = 2, Name = "Vegetarian Delight", Description = "Grilled portobello mushroom topped with fresh vegetables, avocado, and a savory herb spread on a whole wheat bun." },
        new Menu { Id = 3, Name = "Spicy Chicken Sandwich", Description = "Crispy fried chicken breast with spicy mayo, lettuce, and pickles on a toasted brioche bun." },
        new Menu { Id = 4, Name = "Mouthwatering BBQ Ribs", Description = "Slow-cooked pork ribs glazed with tangy barbecue sauce, served with coleslaw and seasoned fries." },
        new Menu { Id = 5, Name = "Pesto Pasta Primavera", Description = "Penne pasta tossed in a creamy pesto sauce with a medley of fresh vegetables and grated Parmesan cheese." }
    ];

    public Menu Add(Menu menu)
    {
        menu.Id = Menus.Count + 1;
        Menus.Add(menu);
        return menu;
    }

    public void Delete(int id)
    {
        Menus.RemoveAt(id - 1);
    }

    public List<Menu> GetAll()
    {
        return Menus;
    }

    public Menu? GetById(int id)
    {
       return Menus.Find(x => x.Id == id);
    }

    public Menu? Update(int id, Menu menu)
    {
        var update = Menus.Find(x => x.Id == id)!;

        update.Name = menu.Name;
        update.Price = menu.Price;
        update.Description = menu.Description;

        return update;
    }
}