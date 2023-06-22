# GameChanger
Parser for GameChanger (gc.com) xml files.


## Setup

### 1. Download and Install .NET SDK
Go to the [dot.net](https://dotnet.microsoft.com/en-us/download) website, download and install the latest .NET SDK


### 2. Restore and Build
Open this repo folder in a terminal/cli and run `dotnet restore` which will restore all dependecies.

Then run `dotnet build` to make sure everthing compiles correctly.


## Running the parser
There is a sample cli app under /samples which parses a Game Changer XML and outputs a two stats.csv file for each team.

Simple cd into the folder and run `dotnet run <path-to-xml-file>``


## NOTES

This library has been tested only with ouput files of GameChanger Classic. There are also multiple file format versions for GameChanger.
Once updating to latest version I am unsure if this will still work.