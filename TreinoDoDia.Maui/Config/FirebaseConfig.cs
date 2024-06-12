using Firebase.Auth;
using Firebase.Auth.Providers;

namespace TreinoDoDia.Maui.Config
{
    public class FirebaseConfig
    {
        public FirebaseAuthClient FirebaseClient { get; set; }
        public FirebaseConfig()
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyDCSprLGP0sSS6XyUW4yg0Ra2-xcZbV_eQ",
                AuthDomain = "treino-do-dia-768e8.firebaseapp.com",
                Providers =
                [
                    new EmailProvider()
                ],
            };
            if (config == null) throw new ArgumentNullException(nameof(config));
            FirebaseClient = new FirebaseAuthClient(config);
        }
    }
}
