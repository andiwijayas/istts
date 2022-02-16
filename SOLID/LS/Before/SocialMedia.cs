using System;

namespace SOLID.LS.Before
{
    public interface ISocialMediaManager
    {
        void UploadVideo();
        void Like();
        void Subscribe();
        void UploadPhoto();
    }

    public class InstagramManager: ISocialMediaManager
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
    
    public class YouTubeManager: ISocialMediaManager
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
            throw new NotImplementedException();
        }
    }
    
}