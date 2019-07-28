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
        public int Id { get; set; }
        public byte[] Img { get; set; }

        public string TypeImg { get; set; }
    }
}
