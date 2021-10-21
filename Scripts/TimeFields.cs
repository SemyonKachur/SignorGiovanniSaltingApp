using System;
using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{
    public sealed class TimeFields : ITimeFields
    {
        private InputField _dateFieldIn;
        private InputField _dateFieldOut;
        private DateTime _currentTime = new DateTime();

        public InputField DateFieldIn => _dateFieldIn;
        public InputField DateFieldOut => _dateFieldOut;

        private TimeFieldsControlButtons _timeFieldsControlButtons;

        public TimeFields()
        {
            _currentTime = DateTime.Now;

            _dateFieldIn = GameObject.FindGameObjectWithTag("TimeFieldIn").GetComponent<InputField>();
            _dateFieldIn.text = _currentTime.ToString();
            _dateFieldOut = GameObject.FindGameObjectWithTag("TimeFieldOut").GetComponent<InputField>();
            _dateFieldOut.text = _currentTime.ToString();

            _timeFieldsControlButtons = new TimeFieldsControlButtons(this);
        }
    }

    public interface ITimeFields
    {
        public InputField DateFieldIn { get; }
        public InputField DateFieldOut { get; }
    }
}
