using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modes
{
    class Break
    {
        public static void Start(List<Utility.Vector2> TargetCoords)
        {
            int PlayerX = (int)Utility.LocalPlayer.X() / 32;
            int PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            int TargetX, TargetY;
            for (int i = 0; i < TargetCoords.Count; i++)
            {
                TargetX = TargetCoords[i].x;
                TargetY = TargetCoords[i].y;
                while (Utility.World.Foreground()[TargetY + PlayerY, TargetX + PlayerX] != 0)
                {
                    //Console.WriteLine("Started Breaking...");
                    World2Screen.Click.TargetBlock(TargetX + PlayerX, TargetY + PlayerY);
                }
                //Console.WriteLine($"Done Breaking the {i} block");
                PlayerX = (int)Utility.LocalPlayer.X() / 32;
                PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            }
        }
    }
    class Place
    {
        public static void Start(List<Utility.Vector2> TargetCoords)
        {
            int PlayerX = (int)Utility.LocalPlayer.X()/32;
            int PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            int TargetX, TargetY;
            for (int i=0; i<TargetCoords.Count; i++)
            {
                TargetX = TargetCoords[i].x;
                TargetY = TargetCoords[i].y;
                while (Utility.World.Foreground()[TargetY+PlayerY,TargetX+PlayerX] == 0)
                {
                    //Console.WriteLine("Started Placing...");
                    World2Screen.Click.TargetBlock(TargetX + PlayerX, TargetY + PlayerY);
                }
                //Console.WriteLine($"Done Placing the {i} block");
                PlayerX = (int)Utility.LocalPlayer.X() / 32;
                PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            }
        }
    }
}
