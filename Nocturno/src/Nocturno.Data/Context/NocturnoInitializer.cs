using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Nocturno.Data.Context
{
    public class NocturnoInitializer : IDbInitializer
    {
        private readonly IDbContext _db;

        public NocturnoInitializer(IDbContext db)
        {
            _db = db;
        }

        public void InitializeDatabase()
        {
            if (!_db.Settings.Any())
            {
                var settings = new List<Setting>
                {
                    new Setting {Name = "Site name", Value = "Nocturno CMS Site"},
                    new Setting {Name = "Site theme", Value = "default.css"},
                    new Setting {Name = "Admin theme", Value = "default.css"},
                };
                _db.Settings.AddRange(settings);
                _db.SaveChanges();
            }

            if (!_db.Sections.Any())
            {
                var sections = new List<Section>
                {
                    new Section { Name = "Navigation"},
                    new Section { Name = "Header Top"},
                    new Section { Name = "Header Bottom"},
                    new Section { Name = "Breadcrumb"},
                    new Section { Name = "Main Top"},
                    new Section { Name = "Main Middle"},
                    new Section { Name = "Main Bottom"},
                    new Section { Name = "Left sidebar"},
                    new Section { Name = "Right sidebar"},
                    new Section { Name = "Footer Top"},
                    new Section { Name = "Footer Bottom"},
                };
                _db.Sections.AddRange(sections);
                _db.SaveChanges();
            }

            if (!_db.Menus.Any())
            {
                _db.Menus.Add(new Menu
                {
                    Name = "Main",
                    SectionId = _db.Sections.FirstOrDefault(x => x.Name == "Navigation").Id
                });
                _db.SaveChanges();
            }

            if (!_db.Services.Any())
            {
                _db.Services.Add(new Service
                {
                    Name = "Hello Service",
                    ServiceType = "Big Icon"
                });
                _db.SaveChanges();
            }

            if (!_db.ServiceItems.Any())
            {
                var serviceItems = new List<ServiceItem>
                {
                    new ServiceItem
                    {
                        Name = "First item",
                        Synopsis = "This is first service item.",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore" +
                               " et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut " +
                               "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                               "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
                               "officia deserunt mollit anim id est laborum.",
                        Title = "First item title",
                        Hyperlink = "#",
                        Icon = "fa-mixcloud",
                        ServiceId = 1
                    },
                    new ServiceItem
                    {
                        Name = "Second item",
                        Synopsis = "This is second <b>service</b> item.",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore" +
                               " et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut " +
                               "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                               "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
                               "officia deserunt mollit anim id est laborum.",
                        Title = "First item title",
                        Hyperlink = "#",
                        Icon = "fa-archive",
                        ServiceId = 1
                    },
                    new ServiceItem
                    {
                        Name = "Third item",
                        Synopsis = "This is <i>third</i> service item.",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore" +
                               " et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut " +
                               "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                               "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
                               "officia deserunt mollit anim id est laborum.",
                        Title = "First item title",
                        Hyperlink = "#",
                        Icon = "fa-bank",
                        ServiceId = 1
                    }
                };
                _db.ServiceItems.AddRange(serviceItems);
                _db.SaveChanges();
            }
        }
    }
}