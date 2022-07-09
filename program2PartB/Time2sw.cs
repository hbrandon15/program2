using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class Time2sw : Time2
    {
        private int milisecond; // 0 - 999

        public Time2sw(int hour, int minute, int second, int milisecond)
            : base(hour, minute, second)
        {
            Milisecond = milisecond; // validates miliseconds
        }

        public Time2sw(Time2 time, int milisecond = 0)
            : base(time)
        {
            Milisecond = milisecond;
        }

        public Time2sw(Time2sw time, int milisecond)
            : base(time)
        {
            this.Milisecond = milisecond;
        }
        public int Milisecond
        {
            get { return milisecond; }
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Milisecond)} must be 0-999");
                }
                milisecond = value;
            }
        }
        // convert to string in universal-time format (HH:MM:SS:MS)
        public override string ToUniversalString() =>
        $"{Hour:D2}:{Minute:D2}:{Second:D2}:{Milisecond:D2}";

        // convert to string in standard-time format (H:MM:SS AM or PM)
        public override string ToString() =>
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
        $"{Minute:D2}:{Second:D2}:{Milisecond:D2} {(Hour < 12 ? "AM" : "PM")}";

    }
}
