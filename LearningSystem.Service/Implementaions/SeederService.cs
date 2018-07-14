namespace LearningSystem.Service.Implementaions
{
    using Data;
    using Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static Common.ServiceGlobalConstants;


    public class SeederService : ISeederService
    {
        private readonly LearningSystemDbContext db;

        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public SeederService(LearningSystemDbContext db, IServiceScope serviceScope)
        {
            this.db = db;
            this.roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
            this.userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
        }

        public async Task RolesAsync()
        {
            var roleNames = new[]
            {
                AdministratorRole,
                AuthorRole,
                TrainerRole
            };

            foreach (var roleName in roleNames)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = roleName
                    });
                }
            }
        }

        public async Task UsersAsync()
        {
            var username = "Admina";

            var adminUser = await userManager.FindByNameAsync(username);

            if (adminUser == null)
            {
                adminUser = new User
                {
                    Email = "admin@admin.com",
                    UserName = username,
                    Name = "Admin Adminov"
                };

                await userManager.CreateAsync(adminUser, AdminPassword);

                await userManager.AddToRoleAsync(adminUser, AdministratorRole);
            }

            username = "Krumcho";
            var trainerUser = await userManager.FindByNameAsync(username);

            if (trainerUser == null)
            {
                trainerUser = new User
                {
                    Email = "krum@trainer.com",
                    UserName = username,
                    Name = "Krum Haralpiev"
                };

                await userManager.CreateAsync(trainerUser, TrainerPassword);

                await userManager.AddToRoleAsync(trainerUser, TrainerRole);
            }

            username = "Evstati";
            var trainer1User = await userManager.FindByNameAsync(username);

            if (trainer1User == null)
            {
                trainer1User = new User
                {
                    Email = "evstati@trainer.com",
                    UserName = username,
                    Name = "Evstati Prokopiev"
                };

                await userManager.CreateAsync(trainer1User, TrainerPassword);

                await userManager.AddToRoleAsync(trainer1User, TrainerRole);
            }

            username = "Ivo";
            var trainer2User = await userManager.FindByNameAsync(username);

            if (trainer2User == null)
            {
                trainer2User = new User
                {
                    Email = "ivelin@trainer.com",
                    UserName = username,
                    Name = "Ivelin Velkov"
                };

                await userManager.CreateAsync(trainer2User, TrainerPassword);

                await userManager.AddToRoleAsync(trainer2User, TrainerRole);
            }

            username = "Penka";
            var authorUser = await userManager.FindByNameAsync(username);

            if (authorUser == null)
            {
                authorUser = new User
                {
                    Email = "penka@author.com",
                    UserName = username,
                    Name = "Pena Peneva"
                };

                await userManager.CreateAsync(authorUser, AuthorPassword);

                await userManager.AddToRoleAsync(authorUser, AuthorRole);
            }

            username = "Veli";
            var author1User = await userManager.FindByNameAsync(username);

            if (author1User == null)
            {
                author1User = new User
                {
                    Email = "velina@author.com",
                    UserName = username,
                    Name = "Velina Krasteva"
                };

                await userManager.CreateAsync(author1User, AuthorPassword);

                await userManager.AddToRoleAsync(author1User, AuthorRole);
            }

            username = "Ema";
            var author2User = await userManager.FindByNameAsync(username);

            if (author2User == null)
            {
                author2User = new User
                {
                    Email = "emanuela@author.com",
                    UserName = username,
                    Name = "Emanuela Paraskeva"
                };

                await userManager.CreateAsync(author2User, AuthorPassword);

                await userManager.AddToRoleAsync(author2User, AuthorRole);
            }

            username = "Ivancho";
            var user1 = await userManager.FindByNameAsync(username);

            if (user1 == null)
            {
                user1 = new User
                {
                    Email = "ivan@gmail.com",
                    UserName = username,
                    Name = "Ivan Ivanov"
                };

                await userManager.CreateAsync(user1, UserPassword);
            }

            username = "Pesho";
            var user2 = await userManager.FindByNameAsync(username);

            if (user2 == null)
            {
                user2 = new User
                {
                    Email = "pesho@gmail.com",
                    UserName = username,
                    Name = "Petar Petrov"
                };

                await userManager.CreateAsync(user2, UserPassword);
            }

            username = "Gosho";
            var user3 = await userManager.FindByNameAsync(username);

            if (user3 == null)
            {
                user3 = new User
                {
                    Email = "georgi@gmail.com",
                    UserName = username,
                    Name = "Georgi Georgiev"
                };

                await userManager.CreateAsync(user3, UserPassword);
            }

            username = "Svilkata";
            var user4 = await userManager.FindByNameAsync(username);

            if (user4 == null)
            {
                user4 = new User
                {
                    Email = "svilen@gmail.com",
                    UserName = username,
                    Name = "Svilen Svilenov"
                };

                await userManager.CreateAsync(user4, UserPassword);
            }

            username = "Niki";
            var user5 = await userManager.FindByNameAsync(username);

            if (user5 == null)
            {
                user5 = new User
                {
                    Email = "nikolai@gmail.com",
                    UserName = username,
                    Name = "Nikolai Nikolov"
                };

                await userManager.CreateAsync(user5, UserPassword);
            }

            username = "Mimi";
            var user6 = await userManager.FindByNameAsync(username);

            if (user6 == null)
            {
                user6 = new User
                {
                    Email = "maria@gmail.com",
                    UserName = username,
                    Name = "Maria Marieva"
                };

                await userManager.CreateAsync(user6, UserPassword);
            }

            username = "Gerito";
            var user7 = await userManager.FindByNameAsync(username);

            if (user7 == null)
            {
                user7 = new User
                {
                    Email = "gergana@gmail.com",
                    UserName = username,
                    Name = "Gergana Georgieva"
                };

                await userManager.CreateAsync(user7, UserPassword);
            }

            username = "Milenka";
            var user8 = await userManager.FindByNameAsync(username);

            if (user8 == null)
            {
                user8 = new User
                {
                    Email = "milena@gmail.com",
                    UserName = username,
                    Name = "Milena Mileva"
                };

                await userManager.CreateAsync(user8, UserPassword);
            }

            username = "Ani";
            var user9 = await userManager.FindByNameAsync(username);

            if (user9 == null)
            {
                user9 = new User
                {
                    Email = "anelia@gmail.com",
                    UserName = username,
                    Name = "Anelia Aneva"
                };

                await userManager.CreateAsync(user9, UserPassword);
            }

            username = "Margo";
            var user10 = await userManager.FindByNameAsync(username);

            if (user10 == null)
            {
                user10 = new User
                {
                    Email = "margarita@gmail.com",
                    UserName = username,
                    Name = "Margarita Markova"
                };

                await userManager.CreateAsync(user10, UserPassword);
            }
        }

        public async Task CoursesAsync()
        {
            var trainerIds = await this.GetTrainersIdsAsync();

            var name = "Scratch programming";
            bool exists;

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "A practical programming course for office workers, academics, and administrators who want to improve their productivity.";

                var startDate = new DateTime(2018, 09, 09);
                var trainerId = trainerIds.ElementAt(0);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                                                 startDate, trainerId);
            }

            name = "Programming for Beginners";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "Learn the basic concepts of programming using Python and JavaScript.";

                var startDate = new DateTime(2018, 11, 09);
                var trainerId = trainerIds.ElementAt(1);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "Learn Java Programming";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "Complete Guide to learning how to program in Java. Go from Beginner to Advanced level in Java with coding exercises!";

                var startDate = new DateTime(2018, 10, 19);
                var trainerId = trainerIds.ElementAt(2);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "A Gentle Introduction to Python";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "Python programming made easy and taught step by step. Learn by doing as you go from basics to advanced concepts.";

                var startDate = new DateTime(2018, 06, 11);
                var trainerId = trainerIds.ElementAt(0);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "Intrective Programming in Python";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "A Python Practical Programming Course for Absolute Beginners - Learn how to Code in Python and Improve your Productivity.";

                var startDate = new DateTime(2018, 06, 01);
                var trainerId = trainerIds.ElementAt(1);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "Android App Development";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "App development. Programming Language.";

                var startDate = new DateTime(2018, 07, 02);
                var trainerId = trainerIds.ElementAt(2);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "Learn to Program with C++";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "Take your C++ Programming to the next level.";

                var startDate = new DateTime(2017, 07, 02);
                var trainerId = trainerIds.ElementAt(0);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "Programming from Scratch";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "etworking course with fundamental concepts in depth with TCP/UDP/HTTP Socket Programming for beginners to expert.";

                var startDate = new DateTime(2017, 09, 02);
                var trainerId = trainerIds.ElementAt(1);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }

            name = "Java Programming For Dummies";

            exists = await this.CourseExistsAsync(name);
            if (!exists)
            {
                const string description =
                    "A single course to learn all Java programming concepts.";

                var startDate = new DateTime(2018, 01, 08);
                var trainerId = trainerIds.ElementAt(2);

                await this.CreateCourseAsync(name, description, startDate.AddMonths(2),
                    startDate, trainerId);
            }
        }

        public async Task UsersInCourses()
        {
            var randomUsers = this.GetAllUsersIdsAsync().Result.OrderBy(u => Guid.NewGuid()).ToArray();
            var coursesIds = await this.GetAllCoursesIdsAsync();

            foreach (var coursesId in coursesIds)
            {
                await this.AddUsersInCourseAsync(coursesId, randomUsers);
            }
        }

        public async Task ArticlesAsync()
        {
            var authorsIds = await this.GetAuthorsIdsAsync();
            var title = "Taking a second look at the learn-to-code craze.";

            var exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"Over the past five years, the idea that computer programming – or “coding” – is the key to the future for both children and adults alike has become received wisdom in the United States. The aim of making computer science a “new basic” skill for all Americans has driven the formation of dozens of nonprofit organizations, coding schools and policy programs.

            As the third annual Computer Science Education Week begins, it is worth taking a closer look at this recent coding craze.The Obama administration’s “Computer Science For All” initiative and the Trump administration’s new effort are both based on the idea that computer programming is not only a fun and exciting activity, but a necessary skill for the jobs of the future.

                However, the American history of these education initiatives shows that their primary beneficiaries aren’t necessarily students or workers, but rather the influential tech companies that promote the programs in the first place.The current campaign to teach American kids to code may be the latest example of tech companies using concerns about education to achieve their own goals. This raises some important questions about who stands to gain the most from the recent computer science push.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(0));
            }

            title = "Moving toward computing at the speed of thought.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"The first computers cost millions of dollars and were locked inside rooms equipped with special electrical circuits and air conditioning. The only people who could use them had been trained to write programs in that specific computer’s language. Today, gesture-based interactions, using multitouch pads and touchscreens, and exploration of virtual 3D spaces allow us to interact with digital devices in ways very similar to how we interact with physical objects.

