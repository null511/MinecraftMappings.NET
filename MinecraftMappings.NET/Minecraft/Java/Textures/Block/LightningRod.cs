using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightningRod : JavaBlockTexture
    {
        public LightningRod() : base("Lightning Rod")
        {
            AddVersion("lightning_rod")
                .WithDefaultModel<Java.Models.Block.LightningRod>();
                //.MapsToBedrockBlock<BedrockBlocks.LightningRod>();
        }
    }
}
