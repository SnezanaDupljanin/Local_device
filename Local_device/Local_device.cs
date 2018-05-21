using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Local_device
{
    public class Local_device
    {
        public int Code { get; set; }

        public TimeSpan vrijeme { get; set; }
        public int Value { get; set; }
        public static Random r = new Random();
        Logger.Logger logger = new Logger.Logger();

        public void SendToBuffer()
        {
            //da li ovdje idu vrijednosti koje pokupimo?
            int code = r.Next(1, 9);
            float value = r.Next();
            logger.WriteLogg(String.Format("Writter sending to Buffer code {0} and value {1}", code, value));
            buffer.SendData(code, value);

        }
    }
}
