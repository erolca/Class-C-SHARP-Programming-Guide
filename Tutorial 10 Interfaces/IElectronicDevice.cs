﻿namespace CSharpTutA.cs
{
    // With interfaces you can create very
    // flexible systems. Here I'll model
    // generic electronic devices like 
    // TVs and Radios and remotes that 
    // control them and the buttons on the
    // remotes. 
    interface IElectronicDevice
    {
        // We want each device to have 
        // these capabilities
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();

    }
}