using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface IMenuService : IBaseService<Menu>
    {
        void AddToMenu(Page page, string menuName = "Main");

        bool CheckIfPageExistsInMenu(Page page, string menuName = "Main");

        Menu GetMainMenu();

        void RemoveFromMenu(Page page, string menuName = "Main");
    }
}