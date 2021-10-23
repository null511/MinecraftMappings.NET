using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Vine : JavaBlockTexture
    {
        public Vine() : base("Vine")
        {
            AddVersion("vine")
                .WithDefaultModel<Java.Models.Block.Vine>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Vine>();
        }
    }
}