This newly immersive world not only is open to more people to experience; it also allows almost anyone to exercise their own creativity and innovative tendencies. No longer are these capabilities dependent on being a math whiz or a coding expert: Mozilla’s “A-Frame” is making the task of building complex virtual reality models much easier for programmers. And Google’s “Tilt Brush” software allows people to build and edit 3D worlds without any programming skills at all.

My own research hopes to develop the next phase of human-computer interaction. We are monitoring people’s brain activity in real time and recognizing specific thoughts (of “tree” versus “dog” or of a particular pizza topping). It will be yet another step in the historical progression that has brought technology to the masses – and will widen its use even more in the coming years.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(1));
            }

            title = "How to keep more girls in IT at schools if we’re to close the gender gap.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"The world is increasingly embracing digital technology, and so too are our schools. But many girls are still missing out on developing IT and programming skills.

IT classes in schools mostly focus on basic skills, such as how to use email or spreadsheets, or use tablets to access online quizzes and educational games. Programming and algorithm-based problem solving don’t form a part of the typical school day. They tend to get taught only in extra-curricular classes, such as coding clubs.

But these tend to attract kids who’ve already expressed an interest in technology and want to learn more. The students who don’t know what coding is, or who don’t identify with computer culture (often in the form of computer gaming), are less inclined to participate in these extra-curricular clubs.

