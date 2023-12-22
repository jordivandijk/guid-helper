# guid-helper
A command line tool to generate x amounts of Guids/uniqueidentifiers and copie them to your clipboard.

You can easily paste this into SSMS or excel files due to spacing.

# Download
You can download the complete repository and build it yourself, or you can download the raw Guid-setup.zip and install the application.

# Usage
There are two commands
 - validate
 - new

### validate
Used like `guid validate {my-guid-1} {my-guid-2}...` It returnes the input in red or green and states if it is valid or not for each guid.

### new
Used like `guid new {amount}` you can create multiple at once, these are added to your clipoboard

# Suported OS
 - Windows
