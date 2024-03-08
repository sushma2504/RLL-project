using Microsoft.AspNetCore.Mvc;
using RLL_projet.Models;

namespace RLL_projet.Controllers
{
    public class InterviewController : Controller
    {

        private List<Interview> interviews = new List<Interview>();
        public InterviewController()
        {
            interviews = new List<Interview>
        {
            new Interview { Id = 1, CandidateName = "John Doe", InterviewDate = DateTime.Now.AddDays(1), Interviewer = "Jane Smith" },
            new Interview { Id = 2, CandidateName = "Alice Johnson", InterviewDate = DateTime.Now.AddDays(2), Interviewer = "Bob Brown" }
            // Add more initial interviews as needed
        };
        }
        public ActionResult Index()
        {
            return View(interviews);
        }

        public ActionResult ScheduleInterview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ScheduleInterview(Interview model)
        {
            // Simulate storing in-memory without a database
            model.Id = interviews.Count + 1;
            interviews.Add(model);

            return RedirectToAction("Index");
        }
    }
}
