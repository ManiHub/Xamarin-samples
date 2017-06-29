using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Location;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Security;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.Tasks;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.UI.Controls;
using Android.Widget;

namespace XamarinUITest
{
    [Activity (Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        MapViewModel _mapViewModel = new MapViewModel();
        MapView _mapView;
        Button la;
        Button lv;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set the view from the "Main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get MapView from the view and assign map from view-model
            _mapView = FindViewById<MapView>(Resource.Id.MyMapView);
            _mapView.Map = _mapViewModel.Map;

            // Listen for changes on the view model
            _mapViewModel.PropertyChanged += MapViewModel_PropertyChanged;

            la = FindViewById<Button>(Resource.Id.la);
            la.Click += La_Click;

            lv = FindViewById<Button>(Resource.Id.lv);
            lv.Click += Lv_Click;
        }

        private void Lv_Click(object sender, EventArgs e)
        {
            _mapView.SetViewpointAsync(new Viewpoint(36.1699, -115.1398, 15000));
        }

        private void La_Click(object sender, EventArgs e)
        {
            _mapView.SetViewpointAsync(new Viewpoint(34.0522, -118.2437, 15000));
        }

        private void MapViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Update the map view with the view model's new map
            if (e.PropertyName == "Map" && _mapView != null)
                _mapView.Map = _mapViewModel.Map;
        }
    }
}