using System;

namespace SOLID.LS.After
{
    public interface IVideoSocialMedia
    {
        void UploadVideo();
    }

    public interface IPhotoSocialMedia
    {
        void UploadPhoto();
    }
    
    public interface IBaseMediaManager
    {
        void Like();
        void Subscribe();
    }

    public class InstagramManager: IBaseMediaManager,IVideoSocialMedia,IPhotoSocialMedia
    {
        public void UploadVideo()
        {
            Console.WriteLine("Upload video");
        }

        public void Like()
        {
            Console.WriteLine("Send Like");
        }

        public void Subscribe()
        {
            Console.WriteLine("Subscribe");
        }

        public void UploadPhoto()
        {
            Console.WriteLine("Upload Photo");
        }
    }
    
    public class YouTubeManager: IBaseMediaManager,IVideoSocialMedia
    {
        public void UploadVideo()
        {
            Console.WriteLine("Upload video");
        }

        public void Like()
        {
            Console.WriteLine("Send Like");
        }

        public void Subscribe()
        {
            Console.WriteLine("Subscribe");
        }
    }
    
}