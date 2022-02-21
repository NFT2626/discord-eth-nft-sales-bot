﻿namespace NinjaDiscordSalesBot
{
    public static class MarketLogDecoderFactory
    {
        private static readonly List<IMarketLogDecoder> MarketLogDecoders = new()
        {
            new OpenSeaLogDecoder(),
            new LooksRareLogDecoder(),
        };

        public static IMarketLogDecoder? GetMarketDecoder(string contractAddress)
        {
            foreach (var marketLogDecoder in MarketLogDecoders)
            {
                if (marketLogDecoder.ContractAddress == contractAddress)
                {
                    return marketLogDecoder;
                }
            }

            return null;
        }
    }
}
