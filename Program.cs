using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrafficLight
{
    class CSignal
    {
        const bool TRUE = true;
        const bool FALSE = false;
        const bool ON = true;
        const bool OFF = false;   
        void SetColor(ConsoleColor forground, ConsoleColor background)
        {
            Console.ForegroundColor = forground;
            Console.BackgroundColor = background;
        }
        public CSignal() 
        {
            Console.WriteLine("**********************");
            Console.WriteLine("프로그램을 시작합니다.");
            Console.WriteLine("**********************");
        }
        void Lamp(ConsoleColor color, bool onoff)
        {
            if(onoff == ON)
            {
                SetColor(color, color);
            }
            else
            {                
                SetColor(ConsoleColor.White, ConsoleColor.Gray);                
            }
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");            
            SetColor(ConsoleColor.White, ConsoleColor.Black);
        }
        void RedLampOn()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, ON);
            Lamp(ConsoleColor.Yellow, OFF);
            Lamp(ConsoleColor.Green, OFF);
            Console.WriteLine("빨간불 입니다.");
        }
        void YellowLampOn()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, OFF);
            Lamp(ConsoleColor.Yellow, ON);
            Lamp(ConsoleColor.Green, OFF);
            Console.WriteLine("노란불 입니다.");
        }
        void GreenLampOn()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, OFF);
            Lamp(ConsoleColor.Yellow, OFF);
            Lamp(ConsoleColor.Green, ON);
            Console.WriteLine("파란불 입니다.");
        }
        int nStep;
        int nCount;
        public bool loop()
        {
            switch (nStep)
            {
                case 0:   //초기화
                    nStep = 100;
                    nCount = 0;
                    RedLampOn();
                    break;
                case 100:  //빨간불
                    if(nCount < 5)
                    {
                        nCount++;
                    }
                    else
                    {
                        nCount = 0;
                        nStep = 200;
                        YellowLampOn();
                    }
                    break;
                case 200:   //노란불
                    if(nCount < 5)
                    {
                        nCount++;
                    }
                    else
                    {
                        nCount = 0;
                        nStep = 300;
                        GreenLampOn();
                    }
                    break;
                case 300:  //파란불
                    if(nCount < 3)
                    {
                        nCount++;
                    }
                    else
                    {
                        nCount = 0;
                        nStep = 0;
                    }
                    break;
                default:
                    nStep = 0;
                    break;
            }
            Thread.Sleep(100);
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CSignal sig = new CSignal();
            while (sig.loop()) ;
        }
    }
}
