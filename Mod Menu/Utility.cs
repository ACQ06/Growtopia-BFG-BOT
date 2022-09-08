using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    class World
    {
        public static Mem m = new Mem();
        public static int GT = m.GetProcIdFromName("Growtopia");
        public static int Height()
        {
            m.OpenProcess(GT);
            return m.ReadByte(Patchables.World.Heigth.Get());
        }

        public static int Width()
        {
            m.OpenProcess(GT);
            return m.ReadByte(Patchables.World.Width.Get());
        }
        public static int[,] Foreground()
        {
            m.OpenProcess(GT);
            Int32 next = 0x4;
            int[,] Foreground = new int[Height(), Width()];
            for (int i = 0; i < Height(); i++)
            {
                for (int j = 0; j < Width(); j++)
                {
                    Foreground[i, j] = m.Read2Byte($"{Patchables.World.Data.Get()},{next.ToString("X")}");
                    next += 0x90;
                }
            }
            return Foreground;
        }
        public static int[,] Background()
        {
            m.OpenProcess(GT);
            Int32 next = 0x6;
            int[,] Background = new int[Height(), Width()];
            for (int i = 0; i < Height(); i++)
            {
                for (int j = 0; j < Width(); j++)
                {
                    Background[i, j] = m.Read2Byte($"{Patchables.World.Data.Get()},{next.ToString("X")}");
                    next += 0x90;
                }
            }
            return Background;
        }

        public static int GetBlock(int x, int y)
        {
            if (Foreground()[y, x] == 0) return Background()[y, x];
            return Foreground()[y, x];
        }
    }
    class LocalPlayer
    {
        public static Mem m = new Mem();
        public static int GT = m.GetProcIdFromName("Growtopia");

        public static string Name()
        {
            m.OpenProcess(GT);
            return m.ReadString(Patchables.LocalPlayer.Name.Get());
        }

        public static float X()
        {
            m.OpenProcess(GT);
            return m.ReadFloat(Patchables.LocalPlayer.X.Get());
        }

        public static void X(float X)
        {
            m.OpenProcess(GT);
            m.WriteMemory(Patchables.LocalPlayer.X.Get(), "float", X.ToString());
        }

        public static float Y()
        {
            m.OpenProcess(GT);
            return m.ReadFloat(Patchables.LocalPlayer.Y.Get());
        }

        public static void Y(float Y)
        {
            m.OpenProcess(GT);
            m.WriteMemory(Patchables.LocalPlayer.Y.Get(), "float", Y.ToString());
        }

        public static int Direction()
        {
            m.OpenProcess(GT);
            return m.ReadInt(Patchables.LocalPlayer.Direction.Get());
        }

        public static int CurrentItem()
        {
            m.OpenProcess(GT);
            return m.ReadInt(Patchables.LocalPlayer.CurrentItem.Get());
        }

        public static void CurrentItem(int ItemID)
        {
            m.OpenProcess(GT);
            m.WriteMemory(Patchables.LocalPlayer.CurrentItem.Get(), "int", ItemID.ToString());
        }

        public static int TakenInventorySlots()
        {
            m.OpenProcess(GT);
            return m.ReadInt(Patchables.LocalPlayer.TakenInventorySlots.Get());
        }

        public static int TotalInventorySlots()
        {
            m.OpenProcess(GT);
            return m.ReadInt(Patchables.LocalPlayer.TotalInventorySlots.Get());
        }

        public static int InventoryItemCount(int ItemID)
        {
            m.OpenProcess(GT);
            int Count = 0;
            int foundID = 0;
            string next = "8,";
            while (foundID != ItemID)
            {
                foundID = m.ReadByte($"{Patchables.LocalPlayer.Inventory_Data.Get()},{next}10");
                Count = m.ReadByte($"{Patchables.LocalPlayer.Inventory_Data.Get()},{next}12");
                next += "8,";
            }
            return Count;
        }

        public static bool IsInInventory(int ItemID)
        {
            m.OpenProcess(GT);
            int foundID = 0;
            string next = "8,";
            int firstID = m.ReadByte($"{Patchables.LocalPlayer.Inventory_Data.Get()},{next}10");

            if (firstID == ItemID) return true;

            next += "8,";
            while (foundID != firstID)
            {
                foundID = m.ReadByte($"{Patchables.LocalPlayer.Inventory_Data.Get()},{next}10");
                next += "8,";
                if (foundID == ItemID)
                {
                    return true;
                }
            }

            return false;
        }
    }
    class Camera
    {
        public static Mem m = new Mem();
        public static int GT = m.GetProcIdFromName("Growtopia");

        public static float X()
        {
            m.OpenProcess(GT);
            return m.ReadFloat(Patchables.Camera.X.Get());
        }

        public static float Y()
        {
            m.OpenProcess(GT);
            return m.ReadFloat(Patchables.Camera.Y.Get());
        }

        public static float ZoomFactor()
        {
            m.OpenProcess(GT);
            return m.ReadFloat(Patchables.Camera.ZoomFactor.Get());
        }
    }
    public class Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }
    }
}
