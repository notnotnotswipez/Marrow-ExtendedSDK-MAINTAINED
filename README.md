# Fork Info
This is a new repository which will be maintained for the forseeable future.

# Info
This repository allows the extension of the BONELAB Marrow SDK, allowing you to create custom guns and other types of items not yet supported by the Marrow SDK.

One of the major objectives of this repo, is to remove incentives to decompile the game, through strategic inclusion of assets which aren't useful elsewhere, and thorough documentation of what's possible.

# How to Install

1. Install [Git](https://git-scm.com/) and Restart your PC.

2. Begin installing the MarrowSDK by following the original [instructions](https://github.com/StressLevelZero/MarrowSDK/wiki/ProjectSetup), stop after you have added the scoped registry. Further instructions below.

> [!IMPORTANT]  
> DO NOT INSTALL THE SLZ MARROWSDK PACKAGE OR THE BACKLOT PACKAGE AFTER ADDING THE SCOPED REGISTRY
> 
> If switching from the SLZ MarrowSDK to the Extended SDK, uninstall the MarrowSDK and Marrow Backlot packages before proceeding with installation

> [!IMPORTANT]  
> IF UPDATING, MAKE SURE TO DELETE Marrow-ExtendedSDK-MAINTAINED-main COMPLETELY FROM YOUR ASSETS FOLDER BEFORE DOWNLOADING THE NEW CODE DROPDOWN

3. After you've added the scoped registry, go to the top left of the ``Package Manager`` and add a ``git URL``.
The git URL you should add is 
```
https://github.com/notnotnotswipez/MarrowSDKExt.git
```

![image](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-MAINTAINED/assets/79382000/98ee31d3-5c23-4183-93f1-76a2c7793803)


If you've done everything correctly, the packages should finish installing, including SLZ's URP.

4. After package installation is complete and the ``Extended Marrow SDK`` package is listed as installed, download *this* repository from the green dropdown arrow at the top of this page.

![image](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-MAINTAINED/assets/79382000/c2e4231e-7171-42d1-80c9-1d4e2dc4c026)

![image](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-MAINTAINED/assets/79382000/81b8e308-f70f-4196-9aa1-bf9563f7e3db)

5. Extract the contents of the zip into your project's `Assets` folder.

> [!IMPORTANT]
> To utilize the Marrow Backlot assets, you must install the [Marrow Backlot Standalone](https://github.com/EvroDeveloper/Marrow-Backlot-Standalone) package. The base Marrow SDK Backlot is __not__ compatible with the Extended SDK.

# Installation Troubleshooting

Check this list of common issues if you are having trouble with installing.
## The git package won't install
Check the Console window (Ctrl+Shift+C) for these potential errors (use the searchbar if needed):
### `No 'git' executable was found`

This may occur if:
- Git was not installed - see [Step 1](#how-to-install)

Or:
- Git was installed but not added to PATH - add the Git cmd path to your Environment Variables (for most people this would be `C:\Program Files\Git\cmd`)
### `Error when executing git command. fatal: not in a git directory`

This may occur if your Unity project is located somewhere Git doesn't recognize as having ownership in. To allow using Git in your project:
1. Open Windows PowerShell.
2. Copy following command and paste it into the PowerShell window:
```
git config --global --add safe.directory "D:/Path/To/Your/Unity/Project"
```
3. Replace the path in quotes with the path to your Unity project, and press Enter. This should return no text, the PowerShell window may be closed.
4. Retry installing the git package in Package Manager.

### `  Package name 'https://[...]' is invalid. [InvalidParameter].` or `[https://[...]] does not point to a valid package. No package manifest was found. [NotFound].`
These typically occur if the git URL was pasted incorrectly, or the wrong URL was used. The _only_ git package URLs related to the Extended SDK that should be used are the following:
```
https://github.com/notnotnotswipez/MarrowSDKExt.git
```
```
https://github.com/EvroDeveloper/Marrow-Backlot-Standalone.git
```

Note that the `MarrowSDKExt` package is _not_ the GitHub repository that you are currently viewing.
Use the copy buttons on the right side of the above boxes to avoid selecting extra spaces.

## I installed successfully, but the SDK isn't working / isn't showing up

Check the Console window (Ctrl+Shift+C) for these potential errors (use the searchbar if needed):

### `The namespace '[...]' already contains a definition for '[...]'`
This typically happens if:
- The Marrow SDK and Extended SDK are installed simultaneously. The Extended SDK contains its own copies of the Marrow SDK scripts, so the Marrow SDK packages are not required. Uninstall the Marrow SDK and Marrow Backlot packages from the Package Manager

Or:
- There are multiple `Marrow-ExtendedSDK-MAINTAINED-main` folders in your project, or otherwise duplicate Extended SDK files. This can also occur if you installed a unitypackage that included Extended SDK files by mistake. Remove the duplicate installation
### `The type or namespace name '[...]' does not exist in the namespace '[...]'`
This typically happens if the git package was installed, but the zip was not downloaded and its folder extracted to `Assets`. Return to [Step 4](#how-to-install).

### Other compilation errors
If you have other C# (`CS[xxxx]`) compilation errors already in your project, it will prevent the scripts from compiling and the SDK menus to appear. The errors will need to be addressed as necessary.

## I finished the Extended SDK installation successfully, but when I try to pack a pallet, I get a `Could not find a part of the path` / `catalog.json` pallet pack error

This error is nondescript can happen as a result of any compilation error, and you should check the Console window (Ctrl+Shift+C) to investigate the issue. These are the most common causes/errors:
- `Library\PackageCache\com.unity.collections@1.2.4\Unity.Collections\NativeList.cs(839,24) [...]`
- `Switching to Android:AndroidPlayer is disabled`

These indicate that the build modules for PC/Windows or Quest/Android respectively were not installed during [ProjectSetup](https://github.com/StressLevelZero/MarrowSDK/wiki/ProjectSetup). To install them: 
1. Open Unity Hub, go to `Installs`, and find the Unity version currently in use (for Patch 6 of BONELAB, this should be `2021.3.16f1`).
2. Click the `Manage` dropdown and click `Add modules`.
	- If `Add modules` is not listed, you may be on a manual installation of Unity, which is not supported. You need to have installed Unity through Unity Hub as described in ProjectSetup
3. Install the `Android Build Support` module and its sub-modules, and `Windows Build Support (IL2CPP)`. Unity will try to get you to install Visual Studio as well, this is not required and you can untick this before installing.
#

If your issue wasn't listed here and you were unable to find a solution troubleshooting on your own, join the unofficial [BONELAB Discord server](https://discord.gg/mjmpUR8) and create a thread in [#mod-help-‼](https://discord.com/channels/563139253542846474/1019659373695475802) explaining your issue.
#
### This repo contains DUMMY scripts. Which are scripts that are not functional and contain no code. They simply get replaced with their ingame equivalents upon being loaded.

# IF YOU WOULD LIKE TO PR SOMETHING TO THIS REPO PLEASE FOLLOW THESE GUIDELINES:
### Do not PR any FUNCTIONAL/NON DUMMY scripts that come from paid asset packs/utilities. Dummy scripts are fine. Functional and FREE open source/public scripts are fine.
### Do not PR any art that must be paid for or was paid for by someone. This includes assets ripped directly from Bonelab (PRs containing direct Bonelab assets will not be accepted). Only free assets or assets personally made and granted free open access by the creator are allowed. (This keeps things like the examples usable with no worry about copyright)
