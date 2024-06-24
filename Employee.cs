using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessWords
{
    public class Employee
    {
        // Check if they have an employee status based on words.
        public static bool CheckEmployeeStatus(string[] parameters)
        {
            // Variables to store employee, negative, and work action keywords.
            string[] employee_keywords = GetEmployeeKeywords();
            string[] negative_keywords = NegativeWords.GetNegativeKeywords();
            string[] work_action_keywords = GetWorkActions();
            string[] employee_working_action_keywords = GetEmployeeWorkingActions();

            // Boolean values for negative word detection.
            bool negativeWordDetected = false;

            // Boolean values for employee actions, work actions, and employee keywords.
            bool workActionDetected = false;
            bool employeeKeywordDetected = false;
            bool employeeWorkingActionDetected = false;

            // Check if a negative keyword exists in a sentence.
            foreach (string parameter in parameters)
            {
                // Check if there is a negative word or not.
                foreach (string negative_keyword in negative_keywords)
                {
                    if (parameter.ToLower().Equals(negative_keyword))
                        negativeWordDetected = true;
                }

                // Check if an employee keyword exists in a sentence.
                foreach (string employee_keyword in employee_keywords)
                {
                    if (parameter.ToLower().Equals(employee_keyword))
                        employeeKeywordDetected = true;
                }

                // Check if work action keywords are detected or not.
                foreach (string work_action_keyword in work_action_keywords)
                {
                    if (parameter.ToLower().Equals(work_action_keyword))
                        workActionDetected = true;
                }

                // Check if there is an employee working action.
                foreach (string employee_working_action_keyword in employee_working_action_keywords)
                {
                    if (parameter.ToLower().Equals(employee_working_action_keyword))
                        employeeWorkingActionDetected = true;
                }
            }

            // By default, return the result
            return (employeeWorkingActionDetected || (employeeKeywordDetected || workActionDetected)) && !negativeWordDetected;
        }

        // This returns employee keyword values.
        private static string[] GetEmployeeKeywords()
        {
            return new string[]
            {
                "employee",
                "worker",
                "staff",
                "team member",
                "associate",
                "colleague",
                "manager",
                "supervisor",
                "executive",
                "director",
                "officer",
                "assistant",
                "administrator",
                "clerk",
                "engineer",
                "technician",
                "developer",
                "programmer",
                "analyst",
                "consultant",
                "contractor",
                "intern",
                "temp",
                "freelancer",
                "consultant",
                "advisor",
                "leader",
                "boss",
                "chief",
                "head",
                "operator",
                "coordinator",
                "planner",
                "organizer",
                "strategist"
            };
        }

        // This returns work actions.
        private static string[] GetWorkActions()
        {
            return new string[]
            {
                "working",
                "operating",
                "managing",
                "supervising",
                "developing",
                "designing",
                "coding",
                "programming",
                "analyzing",
                "consulting",
                "meeting",
                "reporting",
                "planning",
                "organizing",
                "strategizing",
                "implementing",
                "executing",
                "evaluating",
                "assisting",
                "supporting",
                "coordinating",
                "researching",
                "documenting",
                "monitoring",
                "reviewing",
                "testing",
                "debugging",
                "deploying",
                "presenting",
                "training",
                "mentoring",
                "leading",
                "directing",
                "advising",
                "brainstorming",
                "innovating",
                "collaborating",
                "interacting"
            };
        }

        // This returns employee working actions.
        private static string[] GetEmployeeWorkingActions()
        {
            return new string[]
            {
                "project-managing",
                "task-supervising",
                "code-developing",
                "system-designing",
                "software-coding",
                "data-analyzing",
                "client-consulting",
                "team-meeting",
                "status-reporting",
                "schedule-planning",
                "workflow-organizing",
                "goal-strategizing",
                "solution-implementing",
                "strategy-executing",
                "performance-evaluating",
                "customer-assisting",
                "issue-supporting",
                "resource-coordinating",
                "market-researching",
                "report-documenting",
                "process-monitoring",
                "feedback-reviewing",
                "feature-testing",
                "bug-debugging",
                "application-deploying",
                "progress-presenting",
                "employee-training",
                "new-hire-mentoring",
                "team-leading",
                "department-directing",
                "company-advising",
                "idea-brainstorming",
                "innovation-creating",
                "cross-functional-collaborating",
                "client-interacting"
            };
        }
    }
}