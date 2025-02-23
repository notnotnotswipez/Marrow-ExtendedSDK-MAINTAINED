# Fork Info
This is a new repository which will be maintained for the forseeable future.

# Info
This repository allows the extension of the BONELAB Marrow SDK, allowing you to create custom guns and other types of items not yet supported by the Marrow SDK.

One of the major objectives of this repo, is to remove incentives to decompile the game, through strategic inclusion of assets which aren't useful elsewhere, and thorough documentation of what's possible.

# How to Install

Install [Git](https://git-scm.com/) and Restart Unity / Unity Hub if they are open.

Begin installing the MarrowSDK by following the original instructions at https://github.com/StressLevelZero/MarrowSDK/wiki/ProjectSetup.

> [!IMPORTANT]  
> DO NOT INSTALL THE SLZ MARROWSDK PACKAGE OR THE BACKLOT PACKAGE AFTER ADDING THE SCOPED REGISTRY

> [!IMPORTANT]  
> IF UPDATING, MAKE SURE TO DELETE Marrow-ExtendedSDK-MAINTAINED-main COMPLETELY FROM YOUR ASSETS FOLDER BEFORE DOWNLOADING THE NEW CODE DROPDOWN

After you've added the scoped registry, go to the top left of the ``Package Manager`` and add a ``git URL``.
The git URL you should add is 
```
https://github.com/notnotnotswipez/MarrowSDKExt.git
```

![image](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-MAINTAINED/assets/79382000/98ee31d3-5c23-4183-93f1-76a2c7793803)


If you've done everything correctly, everything should install properly, including SLZ's URP.

After installation is complete and the ``Extended Marrow SDK`` package is listed as installed, download *this* repository from the green dropdown arrow at the top of this page.

![image](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-MAINTAINED/assets/79382000/c2e4231e-7171-42d1-80c9-1d4e2dc4c026)

![image](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-MAINTAINED/assets/79382000/81b8e308-f70f-4196-9aa1-bf9563f7e3db)

Extract the contents of the zip into your project's `Assets` folder.

> [!IMPORTANT]
> To utilize the Marrow Backlot assets, you must install the [Marrow Backlot Standalone](https://github.com/EvroDeveloper/Marrow-Backlot-Standalone) package. The base Marrow SDK Backlot is __not__ compatible with the Extended SDK.

#
### This repo contains DUMMY scripts. Which are scripts that are not functional and contain no code. They simply get replaced with their ingame equivalents upon being loaded.

# IF YOU WOULD LIKE TO PR SOMETHING TO THIS REPO PLEASE FOLLOW THESE GUIDELINES:
### Do not PR any FUNCTIONAL/NON DUMMY scripts that come from paid asset packs/utilities. Dummy scripts are fine. Functional and FREE open source/public scripts are fine.
### Do not PR any art that must be paid for or was paid for by someone. This includes assets ripped directly from Bonelab (PRs containing direct Bonelab assets will not be accepted). Only free assets or assets personally made and granted free open access by the creator are allowed. (This keeps things like the examples usable with no worry about copyright)
