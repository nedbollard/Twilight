using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Course
    {
        private static string fileName = @"X:\data\courses.txt";

        public string CourseId { get; set; }
        public int FirstHole { get; set; }
        public List<int> Par { get; set; }
        public List<int> Stroke { get; set; }

        public Course(string courseId)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] courseFields = new string[21];
                        courseFields = line.Split(',');

                        if (courseId == courseFields[0])
                        {
                            this.CourseId = courseFields[0];
                            this.FirstHole = Int32.Parse(courseFields[1]);

                            List<int> parTemp = new List<int>();

                            int j = 3; // position of first par value

                            for (int i = 0; i < 9; i++)
                            {
                                parTemp.Insert(i, Int32.Parse(courseFields[j]));
                                j++;
                            }

                            this.Par = parTemp;

                            List<int> strokeTemp = new List<int>();

                            j++; // skip (marker) to position of the first stroke value

                            for (int i = 0; i < 9; i++)
                            {
                                strokeTemp.Add(Int32.Parse(courseFields[j]));
                                j++;
                            }

                            this.Stroke = strokeTemp;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.

                Console.WriteLine(fileName + " ... the file could not be read:");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
