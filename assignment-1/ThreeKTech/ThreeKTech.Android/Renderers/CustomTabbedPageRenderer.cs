using Android.Content;
using ThreeKTech.Droid.Renderers;
using ThreeKTech.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

//[assembly: ExportRenderer(typeof(MasterTabbedPage), typeof(CustomTabbedPageRenderer))] //commented to use Plugin.Badge renderer
namespace ThreeKTech.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(Context context) : base(context) { }
        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null || e.OldElement != null)
                return;
            //CODE: for selected tab background and separator
        }
    }
}