using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace life_planner.Droid
{
    public static class Constants
    {
        public const string ListenConnectionString = "<Endpoint=sb://notificationsNS.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=4npRBG/yX9UaDFyz+OLKek2EOETn4dKQPnersqRkU0s=>";
        public const string NotificationHubName = "<notificationsNS>";
    }
}