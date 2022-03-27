using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Glowstone : JavaBlockTexture
    {
        public Glowstone() : base("Glowstone")
        {
            AddVersion("glowstone")
                .WithDefaultModel<Java.Models.Block.Glowstone>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Glowstone>();
        }
    }
}
