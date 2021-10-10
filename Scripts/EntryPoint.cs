using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace SignorJiovanniSaltingApp
{

    public sealed class EntryPoint : MonoBehaviour
    {
        private ModuleController _moduleController;

        private void Awake()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            _moduleController = new ModuleController();
        }


    }
}
