public class Client
{
    public static void RunTests()
    {
        //var remote = new SimpleRemoteControl();
        //var light = new Light();
        //var lightOn = new LightOnCommand(light);
        //remote.SetCommand(lightOn);
        //remote.ButtonWasPressed();

        var remoteControl = new RemoteControl();

        var livingRoomLight = new Light("Living Room");
        var kitchenLight = new Light("Kitchen");
        var ceilingFan = new Fan("Living Room");
        var garageDoor = new GarageDoor("Garage");
        var stereo = new Stereo("Living Room");

        var livingRoomLightOn = new LightOnCommand(livingRoomLight);
        var livingRoomLightOff = new LightOffCommand(livingRoomLight);

        var kitchenLightOn = new LightOnCommand(kitchenLight);
        var kitchenLightOff = new LightOffCommand(kitchenLight);

        var ceilingFanOn = new FanHighCommand(ceilingFan);
        var ceilingFanOff = new FanOffCommand(ceilingFan);

        var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
        var garageDoorClose = new GarageDoorCloseCommand(garageDoor);

        var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
        var stereoOffWithCD = new StereoOffWithCDCommand(stereo);


        var partyOn = new MacroCommand(new List<ICommand>() {   livingRoomLightOn ,
                                                                kitchenLightOn,
                                                                ceilingFanOn,
                                                                garageDoorOpen,
                                                                stereoOnWithCD,
                                                            });
        var partyOff = new MacroCommand(new List<ICommand>() {  livingRoomLightOff ,
                                                                kitchenLightOff,
                                                                ceilingFanOff,
                                                                garageDoorClose,
                                                                stereoOffWithCD,
                                                            });

        var slot = 0;
        remoteControl.SetCommand(slot++, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(slot++, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(slot++, ceilingFanOn, ceilingFanOff);
        remoteControl.SetCommand(slot++, garageDoorOpen, garageDoorClose);
        remoteControl.SetCommand(slot++, stereoOnWithCD, stereoOffWithCD);
        remoteControl.SetCommand(slot++, partyOn, partyOff);

        Console.WriteLine(remoteControl.ToString());

        for (int i = 0; i < 7; i++)
        {
            remoteControl.OnButtonWasPushed(i);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(i);

            remoteControl.OffButtonWasPushed(i);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(i);
        }
    }
}