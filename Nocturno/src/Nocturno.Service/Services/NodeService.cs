using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class NodeService : BaseService<Node>, INodeService
    {
        public NodeService(IDbContext db) : base(db)
        {
        }

        public Node GetNode(int pageId, int sectionId)
        {
            var node = _db.Nodes.FirstOrDefault(x => x.PageId == pageId && x.SectionId == sectionId);
            return node;
        }
    }
}