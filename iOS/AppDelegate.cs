﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CarouselView.FormsPlugin.iOS;
using FFImageLoading.Transformations;
using Foundation;
using Prism;
using Prism.Ioc;
using UIKit;

namespace Core.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            CarouselViewRenderer.Init();

            var ignore = new CircleTransformation();
            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