This kind of opt-in training means many girls are missing out, particularly if they perceive IT to be a pastime for boys.

Gender stereotyping of toys may also push girls away from technical interests. Parents tend to buy gadgets for boys more than for girls, as suggested in the United States by a National Public Radio story on plunging numbers of women studying computer science.

Or girls may not be as interested in computer games due to the lack of female protagonists, as argued eloquently by 15-year-old student – and coding teacher – Ankita Mitra. Or perhaps girls simply don’t feel welcome in these clubs.

A recent report on female participation in computing from Australia’s Digital Careers group explores the lack of engagement by girls in computing. It concludes that the best strategy to increase the proportion of women participating in computing and IT is compulsory and sustained engagement with an integrated digital technologies curriculum, including gender inclusive activities.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(2));
            }

            title = "Google wins in court, and so does losing party Oracle.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"Oracle recently lost its attempt to use patent and copyright law to force Google to pay US$9 billion for using parts of its Java computer language. Nine billion dollars isn’t chump change, not even for Google, but despite the verdict against Oracle, I’d say Google is not the only winner.

The dispute between the two internet giants was whether Google had needed Oracle’s permission to use computer code called the Java API. The API, and therefore the legal issue, relates to some pretty technical details about how computer programs work – how the instructions programmers write are followed on different hardware devices and different software operating systems.

