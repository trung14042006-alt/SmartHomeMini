/****************/
/* Mã sinh viên: 202419003 */
/* Họ tên: Nguyễn Thành Trung */
/****************/

using System;

namespace SmartHomeMini
{
    public static class DeviceFactory
    {
        public static IDevice Create(string type, string name)
        {
            return type.Trim().ToLowerInvariant() switch
            {
                "light" => new SmartLight(name),
                "fan" => new SmartFan(name),
                "door" => new SmartDoor(name),
                _ => throw new ArgumentException($"Unsupported device type: {type}")
            };
        }
    }
}