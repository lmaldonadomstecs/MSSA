using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeFriendslist.Models;
using ChallengeFriendslist.Services;

namespace ChallengeFriendslist.Controllers
{
    public class FriendController : Controller
    {
        // We need the butler
        IListOfFriends _listOfFriends;

        // Inject service into Controller
        public FriendController(IListOfFriends myListService)
        {
            // Dependency injection Reference type values
            // FAUCET    connected to      PIPE
            _listOfFriends = myListService;
        }

        // READ
        public IActionResult Index()
        {
            return View(_listOfFriends.getFriends());
        }

        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            return View();
        }

        // CREATE FRIENDS
        [HttpPost]
        public IActionResult InsertNewFriend(Friend friend)
        {
            if (ModelState.IsValid)
            {
                _listOfFriends.insertNewFriend(friend);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult FriendsDetail(int id)
        {
            Friend friend = _listOfFriends.getFriendById(id);
            return View(friend);
        }

        public IActionResult DeleteFriend(int id)
        {
            _listOfFriends.deleteFriend(id);
            return RedirectToAction("Index");
            // Send it to a Are you sure page?
        }

        public IActionResult EditFriend(int id)
        {
            Friend friend = _listOfFriends.getFriendById(id);
            return View(friend);
        }

        [HttpPost]
        public IActionResult EditFriend(Friend friend)
        {
            _listOfFriends.editFriend(friend);
            return View(friend);
        }

        //// UPDATE
        ////public IActionResult EditFriend(int id)
        ////{

        //}

        // DELETING
    }
}
