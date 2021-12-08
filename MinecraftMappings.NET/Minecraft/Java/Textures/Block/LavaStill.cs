using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LavaStill : JavaBlockTexture
    {
        public LavaStill() : base("Lava Still")
        {
            AddVersion("lava_still");
                //.WithDefaultModel<Java.Models.Block.LavaStill>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LavaStill>();
        }
    }
}
