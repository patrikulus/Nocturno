using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Remotion.Linq.Clauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class MenuService : BaseService<Menu>, IMenuService
    {
        private const string MainMenu = "Main";

        public MenuService(IDbContext db) : base(db)
        {
        }

        public void AddToMenu(Page page, string menuName = MainMenu)
        {
            var menu = GetMenuByName(menuName);
            var item = _db.MenuItems.FirstOrDefault(x => x.MenuId == GetMenuId(menuName) && x.Name == page.Name);
            if (!CheckIfPageExistsInMenu(page))
            {
                _db.MenuItems.Add(new MenuItem
                {
                    MenuId = menu.Id,
                    Name = page.Name,
                    Hyperlink = CreateHyperlink(page.Name),
                    Order = _db.MenuItems.Count() + 1
                });
            }
        }

        public bool CheckIfPageExistsInMenu(Page page, string menuName = MainMenu)
        {
            var menuId = GetMenuId(menuName);
            var exists = _db.MenuItems.Where(x => x.MenuId == menuId && x.Name == page.Name);

            return exists.Any();
        }

        public Menu GetMainMenu()
        {
            var menu = _db.Menus.Include(x => x.MenuItems).FirstOrDefault(x => x.Name == MainMenu);
            return menu;
        }

        public void RemoveFromMenu(Page page, string menuName = "Main")
        {
            var item = _db.MenuItems.FirstOrDefault(x => x.MenuId == GetMenuId(menuName) && x.Name == page.Name);
            if (item != null)
            {
                _db.MenuItems.Remove(item);
            }
        }

        private string CreateHyperlink(string pageName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("~/").Append(pageName);
            return sb.ToString();
        }

        private Menu GetMenuByName(string menuName)
        {
            var menu = _db.Menus.FirstOrDefault(x => x.Name == menuName);
            return menu ?? null;
        }

        private int GetMenuId(string menuName)
        {
            var menu = _db.Menus.FirstOrDefault(x => x.Name == menuName);
            if (menu == null)
            {
                return 0;
            }
            return menu.Id;
        }
    }
}