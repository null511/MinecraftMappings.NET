using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightningRodOn : JavaBlockTexture
    {
        public LightningRodOn() : base("Lightning Rod, On")
        {
            AddVersion("lightning_rod_on")
                .WithDefaultModel<Java.Models.Block.LightningRodOn>();
                //.MapsToBedrockBlock<BedrockBlocks.LightningRodOn>();
        }
    }
}
