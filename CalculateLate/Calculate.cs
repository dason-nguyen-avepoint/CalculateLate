using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLate
{
    public class Calculate
    {
        public TimeSpan CalculateLate(DateTime start_shift, DateTime start_break, DateTime end_break, DateTime check_in, DateTime? start_leave = null, DateTime? end_leave = null)
        {
            TimeSpan result;
            if (start_leave == null || end_leave == null)
            {
                return result = CheckTimeNotRegister(start_shift, check_in, start_break, end_break);
            }
            else
            {
                return result = CheckTimeRegister(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            }
        }

        public TimeSpan CheckTimeNotRegister(DateTime start_shift, DateTime check_in, DateTime start_break, DateTime end_break)
        {
            if (check_in < start_break)
            {
                return (check_in - start_shift);
            }
            else if (check_in <= end_break)
            {
                return (start_break - start_shift);
            }
            else
            {
                return (start_break - start_shift) + (check_in - end_break);
            }
        }
        public TimeSpan CheckTimeRegister(DateTime start_shift, DateTime start_break, DateTime end_break, DateTime check_in, DateTime? start_leave, DateTime? end_leave)
        {
            TimeSpan balance_start;
            TimeSpan balance_end;
            // CALCULATE BALANCE START
            if (start_shift >= start_leave)
            {
                balance_start = TimeSpan.Zero;
            }
            else
            {
                if (start_leave < start_break)
                {
                    balance_start = (TimeSpan)(start_leave - start_shift);
                }
                else if (start_leave <= end_break)
                {
                    balance_start = start_break - start_shift;
                }
                else
                {
                    balance_start = (TimeSpan)(start_break - start_shift + (start_leave - end_break));
                }
            }
            // CALCULATE BALANCE END
            if (end_leave >= end_break)
            {
                if (check_in.CompareTo(end_leave) <= 0)
                {
                    balance_end = TimeSpan.Zero;
                }
                else
                {
                    balance_end = (TimeSpan)(check_in - end_leave);
                }
            }
            else if (end_leave >= start_break && end_leave < end_break)
            {
                if (check_in > end_break)
                {
                    balance_end = check_in - end_break;
                }
                else
                {
                    balance_end = TimeSpan.Zero;
                }
            }
            else
            {
                if (check_in <= end_leave)
                {
                    balance_end = TimeSpan.Zero;
                }
                else
                {
                    if (end_leave < check_in && check_in < start_break)
                    {
                        balance_end = (TimeSpan)(check_in - end_leave);
                    }
                    else if (start_break <= check_in && check_in <= end_break)
                    {
                        balance_end = (TimeSpan)(start_break - end_leave);
                    }
                    else
                    {
                        balance_end = (TimeSpan)(start_break - end_leave + (check_in - end_break));
                    }
                }
            }
            return balance_start + balance_end;
        }
    }
}
