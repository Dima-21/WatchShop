using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ImgInfo
    {

        public byte[] Img { get; set; }

        public string Folder { get; set; }

        public string TypeImg { get; set; }
    }
}
