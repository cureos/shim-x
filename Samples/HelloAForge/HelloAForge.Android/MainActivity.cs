﻿// Copyright (c) 2010-2015 Anders Gustafsson, Cureos AB.
// All rights reserved. Any unauthorised reproduction of this 
// material will constitute an infringement of copyright.

namespace HelloAForge.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;

    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    [Activity(Label = "HelloAForge", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

