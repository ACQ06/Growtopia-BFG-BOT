using Mod_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modes
{
    class Break
    {
        public static void Start()
        {
            List<Utility.Vector2> TargetCoords = Form1.TargetCoords();
            int PlayerX = (int)Utility.LocalPlayer.X() / 32;
            int PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            int TargetX, TargetY;
            for (int i = 0; i < TargetCoords.Count; i++)
            {
                TargetX = TargetCoords[i].x;
                TargetY = TargetCoords[i].y;
                while (Utility.World.Foreground()[TargetY + PlayerY, TargetX + PlayerX] != 0)
                {
                    if (Form1.TargetCoords().Count != 0)
                    {
                        World2Screen.Click.TargetBlock(TargetX + PlayerX, TargetY + PlayerY);
                    }
                }
                PlayerX = (int)Utility.LocalPlayer.X() / 32;
                PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            }
        }
    }
    class Place
    {
        public static void Start()
        {
            List<Utility.Vector2> TargetCoords = Form1.TargetCoords();
            int PlayerX = (int)Utility.LocalPlayer.X()/32;
            int PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            int TargetX, TargetY;
            for (int i=0; i<TargetCoords.Count; i++)
            {
                TargetX = TargetCoords[i].x;
                TargetY = TargetCoords[i].y;
                while (Utility.World.Foreground()[TargetY+PlayerY,TargetX+PlayerX] == 0)
                {
                    if (Form1.TargetCoords().Count != 0)
                    {
                        World2Screen.Click.TargetBlock(TargetX + PlayerX, TargetY + PlayerY);
                    }                    
                }
                PlayerX = (int)Utility.LocalPlayer.X() / 32;
                PlayerY = (int)Utility.LocalPlayer.Y() / 32;
            }
        }
    }
}
