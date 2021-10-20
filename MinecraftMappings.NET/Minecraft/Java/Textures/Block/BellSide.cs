using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellSide : JavaBlockTexture
    {
        public BellSide() : base("Bell Side")
        {
            AddVersion("bell_side")
                //.WithDefaultModel<Java.Models.Block.Bell>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellSide>();
        }
    }
}
