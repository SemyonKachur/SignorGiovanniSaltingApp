using System;
using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{
    public sealed class TimeFieldsControlButtons
    {
        private Button _oneHourPlusIn;
        private Button _oneHourMinusIn;
        private Button _roundHourIn;

        private Button _oneHourPlusOut;
        private Button _oneHourMinusOut;
        private Button _roundHourOut;
        private TimeFields _timeFields;

        public TimeFieldsControlButtons(TimeFields timeFieldsClass)
        {
            _timeFields = timeFieldsClass;
            _oneHourPlusIn = GameObject.FindGameObjectWithTag("+1h").GetComponent<Button>();
            _oneHourMinusIn = GameObject.FindGameObjectWithTag("-1h").GetComponent<Button>();
            _roundHourIn = GameObject.FindGameObjectWithTag("RoundHourIn").GetComponent<Button>();

            _oneHourPlusOut = GameObject.FindGameObjectWithTag("+1hOut").GetComponent<Button>();
            _oneHourMinusOut = GameObject.FindGameObjectWithTag("-1hOut").GetComponent<Button>();
            _roundHourOut = GameObject.FindGameObjectWithTag("RoundHourOut").GetComponent<Button>();

            InitButtons();
        }

        private void InitButtons()
        {
            _oneHourPlusIn.onClick.AddListener(()=> OneHourPlus(_timeFields.DateFieldIn));
            _oneHourPlusOut.onClick.AddListener(() => OneHourPlus(_timeFields.DateFieldOut));

            _oneHourMinusIn.onClick.AddListener(() => OneHourMinus(_timeFields.DateFieldIn));
            _oneHourMinusOut.onClick.AddListener(() => OneHourMinus(_timeFields.DateFieldOut));

            _roundHourIn.onClick.AddListener(() => RoundHour(_timeFields.DateFieldIn));
            _roundHourOut.onClick.AddListener(() => RoundHour(_timeFields.DateFieldOut));
        }

        private void OneHourPlus(InputField inputField)
        {
            var Time = DateTime.Parse(inputField.text);
            Time = Time.AddHours(1.0);
            inputField.text = Time.ToString();
        }
        private void OneHourMinus(InputField inputField)
        {
            var Time = DateTime.Parse(inputField.text);
            Time = Time.AddHours(-1.0);
            inputField.text = Time.ToString();
        }
        private void RoundHour(InputField inputField)
        {
            var time = DateTime.Parse(inputField.text);
            Round(time);
            void Round(DateTime time)
            {

                if (time.Minute >= 30)
                {
                    time = time.AddHours(1);
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour, 0, 0);
                    inputField.text = time.ToString();
                }
                else
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour, 0, 0);
                    inputField.text = time.ToString();
                }
            }
        }

        private void Dispose()
        {
            _oneHourPlusIn.onClick.RemoveAllListeners();
            _oneHourPlusOut.onClick.RemoveAllListeners();

            _oneHourMinusIn.onClick.RemoveAllListeners();
            _oneHourMinusOut.onClick.RemoveAllListeners();

            _roundHourIn.onClick.RemoveAllListeners();
            _roundHourOut.onClick.RemoveAllListeners();
        }



    }
}
