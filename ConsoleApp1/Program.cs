namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            List<Exam> exams = new List<Exam>
        {
            new Exam { Subject = "Azerbaycan dili", ExamDuration = 2, StartDate = new DateTime(2023, 10, 17), EndDate = new DateTime(2023, 10, 17, 2, 0, 0) },
            new Exam { Subject = "Riyaziyyat", ExamDuration = 3, StartDate = new DateTime(2023, 10, 15), EndDate = new DateTime(2023, 10, 15, 3, 0, 0) },
            new Exam { Subject = "Fizika", ExamDuration = 1, StartDate = new DateTime(2023, 10, 20, 14, 0, 0), EndDate = new DateTime(2023, 10, 20, 15, 0, 0) }
        };
            DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
            List<Exam> lastWeekExams = exams.FindAll(e => e.StartDate >= oneWeekAgo);
            Console.WriteLine("Son 1 heftelik imtahan cedveli:");
            foreach (var exam in lastWeekExams)
            {
                Console.WriteLine($"{exam.Subject}, Duration: {exam.ExamDuration} hours");
            }          
            List<Exam> longExams = exams.FindAll(e => e.ExamDuration > 2);
            Console.WriteLine("2 saatdan uzun ceken imtahanlar:");
            foreach (var exam in longExams)
            {
                Console.WriteLine($"{exam.Subject}, Duration: {exam.ExamDuration} hours");
            }
            DateTime now = DateTime.Now;
            List<Exam> ongoingExams = exams.FindAll(e => e.StartDate <= now && e.EndDate >= now);
            Console.WriteLine("Hal-hazirda davam eden imtahanlar:");
            foreach (var exam in ongoingExams)
            {
                Console.WriteLine($"{exam.Subject}, Duration: {exam.ExamDuration} hours");
            }
        }
    }
}
        //Task1
        //    List<Person> people = new List<Person>
        //{
        //    new Person { Name = "Kamil", Surname = "Aliyev", Age = 25 },
        //    new Person { Name = "Nezrin", Surname = "Ova", Age = 22 },
        //    new Person { Name = "Elvin", Surname = "Huseynov", Age = 30 },
        //    new Person { Name = "Xeyale", Surname = "Aliyeva", Age = 18 }
        //};

            
        //    List<Person> kamilAdindaOlanlar = people.FindAll(p => p.Name == "Kamil");
        //    Console.WriteLine("Adi Kamil olan insanlar:");
        //    foreach (var person in kamilAdindaOlanlar)
        //    {
        //        Console.WriteLine($"{person.Name} {person.Surname}");
        //    }

            
        //    List<Person> ovOvaSoyadliOlanlar = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
        //    Console.WriteLine("Soyadi ov ve ova ile bitenler:");
        //    foreach (var person in ovOvaSoyadliOlanlar)
        //    {
        //        Console.WriteLine($"{person.Name} {person.Surname}");
        //    }

           
        //    List<Person> yashiBoyuk = people.FindAll(p => p.Age > 20);
        //    Console.WriteLine("Yashı 20+ olanlar:");
        //    foreach (var person in yashiBoyuk)
        //    {
        //        Console.WriteLine($"{person.Name} {person.Surname}");
        //    }