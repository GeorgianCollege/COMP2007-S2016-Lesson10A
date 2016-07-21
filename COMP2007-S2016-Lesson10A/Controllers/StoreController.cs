using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Lesson10A.Models;

/**
 * @author: Tom Tsiliopoulos
 * @description: This is the Store Controller
 * @date: July 21, 2016
 * 
 */

namespace COMP2007_S2016_Lesson10A.Controllers
{
    
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        
        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                 new Genre("Disco"),
                 new Genre("Jazz"),
                 new Genre("Rock")
            };

            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco
        
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        
        public ActionResult Details(int id = 1)
        {
            Album album = new Album("Album " + id);

            return View(album);
        }
    }
}