namespace Balta.ContentContext
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientacao-objetos"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var course = new List<Course>();
            var couseOOP = new Course("Fundamentos OOP", "fundamento-oop");

            course.Add(couseOOP);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", couseOOP);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Leval);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property}-{notification.Message}");
                    }
                }
            }


        }
    }
}