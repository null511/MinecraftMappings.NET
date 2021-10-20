using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PumpkinSide : JavaBlockTexture
    {
        public PumpkinSide() : base("Pumpkin Side")
        {
            AddVersion("pumpkin_side")
                .WithDefaultModel<Java.Models.Block.Pumpkin>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PumpkinSide>();
        }
    }
}
