/****************/
/* Mã sinh viên: 202419003 */
/* Họ tên: Nguyễn Thành Trung */
/****************/

using System;

namespace SmartHomeMini
{
    public sealed class SmartHomeFacade
    {
        private readonly IDevice light;
        private readonly IDevice fan;
        private readonly ILockable door;

        public SmartHomeFacade(IDevice light, IDevice fan, ILockable door)
        {
            this.light = light ?? throw new ArgumentNullException(nameof(light));
            this.fan = fan ?? throw new ArgumentNullException(nameof(fan));
            this.door = door ?? throw new ArgumentNullException(nameof(door));
        }

        public void GoToWork()
        {
            Console.WriteLine("\n--- Chế độ: Đi làm (GoToWork) ---");
            light.TurnOff();
            fan.TurnOff();
            door.Lock();
        }

        public void GoToSleep()
        {
            Console.WriteLine("\n--- Chế độ: Đi ngủ (GoToSleep) ---");
            fan.TurnOff();
            door.Lock();
            light.TurnOn();
            int level = HomeConfiguration.Instance.NightLightLevel;
            Console.WriteLine($"Night light level: {level}%");
        }
    }
}