using Android.App;
using Android.Content.Res;
using Android.Runtime;

namespace TreinoDoDia.Maui
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                if (view is Entry)
                {
                    // Remove bottom border
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    // Remove bottom line
                    handler.PlatformView.SetHintTextColor(ColorStateList.ValueOf(Android.Graphics.Color.Gray));

                }
            });
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
