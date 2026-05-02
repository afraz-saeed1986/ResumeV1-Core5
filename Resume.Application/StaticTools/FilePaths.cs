
using System.IO;


namespace Resume.Application.StaticTools
{
    public static class FilePaths
    {
        #region Base Image Paths
        public static readonly string BaseImagePath = "/content/images/";
        public static readonly string BaseImagePathServer = $"wwwroot{BaseImagePath}";
        #endregion

        #region default
        public static readonly string DefaultAvatar = $"{BaseImagePath}/default/default-avatar.png";
        #endregion

        #region Customer Feedback Avatar
        public static readonly string CustomerFeedbackAvatar = $"{BaseImagePath}/customer-feedback-avatar/origin/";
        public static readonly string CustomerFeedbackAvatarServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/customer-feedback-avatar/origin/");
        #endregion
    }
}
