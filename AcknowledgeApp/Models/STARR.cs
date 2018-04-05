using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class STARR
    {
        private List<Actionpoint> actionpointlist = new List<Actionpoint>();
        private DateTime startDate;
        private DateTime lastEdit;
        private string situation;
        private string task;
        private string action;
        private string result;
        private string reflection;
        private Emotion emotion_traffic_light;

        public List<Actionpoint> Actionpointlist { get => actionpointlist; set => actionpointlist = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime LastEdit { get => lastEdit; set => lastEdit = value; }
        public string Situation { get => situation; set => situation = value; }
        public string Task { get => task; set => task = value; }
        public string Action { get => action; set => action = value; }
        public string Result { get => result; set => result = value; }
        public string Reflection { get => reflection; set => reflection = value; }
        public Emotion Emotion_traffic_light { get => emotion_traffic_light; set => emotion_traffic_light = value; }

        public enum Emotion
        {
            VeryPositive,
            Positive,
            Negative,
            VeryNegative
        }
    }
}
