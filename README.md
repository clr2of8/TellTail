![TellTail](TellTail/Images/TellTail%20Brick%20Background.jpg)

# TellTail
A tool to display Windows Event logs as they happen.

The application is currently hard-coded to tail these 3 PowerShell logs:

1) Microsoft-Windows-PowerShell/Operational
2) Windows PowerShell
3) PowerShellCore/Operational

![Demo](TellTail/Images/Demo.png)

## Installation

Download and run `setup.exe` from the [Releases](https://github.com/clr2of8/TellTail/tree/main/Releases) directory to install the tool.

## Customize and Build

If you would like to modify the code and then compile it into an executable, you can use the following command from the Windows command prompt.

```
dotnet msbuild TellTail.csproj
```
