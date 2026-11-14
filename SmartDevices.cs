/****************/
/* Mã sinh viên: 202419003 */
/* Họ tên: Nguyễn Thành Trung */
/****************/

using System;

namespace SmartHomeMini
{
    public class SmartLight : IDevice
    {
        public string Name { get; }

        public SmartLight(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Name}: ON");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name}: OFF");
        }
    }

    public class SmartFan : IDevice
    {
        public string Name { get; }

        public SmartFan(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Name}: ON");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name}: OFF");
        }
    }

    public class SmartDoor : IDevice, ILockable
    {
        public string Name { get; }

        public SmartDoor(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Name}: System Powered ON");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name}: System Powered OFF");
        }

        public void Lock()
        {
            Console.WriteLine($"{Name}: LOCKED");
        }

        public void Unlock()
        {
            Console.WriteLine($"{Name}: UNLOCKED");
        }
    }
}