using System.IO.Ports;

namespace AmiiBomb
{

    public class PN532_HSU
    {
        public SerialPort Serial;

        public const int PN532_HSU_READ_TIMEOUT = 1000;

        public PN532_HSU(SerialPort Serial)
        {
            this.Serial = Serial;
            WakeUp();
        } 

        public void WakeUp()
        {
            byte[] SendBuffer = new byte[] { 0x55, 0x55, 0x0, 0x0, 0x0 };
            Serial.Write(SendBuffer, 0, SendBuffer.Length);
        }

        public int WriteCommand(byte[] header, byte[] body)
        {
            return 0;
        }

        public byte[] ReadResponse(int timeout = PN532_HSU_READ_TIMEOUT)
        {
            return null;
        }

    }
}