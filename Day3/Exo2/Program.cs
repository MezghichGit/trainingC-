using System;
using System.Collections.Generic;
using System.Linq;
namespace Exo2
{
    
        struct Student
        {
            // Properties 
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            double[] notesExamen;

            // Constructeur 
            public Student(int id_, string firstName_, string lastName_, params double[] notes)
            {
                Id = id_;
                FirstName = firstName_;
                LastName = lastName_;
                notesExamen = new double[2];
                for (int i = 0; i < notes.Length; i++)
                {
                    notesExamen[i] = notes[i];
                }
            }
            // Indexer for notesExamen
            public double this[int index]
            {
                get { return this.notesExamen[index]; }
                set { this.notesExamen[index] = value; }
            }
            
        }
        class Program
        {

        public static IEnumerable<Student> noteSupA(double note, int examen, List<Student> studentList)
        {
            // Requête LINQ 
            IEnumerable<Student> selectedStudents = from Student s in studentList
                                                    where s[examen - 1] >= note
                                                    select s;
            return selectedStudents;
        }

        static void Main(string[] args)
            {
                Student s1 = new Student(1, "Lucie", "Techer", 10, 12);
                Student s2 = new Student(2, "John", "Lio", 17, 14);
                Student s3 = new Student(3, "Rachel", "Payet", 13, 16);
                Student s4 = new Student(4, "Ludovic", "Rivière", 11, 18);

                List<Student> students = new List<Student>();
                students.Add(s1);
                students.Add(s2);
                students.Add(s3);
                students.Add(s4);

                IEnumerable<Student> selectedStudents = noteSupA(12, 1, students);

                foreach (Student student in selectedStudents)
                {
                    Console.WriteLine("Nom etudiant:" + student.FirstName + " " + student.LastName);
                }


            }
        }
    
}
