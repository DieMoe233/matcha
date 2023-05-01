﻿// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Constant {
    internal enum ActorControlType : ushort {
        SetStatus = 2,
        DefeatMsg = 6,
        TreasureSpot = 84,
        DirectorUpdate = 109,
        // CN
        FateStart = 2357,
        FateEnd = 2358,
        FateProgress = 2366,
        // Global
        FateStartGlobal = 2370,
        FateEndGlobal = 2357,
        FateProgressGlobal = 2356
    }
}
