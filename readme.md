# Introduction to Anterra Modding (Mostly for Jachro)

## File Structure
```
π<root>
 ββπassets
 β  ββπsounds
 β  |  ββπ<sound>.ogg
 β  ββπtextures
 β     ββπ¨<texture>.png
 ββπdata 
 β  ββπanimations
 β  β  ββπΆββοΈ<animation>.json
 β  ββπareas
 β  β  ββπ<area>.area
 β  ββπentities
 β  β  ββπΊ<entity>.json
 β  ββπitems
 β  β  ββπ₯€<item>.json
 β  ββπloot_tables
 β  β  ββπ§°<loot_table>.json
 β  ββπmaps
 β     ββπ<map>.map
 ββπscripts
 β  ββπ<script>.cs
 ββπ§mod.json
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