using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Granite : JavaBlockTexture
    {
        public Granite() : base("Granite")
        {
            AddVersion("granite");
                //.WithDefaultModel<Java.Models.Block.Granite>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Granite>();
        }
    }
}
