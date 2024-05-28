using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Controls.Platform;
using TreinoDoDia.Maui;
using UIKit;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace TreinoDoDia.Maui
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Remove borda inferior
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}

