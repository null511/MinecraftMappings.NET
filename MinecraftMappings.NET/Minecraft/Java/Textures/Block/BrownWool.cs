using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownWool : JavaBlockTexture
    {
        public BrownWool() : base("Brown Wool")
        {
            AddVersion("brown_wool")
                .WithDefaultModel<Java.Models.Block.BrownWool>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredBrown>();
        }
    }
}
