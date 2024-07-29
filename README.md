# SCP096ElevatorRestrict
The SCP096ElevatorRestrict plugin is designed to control SCP-096's access to elevators in the game SCP: Secret Laboratory. This plugin allows you to customize the behavior of SCP-096 when he is in a rage state and interacts with elevators.

## Functionality
- **Restrict access to elevators while in a rage state:** If SCP-096 is in a rage state and has targets, use of elevators will be prohibited.
- **Behavior Configuration:** Allows you to configure whether elevators can be used when SCP-096 is in a rage state but has no targets.
- **Tooltip Text:** Displays a tooltip text to the player if they are not allowed to use the elevators, and allows you to customize this message and display time through the configuration file.

## Configuration
```yml
SCP096ElevatorRestrict:
# Is the plugin enabled?
  is_enabled: true
  # Are debug messages displayed?
  debug: false
  # Should SCP-096 be prevented from using elevators when enraged but without targets?
  prevent_elevator_use_when_no_targets: false
  # Text to display when SCP-096 is not allowed to use elevators.
  hint_text: 'You can''t use the elevator while you''re in a <color=red>rage</color>!'
  # Time to display the hint message in seconds.
  hint_display_time: 5
```