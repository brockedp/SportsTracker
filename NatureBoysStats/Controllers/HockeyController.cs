using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NatureBoysStats.Models;
using System.Net.Http;
//using System.Net.Http.Formatting.dll;

namespace NatureBoysStats.Controllers
{
    public class HockeyController : Controller
    {
        private readonly HockeyContext _context;
        public HockeyController(HockeyContext context)
        {
            _context = context;
        }
        

        public IActionResult Index()
        {
            
            List<NatureBoys> playerList = new List<NatureBoys>();
            playerList = _context.NatureBoys.ToList();
            return View(playerList);
        }

        public IActionResult GameSheet()
        {
            List<NatureBoys> playerList = new List<NatureBoys>();
            playerList = _context.NatureBoys.ToList();
            //NatureBoys player = _context.NatureBoys.Find(67);
            List<NatureBoys> players = new List<NatureBoys>();
            for (int i = 0; i < playerList.Count; i++)
            {
                players.Add(new NatureBoys(playerList[i].Id, playerList[i].NickName));
            }
            return View(players);
        }
        //TODO - CRUD actions
        public IActionResult AddNatureBoy()
        {
            //List<NatureBoys> playerList = new List<NatureBoys>();
            //playerList = _context.NatureBoys.ToList();
            //return View(playerList);
            return View();
        }
        [HttpPost]
        public IActionResult AddNatureBoy(NatureBoys natureBoy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(natureBoy);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                //Need to add a view for new Player
                return View("Index");
            }
        }

        public IActionResult DeleteNatureBoy(int id)
        {
            NatureBoys found = _context.NatureBoys.Find(id);
            if (found != null && ModelState.IsValid)
            {
                _context.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        
        public IActionResult UpdateNatureBoy(int id)
        {
            NatureBoys found = _context.NatureBoys.Find(id);
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult UpdateNatureBoy(NatureBoys natureBoy)
        {
            NatureBoys found = _context.NatureBoys.Find(natureBoy.Id);
            if (ModelState.IsValid && found != null)
            {
                found.Id = natureBoy.Id;
                found.FirstName = natureBoy.FirstName;
                found.LastName = natureBoy.LastName;
                found.NickName = natureBoy.NickName;
                found.Goals = natureBoy.Goals;
                found.Assist = natureBoy.Assist;
                found.Points = natureBoy.Goals + natureBoy.Assist;
                found.BeersBefore = natureBoy.BeersBefore;
                found.BeersDuring = natureBoy.BeersDuring;
                found.BeersAfter = natureBoy.BeersAfter;
                found.PenaltyMinutes = natureBoy.PenaltyMinutes;
                //Need to update goals, points, assists, beers in another method
                //TODO - update players per game
                // todo - view for select players stats for the game

                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditGameSheets(IList<NatureBoys> theBoys)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in theBoys)
                {
                    NatureBoys found = _context.NatureBoys.Find(item.Id);
                    if(item.Goals != null)
                    {
                        found.Goals += item.Goals;
                    }
                    if (item.Assist != null)
                    {
                        found.Assist += item.Assist;
                    }
                    if (item.PenaltyMinutes != null)
                    {
                        found.PenaltyMinutes += item.PenaltyMinutes;
                    }
                    if (item.BeersBefore != null)
                    {
                        found.BeersBefore += item.BeersBefore;
                    }
                    if (item.BeersDuring != null)
                    {
                        found.BeersDuring += item.BeersDuring;
                    }
                    if (item.BeersAfter != null)
                    {
                        found.BeersAfter += item.BeersAfter;
                    }
                    found.Points = found.Goals + found.Assist;

                    _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _context.Update(found);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("GameSheet");
            }
        }


    
    }
}