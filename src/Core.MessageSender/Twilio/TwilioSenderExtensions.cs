using Twilio;

namespace Core.MessageSender.Twilio
{
    public static class TwilioSenderExtensions
    {
        public static void InitTwilioClient(string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);
        }
    }
}
