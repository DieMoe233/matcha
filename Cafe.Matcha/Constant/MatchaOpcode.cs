// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Constant
{
    using System.Collections.Generic;

    internal enum MatchaOpcode
    {
        ActorControl,
        ActorControlSelf,
        CEDirector,
        CompanyAirshipStatus,
        CompanySubmersibleStatus,
        ContentFinderNotifyPop,
        DirectorStart,
        EventPlay,
        Examine,
        FateInfo,
        InitZone,
        InventoryTransaction,
        ItemInfo,
        MarketBoardItemListing,
        MarketBoardItemListingCount,
        MarketBoardItemListingHistory,
        NpcSpawn,
        PlayerSetup,
        PlayerSpawn,
    }

    internal static class OpcodeStorage
    {
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0148, MatchaOpcode.ActorControl },
            { 0x025D, MatchaOpcode.ActorControlSelf },
            { 0x00D5, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0123, MatchaOpcode.CompanyAirshipStatus },
            { 0x0185, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0279, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0399, MatchaOpcode.DirectorStart },
            { 0x0155, MatchaOpcode.EventPlay },
            { 0x02C0, MatchaOpcode.Examine },
            { 0x007A, MatchaOpcode.FateInfo },
            { 0x02D1, MatchaOpcode.InitZone },
            { 0x02BD, MatchaOpcode.InventoryTransaction },
            { 0x02F0, MatchaOpcode.ItemInfo },
            { 0x03E3, MatchaOpcode.MarketBoardItemListing },
            { 0x0286, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0229, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x00A7, MatchaOpcode.NpcSpawn },
            { 0x035F, MatchaOpcode.PlayerSetup },
            { 0x039C, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x00c2, MatchaOpcode.ActorControl },
            { 0x0267, MatchaOpcode.ActorControlSelf },
            { 0x02ff, MatchaOpcode.CEDirector },
            { 0x02e1, MatchaOpcode.CompanyAirshipStatus },
            { 0x0292, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02ea, MatchaOpcode.ContentFinderNotifyPop },
            { 0x03b1, MatchaOpcode.DirectorStart },
            { 0x00e1, MatchaOpcode.EventPlay },
            { 0x02fa, MatchaOpcode.Examine },
            { 0x01a9, MatchaOpcode.FateInfo },
            { 0x03b4, MatchaOpcode.InitZone },
            { 0x01f6, MatchaOpcode.InventoryTransaction },
            { 0x036b, MatchaOpcode.ItemInfo },
            { 0x006b, MatchaOpcode.MarketBoardItemListing },
            { 0x00e2, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0103, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x014c, MatchaOpcode.NpcSpawn },
            { 0x0166, MatchaOpcode.PlayerSetup },
            { 0x01f0, MatchaOpcode.PlayerSpawn },
        };
    }
}
