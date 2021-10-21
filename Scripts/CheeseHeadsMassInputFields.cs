using UnityEngine.UI;
using UnityEngine;

namespace SignorJiovanniSaltingApp
{
    public sealed class CheeseHeadsMassInputFields: ICheeseHeadInput
    {
        private InputField[] _cheeseHeads = new InputField[5];
        public InputField[] CheeseHeadsInputFields => _cheeseHeads;

        public CheeseHeadsMassInputFields()
        {
            for (int i = 0; i < _cheeseHeads.Length; i++)
            {
                _cheeseHeads[i] = GameObject.FindGameObjectWithTag("CheeseHead" + (i + 1)).GetComponent<InputField>();
            }
        }
    }

    public interface ICheeseHeadInput
    {
        public InputField[] CheeseHeadsInputFields { get; }
    }
}
