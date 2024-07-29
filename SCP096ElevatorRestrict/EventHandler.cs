﻿using Exiled.API.Features;
using PlayerRoles;
using PlayerRoles.PlayableScps.Scp096;
using Exiled.Events.EventArgs.Player;

namespace SCP096ElevatorRestrict
{
    public class EventHandler
    {
        private readonly Config _config;

        public EventHandler(Config config)
        {
            _config = config;
        }

        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            if (ev.Player.Role == RoleTypeId.Scp096)
            {
                var scp096Role = ev.Player.ReferenceHub.roleManager.CurrentRole as Scp096Role;

                if (scp096Role != null && scp096Role.IsRageState(Scp096RageState.Enraged))
                {
                    bool hasTargets = ev.Player.HasScp096Target();

                    if (hasTargets || !_config.PreventElevatorUseWhenNoTargets)
                    {
                        ev.IsAllowed = false;
                        ev.Player.ShowHint(_config.HintText, _config.HintDisplayTime);
                    }
                    else
                    {
                        ev.IsAllowed = true;
                    }
                }
            }
        }
    }

    public static class PlayerExtensions
    {
        public static bool HasScp096Target(this Player player)
        {
            if (player.Role == RoleTypeId.Scp096)
            {
                var scp096Role = player.ReferenceHub.roleManager.CurrentRole as Scp096Role;
                if (scp096Role != null && scp096Role.SubroutineModule.TryGetSubroutine<Scp096TargetsTracker>(out var targetsTracker))
                {
                    return targetsTracker.Targets.Count > 0;
                }
            }
            return false;
        }
    }
}