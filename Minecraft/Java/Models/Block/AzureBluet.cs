using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AzureBluet : JavaModelData
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
