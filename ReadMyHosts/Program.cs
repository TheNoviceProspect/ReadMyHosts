﻿using ReadMyHosts.Core.Logger;
using Avalonia;
using Avalonia.ReactiveUI;

namespace ReadMyHosts
{
    internal class Program
    {
        #region Public Methods

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();

        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args)
        {
            Log.DebugLogInit();
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
            Log.FlushLogs();
        }

        #endregion Public Methods
    }
}
