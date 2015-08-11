# cmd-ext
Command prompt extensions

## Installation instructions
Run the installer .msi and you're ready to go. Simple as that.

## Supported commands

#### su
Opens an elevated command prompt.

#### gksudo <command> <arguments>
Executes the given command with the specified arguments as a GUI application. (.exe's not .bat, .cmd, etc.)

#### sudo <command> <arguments>
Executes the given command with the specified arguments (.exe's not .bat, .cmd, etc.)
Please note that this command will only provide output, for instance 'sudo cmd' will not work, use 'gksudo cmd' or 'su' instead.