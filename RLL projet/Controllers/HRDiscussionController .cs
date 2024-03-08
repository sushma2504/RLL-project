using Microsoft.AspNetCore.Mvc;
using RLL_projet.Models;

namespace RLL_projet.Controllers
{
    public class HRDiscussionController : Controller
    {
        private List<HRDiscussion> hrDiscussions = new List<HRDiscussion>();
        public HRDiscussionController()
        {
            hrDiscussions = new List<HRDiscussion>
        {
            new HRDiscussion
            {
                CandidateName = "John Doe",
                Interviewer = "Jane Smith",
                InterviewDate = "2024-03-05",
                CommunicationSkillsRating = 4,
                TechnicalSkillsRating = 3,
                ProblemSolvingRating = 5,
                Comments = "Impressive candidate"
            },
            // Add more initial discussions as needed
        };
        }
        public IActionResult Index()
        {
            return View(hrDiscussions);
        }

        public ActionResult StartHRDiscussion()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StartHRDiscussion(HRDiscussion model)
        {
            // Simulate storing in-memory without a database
            hrDiscussions.Add(model);

            return RedirectToAction("Index");
        }

     }
}

