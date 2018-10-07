using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using IllusionPlugin;
using UnityEngine;

namespace EnableRotationPlugin
{
    public class Plugin : IPlugin
    {

        int currentLevelId = 0;

        public string Name
        {
            get { return "EnableRotation"; }
        }
        public string Version
        {
            get { return "0.1"; }
        }

        public void OnApplicationQuit()
        {
        }

        public void OnApplicationStart()
        {
        }

        public void OnFixedUpdate()
        {
        }

        public void OnLevelWasInitialized(int level)
        {
            currentLevelId = level;
        }

        public void OnLevelWasLoaded(int level)
        {
        }

        public void OnUpdate()
        {
            if (currentLevelId == 1)
            {
                PlayerBody.localPlayer.movement.turnType = PlayerBody.TurnType.AutoUpsideDownSmooth;
            }
        }
    }
}
