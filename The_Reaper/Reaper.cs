using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;

namespace The_Reaper
{
    public class Reaper : Robot
    {
        /// <summary>
        /// Robo anda em movimentos triangulares
        /// </summary>
        public override void Run()
        {
            while(true)
            {
                Ahead(500);
                TurnRight(135);
                TurnGunRight(720);
                Ahead(500);
                TurnRight(135);
                TurnGunRight(720);
            }
        }

        /// <summary>
        /// Quando um robo é detectado 
        /// </summary>
        /// <param name="evnt"></param>
        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            if (evnt.Distance < 300) //se detectado um 300 pixes distante
            {
                Fire(3);
                TurnLeft(evnt.Bearing);
                Fire(3);
                TurnLeft(90); //atira e se distancia para distancia contrária
                Ahead(600);
            }
            else
            {
                Fire(1);
                TurnLeft(evnt.Bearing);
                Fire(1);
                TurnLeft(90); //atira e se distancia para distancia contrária
                Ahead(600);
            }
        }



    }
}
