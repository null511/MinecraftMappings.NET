using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedSand : JavaBlockTexture
    {
        public RedSand() : base("Red Sand")
        {
            AddVersion("red_sand");
                //.WithDefaultModel<Java.Models.Block.RedSand>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedSand>();
        }
    }
}
