# PMDFileWatcher
Monitor, compile and play MML for PMD automatically  
Copyright (C) 2017 Rerrah

[日本語](./README_ja.md)

## Overview
PMDFileWatcher is an application that monitors the update of MML for PMD, automatically compiles the MML and play it on players such as FMPMD.  
The program to be used for compilation and playback can be specified in "Settings".  

On 64-bit Windows OS, you can not directly execute MC the compiler which is a 16-bit program. To resolve this problem, [MS-DOS Player](http://takeda-toshiya.my.coocan.jp/msdos/) is required.

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

### Requirements
* Windows OS (tested on Windows 8 and 10)
* .NET Framework 4.6.1 or later
* MC.exe (PMD compiler)
* MS-DOS Player (optional)
* Playback software (optional)

## License
This application is licensed under MIT License. 
*See [LICENSE](./LICENSE).*
