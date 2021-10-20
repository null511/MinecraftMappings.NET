using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Blackstone : JavaBlockTexture
    {
        public Blackstone() : base("Blackstone")
        {
            AddVersion("blackstone")
                .WithDefaultModel<Java.Models.Block.Blackstone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Blackstone>();
        }
    }
}
