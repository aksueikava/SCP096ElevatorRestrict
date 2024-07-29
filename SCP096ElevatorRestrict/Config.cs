using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SCP096ElevatorRestrict
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Are debug messages displayed?")]
        public bool Debug { get; set; } = false;

        [Description("Should SCP-096 be prevented from using elevators when enraged but without targets?")]
        public bool PreventElevatorUseWhenNoTargets { get; set; } = false;

        [Description("Text to display when SCP-096 is not allowed to use elevators.")]
        public string HintText { get; set; } = "You can't use the elevator while you're in a <color=red>rage</color>!";

        [Description("Time to display the hint message in seconds.")]
        public int HintDisplayTime { get; set; } = 5;
    }
}