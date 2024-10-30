using CLL.LLClasses;
using KAF.UI.Module;
using System.Globalization;
using System.Windows;

namespace KAF.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MasterWindow : Window
    {
        private readonly IRegionManager _regionManager;

        public MasterWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            _regionManager = regionManager;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }


        private void LanguageToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeApplicationCulture("ar-KW"); // Change to Arabic
            LanguageToggleButton.Content = _Common.LanguageToggle; // Update toggle button text
        }

        private void LanguageToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeApplicationCulture("en-US"); // Change to English
            LanguageToggleButton.Content = _Common.LanguageToggle; // Update toggle button text
        }

        private void ChangeApplicationCulture(string cultureCode)
        {
            var newCulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            // Update flow direction based on the new culture
            SetFlowDirectionBasedOnCulture();
            // Get the region by name
            var contentRegion = _regionManager.Regions[RegionNameConfig.ContentRegionName];
            // Check if the region exists
            if (contentRegion != null)
            {
                // Optionally, get the active view
                var activeView = contentRegion.ActiveViews.FirstOrDefault();
                if (activeView != null)
                {
                    contentRegion.RemoveAll();
                    // Re-add the views (you can also navigate or register again)
                    _regionManager.RequestNavigate(RegionNameConfig.ContentRegionName, activeView.GetType().Name);
                }
            }
        }


        private void SetFlowDirectionBasedOnCulture()
        {
            // Get the current culture
            var currentCulture = Thread.CurrentThread.CurrentCulture;

            // Check if the culture is RTL
            if (currentCulture.TextInfo.IsRightToLeft)
            {
                // Set FlowDirection to RightToLeft
                this.FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                // Set FlowDirection to LeftToRight
                this.FlowDirection = FlowDirection.LeftToRight;
            }
        }
    }
}