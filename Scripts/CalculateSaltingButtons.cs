using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{
    public class CalculateSaltingButtons
    {
        private Button _calculateButtonIn;
        private Button _calculateButtonOut;

        public Button CalculateButtonIn => _calculateButtonIn;
        public Button CalculateButtonOut => _calculateButtonOut;



        public CalculateSaltingButtons()
        {
            _calculateButtonIn = GameObject.FindGameObjectWithTag("CaclulateButton").GetComponent<Button>();
            _calculateButtonOut = GameObject.FindGameObjectWithTag("CalculateOutButton").GetComponent<Button>();
        }

    }
}
