using System;

namespace Project
{
    class Controler
    {
        protected int channel = 0;
        protected int volume = 0;
        protected ConsoleKey k = ConsoleKey.D0;
        protected string[] channels = { "Armenia premium TV","Armenian Public TV","Armenian Public Second TV","Shant TV","Armenia TV","5 TV","Kentron TV", "ArmNews TV","ATV","Ar TV"};
        public Controler()
        {
            Console.WriteLine("Hello. I am Remote Controler");
            Console.WriteLine();
            Console.WriteLine("You can change channels, mute volume, volume +,volume -. You can also activate menu");
            Console.WriteLine();
            Console.WriteLine("Please press that key, what is said in this form");
            Console.WriteLine("_________________________________________________");
            Options();
            Console.WriteLine();
        }
        public ConsoleKey Action
        {
            get
            {
                return k;
            }
            set
            {
                k = value;
            }
        }
        public void Options()
        {
            Console.WriteLine("If you want to activate the channel, please, insert the number of the channel");
            Console.WriteLine("If you want to change the channel + , please, press Up Arrow");
            Console.WriteLine("If you want to activate the channel -, please, press Down Arrow");
            Console.WriteLine("For muting the volume, please, press F6");
            Console.WriteLine("For volume +, please, press Right Arrow");
            Console.WriteLine("For volume -, please, press Left Arrow");
            Console.WriteLine("For muting volume, press F5");
            Console.WriteLine("For Menu Options, please, press Home");
            Console.WriteLine("For turning off Remote Controler, please, press Escape");
        }
        public void Do()
        {
            switch (k)
            {
                case ConsoleKey.D0:
                    channel = 0;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D1:
                    channel = 1;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D2:
                    channel = 2;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D3:
                    channel = 3;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D4:
                    channel = 4;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D5:
                    channel = 5;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D6:
                    channel = 6;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D7:
                    channel = 7;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D8:
                    channel = 8;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.D9:
                    channel = 9;
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.Home:
                    Console.WriteLine("Menu Options");
                    Console.WriteLine("_____________");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YouTube  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Settings  ");
                    Console.ResetColor();
                    break;
                case ConsoleKey.RightArrow:
                    if (channel == 9)
                    {
                        channel = 0;
                    }
                    else channel++;
                    Console.WriteLine($"Next channel->{channel}");
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.LeftArrow:
                    if (channel == 0)
                    {
                        channel = 9;
                    }
                    else
                    {
                        channel--;
                    }
                    Console.WriteLine($"Previous channel->{channel}");
                    Console.WriteLine($"Hello. You are now in {channels[channel]}");
                    break;
                case ConsoleKey.UpArrow:
                    if (volume==100)
                    {
                        Console.WriteLine("The highest value");
                        break;
                    }
                    volume+=5;
                    Console.WriteLine($"Volume-> {volume} %");
                    break;
                case ConsoleKey.DownArrow:
                    if (volume==0)
                    {
                        Console.WriteLine($"Volume muted-> {volume} %");
                        break;
                    }
                    volume -= 5;
                    Console.WriteLine($"Volume-> {volume} %");
                    break;
                case ConsoleKey.F5:
                    Console.WriteLine("Volume muted!!!!!!!!!!!");
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool t = true;
            do
            {
                Console.Clear();
                Console.Write("Do you want to use remote controler?(1(yes),0(no))->");
                t=int.TryParse(Console.ReadLine(), out n);
            } while (t==false || n!=1 && n!=0);
            if (n == 1)
            {
                Controler cont = new Controler();
                ConsoleKey k;
                do
                {
                    //Console.WriteLine("Press Action Button");
                    k = Console.ReadKey(true).Key;
                    cont.Action = k;
                    cont.Do();
                } while (k != ConsoleKey.Escape);
            }
        }
    }
}