The outcome of the case, decided in parts by a judge, an appeals court and a jury, was that Google’s use of computer code didn’t violate Oracle’s patents, and that Oracle could copyright its code. However, the jury found that Google’s use did not violate the copyright restrictions because it significantly expanded on the existing copyrighted materials, an exception in law called “fair use.”

It is not only a victory for Google, which has done nothing wrong and need not pay Oracle any money. Programmers remain allowed to use a very popular programming language without fear of crippling legal penalties – which in turn benefits the public, who use apps and websites made with Java. And while technically the legal loser, Oracle also won in a way, because it will benefit from Java’s continued popularity.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(0));
            }

            title = "How computers are learning to make human software work more efficiently.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"Computer scientists have a history of borrowing ideas from nature, such as evolution. When it comes to optimising computer programs, a very interesting evolutionary-based approach has emerged over the past five or six years that could bring incalculable benefits to industry and eventually consumers. We call it genetic improvement.

Genetic improvement involves writing an automated “programmer” who manipulates the source code of a piece of software through trial and error with a view to making it work more efficiently. This might include swapping lines of code around, deleting lines and inserting new ones – very much like a human programmer. Each manipulation is then tested against some quality measure to determine if the new version of the code is an improvement over the old version. It is about taking large software systems and altering them slightly to achieve better results.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(1));
            }

            title = "An education for the 21st century means teaching coding in schools.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"Bill Shorten’s recent announcement that, if elected, a Labor Government would “ensure that computer coding is taught in every primary and secondary school in Australia” has brought attention to an increasing world trend.

Estonia introduced coding in primary schools in 2012 and the UK followed suit last year. US-led initiatives such as Code.org and the “Hour of Code”, supported by organisations such as Google and Microsoft, advocate that every school student should have the opportunity to learn computer coding.

There is merit in school students learning coding. We live in a digital world where computer programs underlie everything from business, marketing, aviation, science and medicine, to name several disciplines. During a recent presentation at a radio station, one of our hosts said that IT would have been better background for his career in radio than journalism.

There is also a strong case to be made that Australia’s future prosperity will depend on delivering advanced services and digital technology, and that programming will be essential to this end. Computer programs and software are known to be a strong driver of productivity improvements in many fields.

Being introduced to coding gives students an appreciation of what can be built with technology. We are surrounded by devices controlled by computers. Understanding how they work, and imagining new devices and services, are enhanced by understanding coding.

Of course, not everyone taught coding will become a coder or have a career in information technology. Art is taught in schools with no expectation that the students should become artists.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(2));
            }

            title = "To stop the machines taking over we need to think about fuzzy logic.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"Amid all the dire warnings that machines run by artificial intelligence (AI) will one day take over from humans we need to think more about how we program them in the first place.

The technology may be too far off to seriously entertain these worries – for now – but much of the distrust surrounding AI arises from misunderstandings in what it means to say a machine is “thinking”.

One of the current aims of AI research is to design machines, algorithms, input/output processes or mathematical functions that can mimic human thinking as much as possible.

We want to better understand what goes on in human thinking, especially when it comes to decisions that cannot be justified other than by drawing on our “intuition” and “gut-feelings” – the decisions we can only make after learning from experience.

Consider the human that hires you after first comparing you to other job-applicants in terms of your work history, skills and presentation. This human-manager is able to make a decision identifying the successful candidate.

