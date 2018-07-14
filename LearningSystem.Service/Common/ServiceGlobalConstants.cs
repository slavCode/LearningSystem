namespace LearningSystem.Service.Common
{
    public static class ServiceGlobalConstants
    {
        // Only 3 for test. 
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

        public const int ArticlesPageSize = 6;
        public const int CoursesPageSize = 3;
        public const int UsersPageSize = 3;

        public const string Html =
            @"<div align=""center"">
                 <h1>COURSE CERTIFICATE</h1>
                    <br />
                   <small>This is certificate is issued by Learning System</small>
                    <br />
                    <h3>{3}</h3>
                     <small>has successfully completed a course</small>
                      <br />
                     <h3>{0}</h3>
                 <small>{1} - {2}</small>
                      <br/>
                    <h4>with grade <strong>{4}</strong></h4>
                     <br />
                        <div style=""float: right"">
                          Training and inspiration: <strong>{5}</strong>
                        </div>
                        <div style = ""float: left"" >
                          <em>Issue Date: <strong>{6}</strong></em>
                        </div>";
    }
}
