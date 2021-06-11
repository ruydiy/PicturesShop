namespace PicturesShop.Models.AdminController
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MessagesSuccess
    {
        public string CreatePicture => "Picture has been created successfully!";
        public string EditPicture => "Picture has been edited successfully!";
        public string PicturePainterConnected => "Picture has been connected to painter successfully!";
        public string PicturePainterDisconnected => "Picture has been desconnected from painter successfully!";

    }
}
