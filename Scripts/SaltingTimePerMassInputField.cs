
using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{
    public sealed class SaltingTimePerMassInputField : ISaltingTime
    {
        private InputField _saltingTime;
        public InputField SaltingTime => _saltingTime;

        public SaltingTimePerMassInputField()
        {
            _saltingTime = GameObject.FindGameObjectWithTag("SaltingTime").GetComponent<InputField>();
            _saltingTime.text = "100";
        }
    }

    public interface ISaltingTime
    {
        public InputField SaltingTime { get; }
    }
}
