﻿namespace Outlook.Core;

public interface IApplicationCommands
{
    CompositeCommand NavigateCommand { get; }
}
public class ApplicationCommands : IApplicationCommands
{
    public CompositeCommand NavigateCommand { get; } = new CompositeCommand();
}
