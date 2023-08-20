// See https://aka.ms/new-console-template for more information
using CommandPattern;

RemoteControl remoteControl = new RemoteControl();

Light livingLight = new Light("Living Room");
Light kitchenLight = new Light("Kitchen Room");
Stereo stereo = new Stereo("Living Room");

LightOnCommand livingCommandOn = new LightOnCommand(livingLight);
LightOffCommand livingCommandOff = new LightOffCommand(livingLight);
LightOnCommand kitchenCommandOn = new LightOnCommand(kitchenLight);
LightOffCommand kitchenCommandOff = new LightOffCommand(kitchenLight);
StereoWithOnCommand StereoWithOnCommand = new StereoWithOnCommand(stereo);
StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

remoteControl.setCommand(0, livingCommandOn, livingCommandOff);
remoteControl.setCommand(1, kitchenCommandOn, kitchenCommandOff);
remoteControl.setCommand(2, StereoWithOnCommand, stereoOffCommand);

Console.WriteLine(remoteControl.ToString());

remoteControl.onButtonWasPressed(0);
remoteControl.offButtonWasPressed(0);
remoteControl.onButtonWasPressed(1);
remoteControl.undoWasPressed();
remoteControl.offButtonWasPressed(1);
remoteControl.onButtonWasPressed(2);
remoteControl.offButtonWasPressed(2);
remoteControl.undoWasPressed();


