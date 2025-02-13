﻿namespace MauiApp

open Android.App
open Android.Content.PM
open Android.OS
open Microsoft.Maui
open Microsoft.Maui.Essentials

[<Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation ||| ConfigChanges.UiMode ||| ConfigChanges.ScreenLayout ||| ConfigChanges.SmallestScreenSize))>]
type MainActivity() =
    inherit MauiAppCompatActivity()

    override this.OnCreate(savedInstanceState: Bundle) =
        Resource.UpdateIdValues()
        base.OnCreate(savedInstanceState)
        Platform.Init(this, savedInstanceState)

    override this.OnRequestPermissionsResult(requestCode: int, permissions: string[], grantResults: Permission[]) =
        Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults)
        base.OnRequestPermissionsResult(requestCode, permissions, grantResults)