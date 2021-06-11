using PicturesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicturesShop.ViewModels
{
    public class ViewPicturesModel
    {
        public List<Picture> Pictures { get; set; }

        public int NumberOfPictures { get; set; }
    }
}
