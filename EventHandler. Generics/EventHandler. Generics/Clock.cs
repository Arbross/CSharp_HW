using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandler._Generics
{
    class ClockArgs : EventArgs
    {
        public byte OldHour { get; set; }
        public byte OldMinute { get; set; }
    }
    class Clock
    {
        private byte hour;
        private byte minute;
        private (byte hour, byte minute) alarm;
        public event EventHandler<ClockArgs> Time;
        public Clock(byte hour, byte minute)
        {
            Hour = hour;
            Minute = minute;
        }
        public byte Hour
        {
            get => hour;
            set
            {
                if (hour >= 0 && hour < 25)
                {
                    hour = value;
                }
            }
        }
        public byte Minute
        {
            get => minute;
            set
            {
                if (minute >= 0 && minute < 61)
                {
                    minute = value;
                }
            }
        }
        public void SetAlarm(byte hour, byte minute)
        {
            if (hour >= 0 && hour < 25)
            {
                if (minute >= 0 && minute < 61)
                {
                    alarm.hour = hour;
                    alarm.minute = minute;
                }
                else
                {
                    throw new IndexOutOfRangeException("");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("");
            }
        }
        public void CancelAlarm()
        {
            alarm.hour = 0;
            alarm.minute = 0;
        }
        public override string ToString()
        {
            return $"Hour : {Hour}, Minute : {Minute}.\nAlarm : {alarm.hour}/{alarm.minute}.\n";
        }
        public void Tick()
        { 
            if (minute == 59)
            {
                if (hour == 23)
                {
                    {
                        byte oldHour = hour;
                        byte oldMinute = minute;
                        hour = 0;
                        minute = 0;
                        Time?.Invoke(this, new ClockArgs { OldHour = oldHour, OldMinute = oldMinute });
                    }
                    return;
                }
                {
                    byte oldHour = hour;
                    byte oldMinute = minute;
                    ++hour;
                    minute = 0;
                    Time?.Invoke(this, new ClockArgs { OldHour = oldHour, OldMinute = oldMinute });
                }
                return;
            }
            {
                byte oldHour = hour;
                byte oldMinute = minute;
                ++minute;
                Time?.Invoke(this, new ClockArgs { OldHour = oldHour, OldMinute = oldMinute });
            }
        }
    }
}
