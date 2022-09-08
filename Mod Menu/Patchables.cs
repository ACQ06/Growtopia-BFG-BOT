using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patchables
{
    class LocalPlayer
    {
        public static string Main = "Growtopia.exe";
        public static string App = String.Format("{0}{1}", "0x", BaseFinder.Modules.AppOffset().ToString("X"));

        public static Pointer Name = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "ab0", "1B0", "28", "0" }
        };

        public static Pointer X = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] {"AB0", "1B0", "8"}
        };

        public static Pointer Y = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "1B0", "C" }
        };

        public static Pointer Direction = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "1B0", "61" }
        };

        public static Pointer CurrentItem = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "260"}
        };

        public static Pointer TakenInventorySlots = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "230" }
        };

        public static Pointer TotalInventorySlots = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "240" }
        };

        public static Pointer Inventory_Data = new Pointer
        {   
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "228" }
        };

        public static Pointer Gems = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "268" }
        };
    }

    class Camera
    {
        public static string Main = "Growtopia.exe";
        public static string App = String.Format("{0}{1}", "0x", BaseFinder.Modules.AppOffset().ToString("X"));

        public static Pointer X = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "110", "A8" }
        };

        public static Pointer Y = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "110", "AC" }
        };

        public static Pointer ZoomFactor = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "110", "C4" }
        };
    }

    class World
    {
        public static string Main = "Growtopia.exe";
        public static string App = String.Format("{0}{1}", "0x", BaseFinder.Modules.AppOffset().ToString("X"));

        public static Pointer Data = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "108", "28" }
        };

        public static Pointer Heigth = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "108", "1C" }
        };

        public static Pointer Width = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "AB0", "108", "18" }
        };

        public static Pointer Dropped_Items = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "ab0", "108", "40", "58" }
        };

        public static Pointer Dropped_Items_Count = new Pointer
        {
            Module = Main,
            Offset = App,
            Offsets = new string[] { "ab0", "108", "40", "60" }
        };
    }

    public class Pointer
    {
        public string Module;
        public string Offset;
        public string[] Offsets;

        /// <summary>
        /// Return every part of the Pointer into a single String useable by the memory.dll Library.
        /// </summary>
        public string Get()
        {
            string pointer = String.Format("{0}+{1}", this.Module, Offset);
            foreach (string offset in this.Offsets)
            {
                pointer = String.Format("{0},{1}", pointer, offset);
            }
            return pointer;
        }
    }
}
