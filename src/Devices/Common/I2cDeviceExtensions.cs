using Windows.Devices.I2c;

namespace Uwp.Gpio.Devices.Common
{
    public static class I2cDeviceExtensions
    {
        public static byte Read(this I2cDevice device, byte addr)
        {
            byte[] readBuffer = new byte[1];
            device.WriteRead(new[] { addr }, readBuffer);
            byte b = readBuffer[0];
            return b;
        }

        public static void Write(this I2cDevice device, byte b)
        {
            device.Write(new[] { b });
        }

        public static void Write(this I2cDevice device, byte addr, byte data)
        {
            device.Write(new[] { addr, data });
        }
    }
}
