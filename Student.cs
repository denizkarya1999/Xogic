using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessWords
{
    public class Student
    {
        // Check if they have a student status based on words.
        public static bool checkStudentStatus(string[] parameters)
        {
            //Variables to store negative and student keywords.
            string[] student_keywords = GetStudentKeywords();
            string[] negative_keywords = NegativeWords.GetNegativeKeywords();
            string[] student_action_keywords = GetStudyingActions();
            string[] studying_action_keywords = GetStudentStudyingActions();

            //Boolean values for negative word detection.
            bool negativeWordDetected = false;

            //Boolean values for student actions, studying actions and student keywords.
            bool studyingAction_detected = false;
            bool student_keyword_detected = false;
            bool studying_action_keyword_detected = false;

            // Check if a negative keyword exists in a sentence.
            foreach (string parameter in parameters)
            {
                // Check if there is a negative word or not.
                foreach (string negative_keyword in negative_keywords)
                {
                    if (parameter.ToLower().Equals(negative_keyword))
                        negativeWordDetected = true;
                }

                // Check if a student keyword exists in a sentence.
                foreach (string student_keyword in student_keywords)
                {
                    if (parameter.ToLower().Equals(student_keyword))
                        student_keyword_detected = true;
                }

                // Check if student action keywords are detected or not.
                foreach(string student_action_keyword in student_action_keywords)
                {
                    if (parameter.ToLower().Equals(student_action_keyword))
                        studyingAction_detected = true;
                }

                // Check if there is a studying action.
                foreach (string studying_action_keyword in studying_action_keywords)
                {
                    if (parameter.ToLower().Equals(studying_action_keyword))
                        studying_action_keyword_detected = true;
                }
            }

            //By default, return the result
            return (studying_action_keyword_detected || (student_keyword_detected && studyingAction_detected)) && !negativeWordDetected;
        }

        // This returns student keyword values.
        private static string[] GetStudentKeywords()
        {
            return new string[]
            {
            "student",
            "pupil",
            "learner",
            "scholar",
            "undergraduate",
            "graduate",
            "postgraduate",
            "freshman",
            "sophomore",
            "junior",
            "senior",
            "classmate",
            "school",
            "college",
            "university",
            "academy",
            "institution",
            "course",
            "curriculum",
            "education",
            "study",
            "homework",
            "assignment",
            "exam",
            "test",
            "lecture",
            "seminar",
            "lab",
            "tutorial",
            "professor",
            "teacher",
            "instructor",
            "advisor",
            "mentor",
            "syllabus",
            "textbook",
            "degree",
            "diploma",
            "certification"
            };
        }

        // This returns studying actions.
        private static string[] GetStudyingActions()
        {
            return new string[]
            {
        "studying",
        "learning",
        "reading",
        "reviewing",
        "analyzing",
        "comprehending",
        "memorizing",
        "understanding",
        "examining",
        "cramming",
        "preparing",
        "practicing",
        "researching",
        "investigating",
        "writing",
        "summarizing",
        "taking notes",
        "solving",
        "discussing",
        "participating",
        "attending",
        "listening",
        "observing",
        "experimenting",
        "exploring",
        "collaborating",
        "brainstorming",
        "presenting",
        "testing",
        "quizzing",
        "outlining"
            };
        }

        // This returns student studying actions.
        private static string[] GetStudentStudyingActions()
        {
            return new string[]
            {
        "exam-studying",
        "material-learning",
        "textbook-reading",
        "lecture-reviewing",
        "case-study-analyzing",
        "concept-comprehending",
        "formula-memorizing",
        "theory-understanding",
        "research-paper-examining",
        "test-cramming",
        "assignment-preparing",
        "problem-practicing",
        "topic-researching",
        "experiment-investigating",
        "essay-writing",
        "chapter-summarizing",
        "class-note-taking",
        "homework-solving",
        "classmate-discussing",
        "study-group-participating",
        "lecture-attending",
        "professor-listening",
        "lab-demonstration-observing",
        "lab-experimenting",
        "academic-resource-exploring",
        "project-collaborating",
        "paper-brainstorming",
        "finding-presenting",
        "hypothesis-testing",
        "peer-quizzing",
        "study-guide-outlining"
            };
        }
    }
}
