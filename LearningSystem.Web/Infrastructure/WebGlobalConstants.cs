namespace LearningSystem.Web.Infrastructure
{
    public class WebGlobalConstants
    {
        public const string AdminArea = "Admin";
        public const string BlogArea = "Blog";
        public const string TrainerArea = "Trainer";


        public const string AdministratorRole = "Administrator";
        public const string TrainerRole = "Trainer";
        public const string AuthorRole = "Author";

        public const string UserPassword = "user123";
        public const string AdminPassword = "admin123";
        public const string TrainerPassword = "trainer123";
        public const string AuthorPassword = "author123";

        public const string TempDataSuccessMessageKey = "SuccessMessage";
        public const string TempDataErrorMessageKey = "ErrorMessage";

        public const string AuthenicatorUriFormat =
            "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
    }
}
