/****************/
/* Mã sinh viên: 202419003 */
/* Họ tên: Nguyễn Thành Trung */
/****************/

using System;

namespace SmartHomeMini
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHƯƠNG TRÌNH KIỂM THỬ SMART HOME MINI ===\n");

            // T1: Tạo light, fan, door
            Console.WriteLine("[T1] Kiểm tra tạo thiết bị qua Factory:");
            IDevice light = DeviceFactory.Create("light", "Living room light");
            IDevice fan = DeviceFactory.Create("fan", "Living room fan");
            IDevice door = DeviceFactory.Create("door", "Main door");
            Console.WriteLine("-> Tạo thiết bị thành công.\n");

            // T2: Tạo loại camera khi chưa hỗ trợ
            Console.WriteLine("[T2] Kiểm tra tạo loại không hỗ trợ (Camera):");
            try
            {
                DeviceFactory.Create("camera", "Front Camera");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"-> Bắt được ngoại lệ thành công: {ex.Message}\n");
            }

            // T3: Lấy HomeConfiguration.Instance hai lần
            Console.WriteLine("[T3] Kiểm tra Singleton HomeConfiguration:");
            HomeConfiguration config1 = HomeConfiguration.Instance;
            HomeConfiguration config2 = HomeConfiguration.Instance;
            bool isSameInstance = ReferenceEquals(config1, config2);
            Console.WriteLine($"-> ReferenceEquals(config1, config2): {isSameInstance}");
            if (!isSameInstance)
            {
                throw new Exception("Singleton implementation is incorrect.");
            }
            Console.WriteLine();

            // Khởi tạo Facade
            var facade = new SmartHomeFacade(light, fan, (ILockable)door);

            // T4: Gọi GoToWork()
            Console.WriteLine("[T4] Kiểm tra phương thức GoToWork():");
            facade.GoToWork();

            // T5: Gọi GoToSleep()
            Console.WriteLine("[T5] Kiểm tra phương thức GoToSleep():");
            facade.GoToSleep();

            Console.WriteLine("\n=== HOÀN TẤT TOÀN BỘ KIỂM THỬ ===");
        }
    }
}