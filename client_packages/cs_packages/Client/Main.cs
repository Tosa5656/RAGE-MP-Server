using RAGE;
using System;
using System.Collections;

public class Main : Events.Script
{
    public Main()
    {
        Events.OnPlayerReady += OnPlayerReady;
    }

    public void OnPlayerReady()
    {
        Chat.Output("Добро пожаловать!");
    }
}