If we can design a computer program that takes exactly the same inputs as the human-manager and can reproduce its outputs, then we can make inferences about what the human-manager really values, even if he or she cannot articulate their decision on who to appoint other than to say “it comes down to experience”.

This kind of research is being carried out today and applied to understand risk-aversion and risk-seeking behaviour of financial consultants. It’s also being looked at in the field of medical diagnosis.

These human-emulating systems are not yet being asked to make decisions, but they are certainly being used to help guide human decisions and reduce the level of human error and inconsistency.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(0));
            }

            title = "A bit of coding in school may be a dangerous thing for the IT industry.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"It sounds compelling, but what does Opposition leader Bill Shorten actually mean when he says all secondary school pupils should be taught “digital technologies, computer science and coding”? And, equally importantly, why?

In his budget reply speech, as part of a focus on science and technology education, he stated that “coding” should be part of Australia’s national curriculum.

He doesn’t define precisely what he means by “coding”, but it’s likely the speech was at least partly inspired by the work of code.org, a US-based multi-national computing education programme.

Barack Obama participated in one of the organisation’s largest projects, the introductory “Hour of Code” for primary school students, allegedly becoming the first US President to write a computer program in the process.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(1));
            }

            title = "Machines master classic video games without being told the rules.";

            exists = await this.ArticleExistsAsync(title);
            if (!exists)
            {
                var content = @"Think you’re good at classic arcade games such as Space Invaders, Breakout and Pong? Think again.

In a groundbreaking paper published today in Nature, a team of researchers led by DeepMind co-founder Demis Hassabis reported developing a deep neural network that was able to learn to play such games at an expert level.

What makes this achievement all the more impressive is that the program was not given any background knowledge about the games. It just had access to the score and the pixels on the screen.

It didn’t know about bats, balls, lasers or any of the other things we humans need to know about in order to play the games.";

                await this.CreateArticleAsync(title, content, authorsIds.ElementAt(2));
            }
        }

        private async Task<bool> CourseExistsAsync(string name)
            => await this.db.Courses.AnyAsync(c => c.Name == name);

        private async Task<List<string>> GetTrainersIdsAsync()
            => await this.db.Users.Where(u => u.Email.Contains("trainer")).Select(u => u.Id).ToListAsync();

        private async Task CreateCourseAsync(string name,
            string description,
            DateTime endDate,
            DateTime startDate,
            string trainerId)
        {
            var trainerExists = await this.db.Users.AnyAsync(t => t.Id == trainerId);

            if (!trainerExists)
            {
                return;
            }

            var course = new Course
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                TrainerId = trainerId
            };

            await this.db.AddAsync(course);
            await this.db.SaveChangesAsync();
        }

        private async Task<List<string>> GetAllUsersIdsAsync()
            => await this.db
                .Users
                .Where(u => !u.Email.Contains("trainer") && !u.Email.Contains("admin"))
                .Select(u => u.Id)
                .ToListAsync();

        private async Task<IEnumerable<int>> GetAllCoursesIdsAsync()
            => await this.db.Courses.Select(c => c.Id).ToListAsync();

        private async Task AddUsersInCourseAsync(int courseId, string[] userIds)
        {
            var randomCount = new Random().Next(3, userIds.Length);
            for (int i = 0; i < randomCount; i++)
            {
                var exists = await this.db.FindAsync<StudentCourse>(userIds[i], courseId) != null;
                if (!exists)
                {
                    var studentCourse = new StudentCourse
                    {
                        CourseId = courseId,
                        StudentId = userIds[i]
                    };

                    await this.db.AddAsync(studentCourse);
                    await this.db.SaveChangesAsync();
                }
            }
        }

        private async Task<List<string>> GetAuthorsIdsAsync()
            => await this.db.Users.Where(u => u.Email.Contains("author")).Select(u => u.Id).ToListAsync();

        private async Task<bool> ArticleExistsAsync(string title)
            => await this.db.Articles.AnyAsync(a => a.Title == title);

        private async Task CreateArticleAsync(string title, string content, string authorId)
        {
            var article = new Article
            {
                AuthorId = authorId,
                Content = content,
                Title = title,
                PublishDate = DateTime.UtcNow
            };

            this.db.Add(article);
            await this.db.SaveChangesAsync();
        }
    }
}
