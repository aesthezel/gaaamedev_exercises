using System;

namespace gAAAmedev
{
    class DialogManager : Dialog
    {
        Dialog[] dialogDB = new Dialog[5];

        public void AddDialog(string name, string text, string type)
        {
            dialogDB[dialogCount] = new Dialog();
            dialogDB[dialogCount].CreateDialog(name, text, type);
        }

        public string GetDialog(int id)
        {
            string dialog = dialogDB[id].DialogText;
            return dialog;
        }
    }
}