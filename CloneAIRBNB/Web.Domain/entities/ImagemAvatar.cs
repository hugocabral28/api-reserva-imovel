using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Domain.entities
{
    public class ImagemAvatar
    {
        public string Img { get; set; }

        public ImagemAvatar()
        {
            Img = "https://some-random-api.ml/img/dog";
        }
    }
}