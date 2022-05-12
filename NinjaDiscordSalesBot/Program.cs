using NinjaDiscordSalesBot;

// You can either configure:
// - channel id + bot token
// - webhook URL (recommended option: restricts the bot to post to the specified channel)
var bot = new NinjaBot(new NinjaBotOptions
{
    DiscordBotToken = "<discord_bot_token>",
    DiscordChannelId = "974258301384675348",
    DiscordWebhookUrl = "https://discord.com/api/webhooks/974263265192468501/z29DvTy2OJGtYpCaS4tPHwcggEVsVa0UkJt-URw_EjS8pHPTfHvXZhKISFNz-lWxFvJo",
    CollectionContractAddress = "0x031920cc2D9F5c10B444FD44009cd64F829E7be2",
    InfuraApiKey = "https://mainnet.infura.io/v3/3de6ca64c8524650b7a2230f357251ab"
});

await bot.StartAsync();

Thread.Sleep(-1);