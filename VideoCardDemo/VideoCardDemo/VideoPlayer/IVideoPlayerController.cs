using System;

namespace TiqsVendor.Core.VideoPlayer
{ 
    public interface IVideoPlayerController
    {
        VideoStatus Status { set; get; }

        TimeSpan Duration { set; get; }
    }
}
