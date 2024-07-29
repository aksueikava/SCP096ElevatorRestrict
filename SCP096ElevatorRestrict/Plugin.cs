using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace SCP096ElevatorRestrict
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "SCP096ElevatorRestrict";
        public override string Prefix => "SCP096ElevatorRestrict";
        public override string Author => "aksueikava";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);

        public static Plugin Instance;
        private EventHandler _handler;

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();

            Log.Debug("SCP096ElevatorRestrict has been enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnregisterEvents();

            Log.Debug("SCP096ElevatorRestrict has been disabled.");
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _handler = new EventHandler(Config);
            Player.InteractingElevator += _handler.OnInteractingElevator;
        }

        private void UnregisterEvents()
        {
            Player.InteractingElevator -= _handler.OnInteractingElevator;
            _handler = null;
        }
    }
}