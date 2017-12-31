//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices.ComTypes;
//
//namespace Zorklike2018
//{
//    public class Level3
//    {
//        public List<AbstractRoom> ListOfRooms { get; set; }
//        private Hero Hero { get; set; }
//        private Battle _battle = new Battle();
//
//        public Level3(List<AbstractRoom> listOfRooms, Hero hero)
//        {
//            ListOfRooms = listOfRooms;
//            Hero = hero;
//        }
//
//        public bool Level3Start()
//        {
//            int nextRoom = 0;
//            bool levelFinished = false;
//            while (levelFinished == false)
//            {
//                var roomResult = ListOfRooms[nextRoom].VisitRoom(1, 0, 0, 0);
//                if (roomResult == 0)
//                {
//                    return false;
//                }
//                if (roomResult == 9)
//                {
//                    levelFinished = true;
//                    return true;
//                }
//                if (roomResult == 5)
//                {
//                    Console.WriteLine("Nie powinieneś tutaj być...");
//                    //TODO Next level
//                }
//                else
//                {
//                    nextRoom = roomResult;
//                }
//            }
//            return true;
//        }
//    }
//
//    public class RoomList
//    {
//        public BetterRoom Room { get; set; }
//        public int RoomId { get; set; }
//
//        public RoomList(BetterRoom room, int roomId)
//        {
//            Room = room;
//            RoomId = roomId;
//        }
//    }
//}