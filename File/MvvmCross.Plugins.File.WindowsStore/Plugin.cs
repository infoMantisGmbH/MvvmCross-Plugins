﻿// Plugin.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace MvvmCross.Plugins.File.WindowsStore
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<IMvxFileStore, MvxWindowsStoreFileStore>();
            Mvx.RegisterType<IMvxFileStoreAsync, MvxWindowsStoreFileStore>();
        }
    }
}