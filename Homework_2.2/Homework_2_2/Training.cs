using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    class Training : DescriptableLearning, ICloneable
    {
        public Lecture[] Lectures { get; set; } = Array.Empty<Lecture>();
        public PracticalLesson[] PracticalLessons { get; set; } = Array.Empty<PracticalLesson>();

        public void Add(Lecture lecture)
        {
            var lectures = Lectures.ToList();
            lectures.Add(lecture);
            Lectures = lectures.ToArray();
        }

        public void Add(PracticalLesson practicalLesson)
        {
            var practicalLessons = PracticalLessons.ToList();
            practicalLessons.Add(practicalLesson);
            PracticalLessons = practicalLessons.ToArray();
        }

        public bool IsPratical()
        {
            return Lectures.Length == 0 && PracticalLessons.Length > 0;
        }

        public object Clone()
        {
            var training = new Training
            {
                Description = Description
            };

            var lectures = new List<Lecture>();
            var practicalLessons = new List<PracticalLesson>();

            foreach (var lecture in Lectures)
            {
                lectures.Add(new Lecture
                {
                    Description = lecture.Description,
                    Topic = lecture.Topic
                });
            }

            foreach (var practicalLesson in PracticalLessons)
            {
                practicalLessons.Add(new PracticalLesson
                {
                    Description = practicalLesson.Description,
                    TaskCondition = practicalLesson.TaskCondition,
                    Solution = practicalLesson.Solution
                });
            }

            training.Lectures = lectures.ToArray();
            training.PracticalLessons = practicalLessons.ToArray();

            return training;
        }
    }
}
