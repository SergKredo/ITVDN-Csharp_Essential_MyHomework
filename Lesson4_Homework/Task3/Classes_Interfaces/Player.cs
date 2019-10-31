using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Player: IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание песни.");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза при проигрывании песни.");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Пауза записи голоса.");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Остановка при проигрывании песни.");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Остановка записи голоса.");
        }
        public void Record()
        {
            Console.WriteLine("Запись голоса.");
        }
        
    }
}
