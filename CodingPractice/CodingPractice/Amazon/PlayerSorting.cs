using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.HackerRank
{
    public class PlayerSorting
    {
        private static void Score_QuickSort(Player[] players, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            Player pivot = players[(left + right) / 2];
            int index = partition(players, left, right, pivot,false);
            Score_QuickSort(players, left, index - 1);
            Score_QuickSort(players, index, right);

        }
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-comparator-sorting/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
        /// </summary>
        public static void Player_QuickSort()
        {
            //Player[] players = new Player[]
            //{
            //    new Player{name="smith",score=20},
            //    new Player{name="jones",score=15},
            //    new Player{name="jones",score=20}

            //};
            //Player[] players = new Player[]
            //{
            //      new Player{name="amy",score=100},
            //      new Player{name="david",score=100},
            //      new Player{name="heraldo ",score=50},
            //      new Player{name="aakansha",score=75},
            //      new Player{name="aleksa",score=150}

            //};
            Player[] players = new Player[]
            {
                new Player{name="amy",score=100},
                new Player{name="david",score=100},
                new Player{name="heraldo ",score=50},
                new Player{name="aakansha",score=75},
                new Player{name="aleksa",score=150},
                new Player{name="bbb",score=150},
                new Player{name="aaa",score=150},
                new Player{name="ccc",score=150}

            };
            Score_QuickSort(players, 0, players.Length - 1);
            Player_QuickSort(players, 0, players.Length-1);
            
        }

       
        private static void Player_QuickSort(Player[] players, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            Player pivot = players[(left + right) / 2];
            int index = partition(players, left, right, pivot,true);
            Player_QuickSort(players, left, index - 1);
            Player_QuickSort(players, index, right);

        }
        private static int partition(Player[] players, int left, int right, Player pivot,bool isPlayer)
        {
            while (left <= right)
            {
                while (players[left].score > pivot.score)
                {
                    left++;
                }
                while (players[right].score < pivot.score)
                {
                    right--;
                }
                if (left <= right)
                {
                    Checker check = new Checker();
                    //if (players[left].score == players[right].score)
                   // {
                        int i = check.Compare(players[left], players[right]);
                    // }
                    Player temp;
                    if (i == 1 && isPlayer==true)
                    {
                        temp = players[right];
                        players[right] = players[left];
                        players[left] = temp;
                    }
                    else if(i == -1 && isPlayer == true)
                    {
                        //do nothing
                    }
                    else
                    {
                        temp = players[left];
                        players[left] = players[right];
                        players[right] = temp;
                    }
                    left++;
                    right--;

                }
            }

            return left;
        }
    }

    public class Checker : Comparer<Player>
    {
        public override int Compare(Player x, Player y)
        {
            if(x.score == y.score)
            {
                return x.name.CompareTo(y.name);
            }
            else if(x.score > y.score)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
            
        }
    }

    public class Player
    {
        public string name { get; set; }
        public int score { get; set; }
    }
}
