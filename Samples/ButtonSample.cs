using System;
using Ooui;

namespace Samples
{
    public class ButtonSample : ISample
    {
        public string Title => "Button that count clicks";

        Button MakeButton ()
        {
            var button = new Button ("Click me!");
            var count = 0;
            button.Clicked += (s, e) => {
                count++;
                button.Text = $"Clicked {count} times";
            };
            return button;
        }

        public void Publish ()
        {
            var b = MakeButton ();

            UI.Publish ("/shared-button", b);
            UI.Publish ("/button", MakeButton);
        }

        public Element CreateElement ()
        {
            return MakeButton ();
        }
    }
}


