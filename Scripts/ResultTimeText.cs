using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{
    public sealed class ResultTimeText : IResultTimeText
    {
        private Text _title;
        private Text[] _resultTimeText = new Text[5];
        
        public Text[] ResuldTimeText => _resultTimeText;
        public Text Title => _title;

        public ResultTimeText()
        {
            for (int i = 0; i < _resultTimeText.Length; i++)
            {
                _resultTimeText[i] = GameObject.FindGameObjectWithTag("ResultText" + (i + 1)).GetComponent<Text>();
            }

            _title = GameObject.FindGameObjectWithTag("Title").GetComponent<Text>();
        }
    }

    public interface IResultTimeText
    {
        public Text[] ResuldTimeText { get; }
        public Text Title { get; }
    }
}
