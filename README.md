#FIX Message Debug Visualizer
### Summary
This project provides Visual Studio Debug Visualizer that makes debugging FIX code easier. This project is based on [QuickFIX/n](https://github.com/connamara/quickfixn). Actually, it is based on  [my fork](https://github.com/unclepaul84/quickfixn) of it, because some changes needed to be made to make visualizer code work.

### Features
 * Automatically loads proper [QuickFIX/n](https://github.com/connamara/quickfixn) [dictionaries](https://github.com/connamara/quickfixn/tree/master/spec/fix) based on BeginString
 * Supports custom dictionaries (by modifying the default dictionary)
 * Displays enumeration values (even multi values)
 * Supports (recursive) FIX Tag Groups

### Requirements

* Visual Studio 2010

### Installation 

1. [Download Package](https://github.com/downloads/unclepaul84/fixmessagevisualizer/FixMessageDebugVisualizer.zip)
2. Copy contents to My Documents\VisualStudioVersion\Visualizers

***

[![FIX Message Visualizer][1]](https://github.com/unclepaul84/fixmessagevisualizer/wiki/FIX-Message-Debug-visualizer)

[1]: https://cloud.github.com/downloads/unclepaul84/fixmessagevisualizer/FixVisulizer2.png
