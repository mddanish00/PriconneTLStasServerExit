# PriconneTLStasServerExit

A BepInEx plugin to automatically close StasServer when closing the game Priconne.

This plugin is a must-have for those who use [XUnity-AutoTranslator-StasServerEndpoint](https://github.com/mddanish00/XUnity-AutoTranslator-StasServerEndpoint) with [PriconneRe-TL](https://github.com/ImaterialC/PriconneRe-TL).

This plugin is based on SugoiExitPatch from [PriconneTLFixup](httpshttps://github.com/Kevga/PriconneTLFixup).

## Installation

> The Release Archive include a copy of compiled XUnity-AutoTranslator-StasServerEndpoint to make sure DLL is built using the same version of PriconneRe-TL.


1. Download the latest `PriconneTLStasServerExit.zip` from the [Releases](https://github.com/mddanish00/PriconneTLStasServerExit/releases/latest).
2. Locate BepInEx folder. (In patched game directory with PriconneRe-TL)
3. Extract the archive and copy `PriconneTLStasServerExit.dll` to `BepInEx/plugins`. If already available, overwrite.
4. Copy `StasServer.dll` to `BepInEx/plugins/XUnity.AutoTranslator/Translators`. If already available, overwrite.

## Development

- Make sure .NET SDK 6 or higher is installed. Recomended to use latest LTS version.
- A working copy of the game that patched with PriconneRe-TL. Create symslink name `libs` in the root of the project repo that pointed to `BepInEx` folder in the patched game directory.

## License

PriconneTLStasServerExit is licensed under GPLv3.

```
PriconneTLStasServerExit is a BepInEx plugin to automatically close StasServer when closing Priconne.
Copyright (C) 2026  mddanishh00
Copyright (C) 2023  Kevga

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.

This plugin is based on SugoiExitPatch from PriconneTLFixup (https://github.com/Kevga/PriconneTLFixup).
```

Read the full license in [LICENSE](./LICENSE).

[XUnity-AutoTranslator-StasServerEndpoint](https://github.com/mddanish00/XUnity-AutoTranslator-StasServerEndpoint) is licensed under MIT license but the DLL build that included in this project Release Archive is licensed under GPLv3 same as this project.


## Acknowledgement

- Thanks to [MingShiba](https://www.patreon.com/mingshiba) for creating the Sugoi Japanese Toolkit and making high-quality (still machine translation) available to enjoy many untranslated Japanese works.

- Thanks to [Kevga](https://github.com/Kevga) and the rest of PriconneRe-TL team for creating the PriconneRe-TL that enable non-Japanese fans to enjoy Priconne even after Global server shutdown.


