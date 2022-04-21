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
            Console.WriteLine("Implicit");
        }
        void IGamePlayer.Lose() // explicit implementation
        {
            Console.WriteLine("Explicit");
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
