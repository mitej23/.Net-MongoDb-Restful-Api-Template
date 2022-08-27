using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
// using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OktaNetCoreMvcMongoExample.Models;
using OktaNetCoreMvcMongoExample.Services;

namespace OktaNetCoreMvcMongoExample.Controllers
{
    public class SubmissionController : Controller 
    {
        private readonly SubmissionService _subSvc;

        public SubmissionController(SubmissionService submissionService)
        {
            _subSvc = submissionService;
        }

        public ActionResult<IList<Submission>> Index() => View(_subSvc.Read());

        [HttpGet]
        public ActionResult Create() => View();
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<Submission> Create(Submission submission){
            submission.Created = submission.LastUpdated = DateTime.Now;
            submission.UserId = "1";
            submission.UserName = "mitej";
             _subSvc.Create(submission);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult<Submission> Edit(string id) => 
            View(_subSvc.Find(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Submission submission)
        {
            submission.LastUpdated = DateTime.Now;
            submission.Created = submission.Created.ToLocalTime();
            _subSvc.Update(submission);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            _subSvc.Delete(id);
            return RedirectToAction("Index");
        }
    }
}