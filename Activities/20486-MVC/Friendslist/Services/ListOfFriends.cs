using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeFriendslist.Models;
using ChallengeFriendslist.Data;
using Microsoft.EntityFrameworkCore;

namespace ChallengeFriendslist.Services
{
    // THIS IS MY BUTTLER NOW
    public class ListOfFriends : IListOfFriends
    {
        // This is also going to be delegated to the Data Context
        //public List<Friend> listOfFriends { get; set; }
        private FriendContext butler;

        public ListOfFriends(FriendContext db)
        {
            butler = db;
            //InitializeListOfFriends();
        }

        // THIS IS GOING TO BE DELEGATE TO MY DATA CONTEXT
        //public void InitializeListOfFriends()
        //{
        //    listOfFriends = new List<Friend>() {
        //        new Friend() { id = 1, name = "León", place = "México", age = 17, occupation = "Pizza Delivery Guy", favoriteSport = "F1" },
        //        new Friend() { id = 2, name = "John", place = "Puerto Rico", age = 43, occupation = "Entrepreneur", favoriteSport = "Soccer" },
        //        new Friend() { id = 3, name = "Jane", place = "Hawaii", age = 35, occupation = "Lawyer", favoriteSport = "Hockey" }
        //    };
        //}

        public List<Friend> getFriends()
        {
            return butler.Friend.ToList();
        }

        public Friend getFriendById(int id)
        {
            // READ
            return butler.Friend.SingleOrDefault(friend => friend.id == id); ;
        }

        public void insertNewFriend(Friend friend)
        {
            // CREATE
            butler.Friend.Add(friend);
            butler.SaveChanges();
        }

        public void deleteFriend(int id)
        {
            Friend friend = butler.Friend.SingleOrDefault(friend => friend.id == id);
            butler.Friend.Remove(friend);
            butler.SaveChanges();
        }

        public void editFriend(Friend friend)
        {
            butler.Entry(friend).State = EntityState.Modified;
            butler.SaveChanges();
        }
    }
}
