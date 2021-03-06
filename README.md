# sbox-boilerplate
A boilerplate for kickstarting your S&amp;box addon

# Getting started

There are a few steps to take to turn this boilerplate into your own addon.

First, download this repository and place it inside a new folder inside your `/{steam}/sbox/addons/` folder.  For example, `/{steam}/sbox/addons/my-gamemode/{boilerplate files}`

### .addon

This file contains information about the addon, it must be modified to suit your addon.  In the future .addon files might no longer be needed, but for now we have to make sure to update them for each individual gamemode.

* name - your addon name (alphanumeric with no spaces)
* version - your addon version
* sharedassets - ??
* depends - an array of other addons that your addon will load first and have access to.  For example, `base` includes a basic player and movement controller.
* gamemodes - I think this is used to tell S&box to load your gamemode scripts?
  * name - your addon name.  This should be an all lowercase alphanumeric string
  * title - your addon title.  This can be a user-friendly string with capitals and spaces
  * description - your addon description
  * icon - full url to an icon that will display in the main menu.
  

Here is an example of a bare minimum .addon, you might want to do something like this if your addon is just a map.

```
{ "name": "my-gamemode" }
```

### BoilerplateGame.cs
This is the script that initializes your gamemode.
1. Rename the file, namespace, class, and constructor to suit your addon, i.e. `MyGamemode.cs`
2. Edit this line: `[Library("boilerplate", Title = "Boilerplate Addon")]`

### Cleaning up

If you don't need any of the content folders (materials, models, textures, etc), feel free to delete them.  If your addon is just a map, all you need is the `maps` folder.
