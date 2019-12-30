# PMDFileWatcher
Monitor, compile and play MML for PMD automatically  
Copyright (C) 2017 Rerrah

[日本語](./README_ja.md)

## Overview
PMDFileWatcher is an application that monitors the update of MML for PMD, automatically compiles the MML and play it on players such as FMPMD.  
The program to be used for compilation and playback can be specified in "Settings".

#### Use MML compiler on 64-bit
On 64-bit Windows OS, you can not directly execute the compiler MC.EXE which is a 16-bit program.  
To resolve this problem, this app executes MC through [MS-DOS Player](http://takeda-toshiya.my.coocan.jp/msdos/), so you need to get it before compilation.  
It is also neccessary to set the path to MS-DOS Player in Settings.

If you use 32-bit Windows PC, use msdos.exe for x86. If you use 64-bit Windows PC, use msdos.exe for x64.

Another solution that executes MC without MS-DOS Player each time is to convert MC to executable file on your PC MS-DOS in advance.  
MS-DOS Player has convert option `-c`, which makes converted exe:

```bat
./msdos.exe -c"path of new exe" "path of MC"
```

### MML compilation
You can drag and drop a MML file to make it a monitoring target.  
Pressing "Start", the app begins monitoring the MML.  
When MML is updated, it automatically executes MS-DOS Player (optional) and MC specified in "Settings" to compile MML.  
After compilation, the compilation result form opens.  
The compiled data (files with the extension .M, .M2, etc.) are generated in the same place as the MML.  
Press the Stop button to stop MML monitoring.  
You can also force MML compilation with "Compile".

### Autoplay
You can specify whether to play compiled data automatically after compilation in "Settings".  
When performing autoplay, please set the program to be executed in "Autoplay" of "Settings".

## Requirements
* Windows OS (tested on Windows 8 and 10)
* .NET Framework 4.6.1 or later
* MC.exe (PMD compiler)
* MS-DOS Player (optional)
* Playback application (optional)

## License
This application is licensed under MIT License. 
*See [LICENSE](./LICENSE).*
