# RpiController

A small winform app to control multiple SSH Enabled devices
This tool can run multiple SSH commands (using the Renci.SSH) automatically on your device/s from a custom list of commands and devices.

##Features:
- You can easily add and remove commands and devices.
- Run multiple ssh commands to multiple ssh devices (make sure all devices are the same type (e.g all selected devices are RPIs, and all commands are RPI compatible).
- Passwords are being Encrypted with salt and encryption key created locally at runtime (decryption happens in-place while running a command and is not saved as plaintext).

*  Data is being stored in "%programdata%\RPI_Controller"
*  the app does not collect any personal data
Enjoy!