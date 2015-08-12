# cmd-ext
Command prompt extensions

## Installation instructions
Run setup.exe and you're ready to go. Simple as that.
You can also download the source and compile the extensions yourself although this might cost some more efford, the project does not include an automated method to build all extensions at the same time.

## Supported commands

#### su
Opens an elevated command prompt.

#### gksudo <command> <arguments>
Executes the given command with the specified arguments as a GUI application. (.exe's not .bat, .cmd, etc.)

#### sudo <command> <arguments>
Executes the given command with the specified arguments (.exe's not .bat, .cmd, etc.)
Please note that this command will only provide output, for instance 'sudo cmd' will not work, use 'gksudo cmd' or 'su' instead.
