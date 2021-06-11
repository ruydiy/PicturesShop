namespace PicturesShop.Models.AdminController
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MessageFailed
    {
        public string CreatePicture => "Failed to create picture!";
        public string EditPicture => "Failed to edit picture!";
        public string PicturePainterConnected => "Failed to connect painter to picture!";
        public string PicturePainterDisconnected => "Failed to disconnect painter from picture!!";

    }
}
