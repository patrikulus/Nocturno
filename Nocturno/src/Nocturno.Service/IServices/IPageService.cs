using Nocturno.Data.Models;
using System.Collections.Generic;

namespace Nocturno.Service.IServices
{
    public interface IPageService : IBaseService<Page>
    {
        IDictionary<string, Node> GetNodesDictionary(string name);
    }
}