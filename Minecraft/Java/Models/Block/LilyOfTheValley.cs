using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class LilyOfTheValley : JavaModelData
    {
        public LilyOfTheValley() : base("Lily Of The Valley")
        {
            AddVersion("lily_of_the_valley", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/lily_of_the_valley");
        }
    }
}
