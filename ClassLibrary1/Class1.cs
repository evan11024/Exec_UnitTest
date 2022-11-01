using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaiwanStockUtility

{
    public class TaiwanStockUtility
	{
        public bool IsTradingTime(DateTime dt)
        {
            int weekday =Convert.ToInt32 (dt.DayOfWeek);
            int hour =Convert.ToInt32 (dt.Hour);
            int minute =Convert.ToInt32 (dt.Minute);

            if (weekday > 0 && weekday <= 5)
            {
                if (hour >= 9 && hour <= 12)
                {
                    return true;
                }
                else if (hour == 13 && minute <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
