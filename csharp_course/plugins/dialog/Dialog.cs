using System;

namespace gAAAmedev
{
    class Dialog
    {
        int _dialogID;
        string _dialogText;
        string _person;
        string _type;

        protected static int dialogCount;

        public string DialogText 
        {
            get
            {
                return _dialogID + ":: " + "["+_type+"] " + _person + ", dice:\n" + _dialogText;
            }

            set
            {
                _dialogID = dialogCount;
                _dialogText = value;
            }
            
        }

        public void CreateDialog(string person, string text, string type)
        {
            dialogCount++;
            _person = person;
            DialogText = text;
            _type = type;
            //Console.WriteLine("¡El dialogo número {0} ha sido creado!", dialogCount);
        }

    }
}