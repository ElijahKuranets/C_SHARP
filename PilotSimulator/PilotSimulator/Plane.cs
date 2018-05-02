using System.Collections.Generic;

namespace PlaneSimulator
{
    /// <summary>
    ///     Класс, описывающий самолет
    /// </summary>
    internal class Plane
    {
        /// <summary>
        ///     Делегат для оповещения диспетчеров о проведении полета
        /// </summary>
        /// <param name="planeSpeed">Скорость самолета</param>
        /// <param name="planeAltitude">Высота самолета</param>
        /// <param name="maxSpeed">Максимальная скорость самолета</param>
        public delegate void notifyDispatchers(int planeSpeed, int planeAltitude, int maxSpeed);

        private readonly int dispCount;

        public notifyDispatchers dispInformator;

        public Plane()
        {
            Speed = 0;
            Altitude = 0;
            MaxSpeed = 1200;
            MinSpeed = 0;
            MinAltitude = 0;
            MaxAltitude = 10000;
            Dispatchers = new List<Dispatcher>();
            LandingGranted = false;
            dispCount = Dispatchers.Count;
        }

        public bool LandingGranted { get; set; }

        public List<Dispatcher> Dispatchers { get; }

        public int Speed { get; private set; }

        public int Altitude { get; private set; }

        public int MaxSpeed { get; }

        public int MinSpeed { get; }

        public int MinAltitude { get; }

        public int MaxAltitude { get; }

        /// <summary>
        ///     Добавление нового диспетчера
        /// </summary>
        /// <param name="disp">Объект диспетчера</param>
        public void addDispatcher(Dispatcher disp)
        {
            Dispatchers.Add(disp);
            dispInformator += disp.getRecommendedAltitude;
        }

        /// <summary>
        ///     Удаление диспетчера из наблюдения за полетом
        /// </summary>
        internal void removeDispatcher()
        {
            if (dispCount > 2)
                foreach (var disp in Dispatchers)
                    if (disp.DispatcherDisabled != true)
                    {
                        disp.DispatcherDisabled = true;
                        break;
                    }
            else
                throw new DispatcherDeleteDeniedException();
        }

        /// <summary>
        ///     Увеличение скорости самолета
        /// </summary>
        public void increaseSpeed()
        {
            if (Speed + 50 < MaxSpeed)
                Speed += 50;
        }

        /// <summary>
        ///     Увеличение скорости самолета форсажем
        /// </summary>
        public void increaseSpeedForsage()
        {
            if (Speed + 150 < MaxSpeed)
                Speed += 150;
        }

        /// <summary>
        ///     Уменьшение скорости самолета
        /// </summary>
        public void decreaseSpeed()
        {
            if (Speed - 50 > MinSpeed)
            {
                Speed -= 50;
            }
            else
            {
                if (Altitude != MinAltitude)
                {
                    Speed -= 50;
                    throw new WrongSpeedException(MinSpeed, MaxSpeed, Speed);
                }
                Speed -= 50;
            }
        }

        /// <summary>
        ///     Уменьшение скорости самолета форсажем
        /// </summary>
        public void decreaseSpeedForsage()
        {
            if (Speed - 150 > MinSpeed)
            {
                Speed -= 150;
            }
            else
            {
                Speed -= 150;
                throw new WrongSpeedException(MinSpeed, MaxSpeed, Speed);
            }
        }

        /// <summary>
        ///     Увеличение высоты самолета
        /// </summary>
        public void increaseAltitude()
        {
            if (Altitude + 250 < MaxAltitude)
                Altitude += 250;
        }

        /// <summary>
        ///     Увеличение высоты полета самолета форсажем
        /// </summary>
        public void increaseAltitudeForsage()
        {
            if (Altitude + 500 < MaxAltitude)
                Altitude += 500;
        }

        /// <summary>
        ///     Уменьшение высоты полета самолета
        /// </summary>
        public void decreaseAltitude()
        {
            if (Altitude - 250 > MinAltitude)
            {
                Altitude -= 250;
            }
            else
            {
                if (LandingGranted == false)
                {
                    Altitude -= 250;
                    throw new WrongAltitudeException(MinAltitude, MaxAltitude, Altitude);
                }
                Altitude -= 250;
            }
        }

        /// <summary>
        ///     Уменьшение высоты полета самолета форсажем
        /// </summary>
        public void decreaseAltitudeForsage()
        {
            if (Altitude - 500 > MinAltitude)
            {
                Altitude -= 500;
            }
            else
            {
                if (LandingGranted == false)
                {
                    Altitude -= 500;
                    throw new WrongAltitudeException(MinAltitude, MaxAltitude, Altitude);
                }
                Altitude -= 500;
            }
        }
    }
}