# Introduction to Anterra Modding (Mostly for Jachro)

## File Structure
```
📁<root>
 ├─📁assets
 │  ├─📁sounds
 │  |  └─📄<sound>.ogg
 │  └─📁textures
 │     └─📄<texture>.png
 ├─📁data 
 │  ├─📁animations
 │  │  └─📄<animation>.json
 │  ├─📁areas
 │  │  └─📄<area>.json
 │  ├─📁entities
 │  │  └─📄<entity>.json
 │  ├─📁items
 │  │  └─📄<item>.json
 │  ├─📁loot_tables
 │  │  └─📄<loot_table>.json
 │  └─📁maps
 │     └─📄<map>.json
 ├─📁scripts
 │  └─📄<script>.cs
 └─📄mod.json
```
## Setting up your ```mod.json```
```jsonc
{
    "scriptConfig": {
        "entryClass":"Anterra.Test", // The entry class requires the namespace, it is not implied.
        "entryMethod":"Main" // Your entry method must be both public and static,
                             // otherwise your mod will not successfully compile.
    },
    "name":"Anterra Test Mod", // Full Name of your mod, can contain spaces/special characters. 
                               // This name can be changed without causing issues with other mods.
    "id":"anterra:test", // Unique ID of your mod, this is used to reference your mod. 
                         // This should not be changed.
    "version":"0.1", // The version of your mod only matters for other developers.
    "dependencies":[] // List of dependencies, refered to by their unique
}
```