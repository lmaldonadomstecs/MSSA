using System.Collections.Generic;
using ChallengeFriendslist.Models;

namespace ChallengeFriendslist.Services
{
    public interface IListOfFriends
    {
        // List<Friend> listOfFriends { get; set; }
        public List<Friend> getFriends();
        public Friend getFriendById(int id);
        public void insertNewFriend(Friend friend);
        public void deleteFriend(int id);
        public void editFriend(Friend friend);
    }
}