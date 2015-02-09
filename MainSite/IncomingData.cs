using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainSite
{
    static public class IncomingData
    {
        public static string IncomingDataString { get; set; }
        public static int LastTakedTemp;
        public static int LastSensorId;
        
        public static int GetTemp(string incData)
        {
            int temp = 999; //если вернет 999 - ошибка в данных 



            return temp;
        }
    }
}