// Copyright (c) 2023 Jeremy Lecky-Thompson. All rights reserved.
// This code is proprietary and may not be used without permission.

namespace NuGetDebugSwitcher;

using System.Security.Principal;
public static class AdminElevate
{
    public static void RequireAdminPrivileges(Action privilegedCode)
    {
        try
        {
            // Check if the current user has administrative privileges
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            var isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

            // If the user is not an administrator, run the method with elevated privileges
            if (!isAdmin)
            {
                WindowsIdentity.RunImpersonated(WindowsIdentity.GetCurrent().AccessToken, privilegedCode);
            }
            else
            {
                privilegedCode.Invoke();
            }

        }
        catch (Exception ex)
        {
            // Handle exception when admin privileges are not available
            // Show an error message or perform alternative actions
        }
    }
}
