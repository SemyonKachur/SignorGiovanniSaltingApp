
using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{
    public sealed class SaltingTimePerMassInputField
    {
        private InputField _saltingTime;
        public InputField SaltingTime => _saltingTime;

        public SaltingTimePerMassInputField()
        {
            _saltingTime = GameObject.FindGameObjectWithTag("SaltingTime").GetComponent<InputField>();
            _saltingTime.text = "100";
        }
    }
}
