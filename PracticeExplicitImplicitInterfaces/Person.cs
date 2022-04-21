using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExplicitImplicitInterfaces
{
    public class Person : IGamePlayer,IKeyHolder
    {
        public void Lose() // implicit implementation
        {
            // implement losing a key
        }
        void IGamePlayer.Lose() // explicit implementation
        {
            // implement losing a game
        }
    }

    public interface IGamePlayer
    {
        void Lose();
    }
    public interface IKeyHolder
    {
        void Lose();
    }
}
