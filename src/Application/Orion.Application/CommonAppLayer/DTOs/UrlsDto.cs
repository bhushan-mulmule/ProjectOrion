using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.CommonAppLayer.DTOs
{
    public class UrlsDto
    {
        public ICollection<string> Urls { get; }

        public UrlsDto(ICollection<string> urls)
        {
            Urls = urls;
        }
    }
}
