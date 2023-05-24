// Copyright (c) 2023 Jeremy Lecky-Thompson. All rights reserved.
// This code is proprietary and may not be used without permission.

namespace NuGetDebugSwitcher;
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}