﻿using Rocket.API;

namespace RobnRaid
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string PlayerNotFoundColor;
        public string RobMessageColor;
        public string RobOverMessageColor;
        public string RobAssistMessageColor;
        public string RaidMessageColor;
        public string RaidAssistMessageColor;
        public string RaidOverMessageColor;
        public uint MaxRobDistanceInMetres;
        public uint MaxRobAssistDistanceInMetres;
        public uint MaxRaidAssistDistanceInMetres;

        public void LoadDefaults()
        {
            PlayerNotFoundColor = "Yellow";
            RobMessageColor = "Red";
            RobOverMessageColor = "Blue";
            RobAssistMessageColor = "Magenta";
            RaidMessageColor = "Red";
            RaidAssistMessageColor = "Magenta";
            RaidOverMessageColor = "Blue";
            MaxRobDistanceInMetres = 5;
            MaxRobAssistDistanceInMetres = 5;
            MaxRaidAssistDistanceInMetres = 5;

        }
    }
}
