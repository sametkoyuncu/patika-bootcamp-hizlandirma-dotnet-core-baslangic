using System;
using System.Linq;
using linq_practices.DBOperations;
using linq_practices.Entities;

namespace linq_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            // Linq Methods
            // Find
            var student = _context.Students.Where(s => s.Id == 1).FirstOrDefault(); // Find'sız
            student = _context.Students.Find(1); // Find'lı

            // FirstOrDefault()
            student = _context.Students.Where(s => s.Surname == "Yılmaz").FirstOrDefault(); // birden çok veri varsa (ki var) ilkini getirir
            // First - bulamazsa hata fırlatır
            // FirstOrDefault - bulamazsa null döner
            student = _context.Students.FirstOrDefault(s => s.Surname == "Yılmaz"); // sorguyu firstordefault içinde de yapabiliyoruz

            // SingleOrDefault() 1 veya 0 veri bekler, 1'den fazla dönerse hata fırlatır
            student = _context.Students.FirstOrDefault(s => s.Surname == "Yılmaz"); // hata, çünkü 2 adet var

            // ToList
            var studentList = _context.Students.Where(s => s.ClassId == 2).ToList();

            // foreach (var s in studentList)
            // {
            //     Console.Write("{0} ", s.Name);
            // }

            // OrderBy a-z
            students = _context.Students.OrderBy(x => x.Id).ToList();
            // OrderByDescending z-a gibi gibi
            students = _context.Students.OrderByDescending(x => x.Id).ToList();

            // Anonymous Object Result
            var anonymousObject = _context.Students
                                    .Where(x => x.ClassId == 2)
                                    .Select(x => new
                                    {
                                        Id = x.Id,
                                        Name = x.Name + " " + x.Surname
                                    });
            foreach (var item in anonymousObject)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
