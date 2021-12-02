using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majorsilence.Winforms
{
    public static class ButtonExtensions
    {
        private static Dictionary<int, WaitingButton> _waiters = new Dictionary<int, WaitingButton>();


        public static void EndWaiting(this Button button)
        {
            int hash = button.GetHashCode();
            if (_waiters.ContainsKey(hash))
            {
                var b = _waiters[hash];
                b.Reset();
            }        
        }

        public static void StartWaiting(this Button button,
            string displayChar = "⬤", 
            bool disableButtonOnClick = true,
            (int width, int height)? resizeLabel = null,
            float resizeCharactersPercent = 1f)
        {
            int hash = button.GetHashCode();
            WaitingButton inst = null;
            if (_waiters.ContainsKey(hash))
            {
                 inst = _waiters[hash];
            }
            else
            {
                 inst = new WaitingButton(button);
                _waiters.Add(hash, inst);
          
            }

            inst.DisplayCharacter = displayChar;
            inst.DisableButtonOnClick = disableButtonOnClick;
            if(resizeLabel != null)
            {
                inst.ResizeLabels(resizeLabel.Value.width, resizeLabel.Value.height);
            }
            if(resizeCharactersPercent != 1f)
            {
                inst.ResizeCharacters(resizeCharactersPercent);
            }
            inst.OnClick();
        }
    }
}
