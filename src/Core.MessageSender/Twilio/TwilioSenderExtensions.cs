using Twilio;

namespace Core.MessageSender.Twilio
{
    /// <summary>
    /// This class contains static method for TwilioClient initialization
    /// </summary>
    public static class TwilioSenderExtensions
    {
        public static void InitTwilioClient(string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);
        }
    }
}
