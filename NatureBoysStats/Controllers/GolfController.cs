using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NatureBoysStats.Models;

namespace NatureBoysStats.Controllers
{
    public class GolfController : Controller
    {
        private readonly HockeyContext _context;

        public GolfController(HockeyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View("Scorecard");
        }
         
        public IActionResult CreateNewScorecard(GolfScoreCard newGolfScorecard, string played)
        {
            //TODO - if there is not number for a hole, make zero and save.
            //TODO - ability to choose how many holes they played
            //Make into ternary operation
            if (ModelState.IsValid)
            {
                if (newGolfScorecard.CourseName != null && newGolfScorecard.PlayerName != null )
                {
                    if (played == "18")                                                   
                    {
                        newGolfScorecard.Total = newGolfScorecard.Hole1 + newGolfScorecard.Hole2 + newGolfScorecard.Hole3 + newGolfScorecard.Hole4 +
                           newGolfScorecard.Hole5 + newGolfScorecard.Hole6 + newGolfScorecard.Hole7 + newGolfScorecard.Hole8 + newGolfScorecard.Hole9 +
                           newGolfScorecard.Hole10 + newGolfScorecard.Hole11 + newGolfScorecard.Hole12 + newGolfScorecard.Hole13 + newGolfScorecard.Hole14 +
                           newGolfScorecard.Hole15 + newGolfScorecard.Hole16 + newGolfScorecard.Hole17 + newGolfScorecard.Hole18;
                    }
                    else
                    {
                        if (newGolfScorecard.Hole1 != null)
                        {
                            newGolfScorecard.Total = newGolfScorecard.Hole1 + newGolfScorecard.Hole2 + newGolfScorecard.Hole3 + newGolfScorecard.Hole4 +
                          newGolfScorecard.Hole5 + newGolfScorecard.Hole6 + newGolfScorecard.Hole7 + newGolfScorecard.Hole8 + newGolfScorecard.Hole9;
                            newGolfScorecard.Hole10 = 0; 
                            newGolfScorecard.Hole11 = 0;
                            newGolfScorecard.Hole12 = 0; 
                            newGolfScorecard.Hole13 = 0;
                            newGolfScorecard.Hole14 = 0;
                            newGolfScorecard.Hole15 = 0;
                            newGolfScorecard.Hole16 = 0;
                            newGolfScorecard.Hole17 = 0;
                            newGolfScorecard.Hole18 = 0;
                        }
                        else
                        {
                               newGolfScorecard.Total = newGolfScorecard.Hole10 + newGolfScorecard.Hole11 + newGolfScorecard.Hole12 + newGolfScorecard.Hole13 + newGolfScorecard.Hole14 +
                           newGolfScorecard.Hole15 + newGolfScorecard.Hole16 + newGolfScorecard.Hole17 + newGolfScorecard.Hole18;
                            newGolfScorecard.Hole1 = 0;
                            newGolfScorecard.Hole2 = 0;
                            newGolfScorecard.Hole3 = 0;
                            newGolfScorecard.Hole4 = 0;
                            newGolfScorecard.Hole5 = 0;
                            newGolfScorecard.Hole6 = 0;
                            newGolfScorecard.Hole7 = 0;
                            newGolfScorecard.Hole8 = 0;
                            newGolfScorecard.Hole9 = 0;
                        }
                    }
                
                    newGolfScorecard.Date = DateTime.Now.ToShortDateString();
                    _context.GolfScoreCard.Add(newGolfScorecard);
                    _context.SaveChanges();
                    //return RedirectToAction("Index", "Home");
                    return RedirectToAction("DisplayAllRounds");
                  }
            else
            {
                    ViewBag.NotEnoughInfo = "You did not have a player name or course name";
                    return View("ScoreCard");
            }
            }
            else
            {
                return View("Scorecard");
            }
        }

        public IActionResult DisplayAllRounds()
        {
            var allRounds = _context.GolfScoreCard.ToList();
            return View(allRounds);
        }
    }
}
