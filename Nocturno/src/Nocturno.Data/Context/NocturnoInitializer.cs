using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}