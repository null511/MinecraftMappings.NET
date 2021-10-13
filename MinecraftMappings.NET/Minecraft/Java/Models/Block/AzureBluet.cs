using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AzureBluet : JavaBlockModel
    {
        public AzureBluet() : base("Azure Bluet")
        {
            AddVersion("azure_bluet", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/azure_bluet");
        }
    }
}
