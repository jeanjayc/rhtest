using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;
using System;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() 
        {
            Repository repo = new Repository();
            var result = repo.Students.Where(s => s.Birth.Year == 2020).ToList();
            result.ForEach(p => Console.WriteLine(p.ToString()));
            return result;
        }
    }
}
