using Microsoft.AspNetCore.Mvc;
using RLL_projet.Models;

namespace RLL_projet.Controllers
{
    public class OfferLetterController : Controller
    {

        private List<Candidate> candidates = new List<Candidate>();

        // Constructor to initialize the list
        public OfferLetterController()
        {
            candidates = new List<Candidate>
        {
            new Candidate { Name = "John Doe", Position = "Software Developer", IsShortlisted = false },
            new Candidate { Name = "Alice Johnson", Position = "UX Designer", IsShortlisted = true },
            // Add more initial candidates as needed
        };
        }

        public ActionResult Index()
        {
            return View(candidates);
        }

        public ActionResult IssueOfferLetter(string candidateName)
        {
            var candidate = candidates.FirstOrDefault(c => c.Name == candidateName);

            if (candidate != null && candidate.IsShortlisted)
            {
                ViewBag.CandidateName = candidateName;
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}