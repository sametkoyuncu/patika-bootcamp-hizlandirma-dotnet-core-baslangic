using System.Linq;
using linq_practices.Entities;

namespace linq_practices.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange(
                    new Student()
                    {
                        Name = "Ayşe",
                        Surname = "Yılmaz",
                        ClassId = 1
                    },
                    new Student()
                    {
                        Name = "Burak",
                        Surname = "Kaya",
                        ClassId = 1
                    },
                    new Student()
                    {
                        Name = "Betül",
                        Surname = "Can",
                        ClassId = 2
                    },
                    new Student()
                    {
                        Name = "Kerem",
                        Surname = "Yılmaz",
                        ClassId = 2
                    }
                );

                context.SaveChanges();
            }
        }
    }
}