using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDictionary
{
    class EvuDict<DictKeyType, DictValType>
    {

        DictKeyType[] _dictKeyTypes;
        DictValType[] _dictValTypes;

        DictKeyType[] _tempDictKeyTypes;
        DictValType[] _tempDictValTypes;

        public EvuDict()
        {
            _dictKeyTypes = new DictKeyType[0];
            _dictValTypes = new DictValType[0];
        }

        public void Add(DictKeyType item1, DictValType item2)
        {

            _tempDictKeyTypes = _dictKeyTypes;
            _tempDictValTypes = _dictValTypes;

            _dictKeyTypes = new DictKeyType[_dictKeyTypes.Length + 1];
            _dictValTypes = new DictValType[_dictValTypes.Length + 1];

            for (int i = 0; i < _tempDictKeyTypes.Length; i++)
            {
                _dictKeyTypes[i] = _tempDictKeyTypes[i];
            }
            _dictKeyTypes[_dictKeyTypes.Length - 1] = item1;


            for (int i = 0; i < _tempDictValTypes.Length; i++)
            {
                _dictValTypes[i] = _tempDictValTypes[i];
            }
            _dictValTypes[_dictValTypes.Length - 1] = item2;

        }

        public DictKeyType[] Keys
        {
            get { return _dictKeyTypes; } //Set etmesini istemedik çünkü ReadOnly
        }

        public DictValType[] Values
        {
            get { return _dictValTypes; } //Set etmesini istemedik çünkü ReadOnly
        }
    }
}
