﻿namespace Particular.ServiceInsight.Desktop.Shell
{
    public interface IShellView : IPersistableLayout
    {
        void ChangeTheme(string name);
        void SelectTab(string name);
    }
}