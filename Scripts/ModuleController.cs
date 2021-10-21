using System;
using UnityEngine;

namespace SignorJiovanniSaltingApp
{
    public sealed class ModuleController
    {
        private ICheeseHeadInput _cheeseHeadsMassIF;
        private IResultTimeText _resultTimeText;
        private ITimeFields _timeFields;
        private ISaltingTime _saltingTime;
        private ICalculateButton _calculateSaltingButtons;


        public ModuleController()
        {
            _cheeseHeadsMassIF = new CheeseHeadsMassInputFields();
            _resultTimeText = new ResultTimeText();
            _timeFields = new TimeFields();
            _saltingTime = new SaltingTimePerMassInputField();
            _calculateSaltingButtons = new CalculateSaltingButtons();

            _calculateSaltingButtons.CalculateButtonIn.onClick.AddListener(Caculate);
            _calculateSaltingButtons.CalculateButtonOut.onClick.AddListener(CaculateOut);
        }

        public void Caculate()
        {
            var Time = DateTime.Parse(_timeFields.DateFieldIn.text);
            _resultTimeText.Title.text = "Достаем:";
            for (int i = 0; i < _cheeseHeadsMassIF.CheeseHeadsInputFields.Length; i++)
            {
                try
                {
                    var saltingHours = double.Parse(_cheeseHeadsMassIF.CheeseHeadsInputFields[i].text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)
                        * 10 
                        * double.Parse(_saltingTime.SaltingTime.text)
                        / 60;
                    var time = Time.AddHours(saltingHours);
                    _resultTimeText.ResuldTimeText[i].text = time.ToShortDateString() + " " + time.ToShortTimeString();
                    _resultTimeText.ResuldTimeText[i].color = Color.white;
                }
                catch
                {
                    _resultTimeText.ResuldTimeText[i].text = "-";
                    _resultTimeText.ResuldTimeText[i].color = Color.white;
                }
            }
        }

        public void CaculateOut()
        {
            var Time = DateTime.Parse(_timeFields.DateFieldOut.text);
            _resultTimeText.Title.text = "Закидываем:";
            for (int i = 0; i < _cheeseHeadsMassIF.CheeseHeadsInputFields.Length; i++)
            {
                try
                {
                    var saltingHours = 
                        double.Parse(_cheeseHeadsMassIF.CheeseHeadsInputFields[i].text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) 
                        * 10 
                        * double.Parse(_saltingTime.SaltingTime.text) 
                        / 60;

                    var time = Time.AddHours(-saltingHours);
                    if (time < DateTime.Now)
                    {
                        _resultTimeText.ResuldTimeText[i].text = time.ToShortDateString() + " " + time.ToShortTimeString();
                        _resultTimeText.ResuldTimeText[i].color = Color.red;
                    }
                    else
                    {
                        _resultTimeText.ResuldTimeText[i].text = time.ToShortDateString() + " " + time.ToShortTimeString();
                        _resultTimeText.ResuldTimeText[i].color = Color.white;
                    }

                }
                catch
                {
                    _resultTimeText.ResuldTimeText[i].text = "-";
                }
            }
        }


    }
}
