using System;

namespace IoTSensorMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; }  // 현재 시간
        public int Value { get; set; }         // 센서 값

        public bool SimulFlag { get; set; }    // 시뮬레이션 여부
        public SensorData(DateTime current, int value, bool simulflag)
        {
            Current = current;
            Value = value;
            SimulFlag = simulflag;
        }
    }
}
