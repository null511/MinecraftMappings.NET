using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LoomFront : JavaBlockTexture
    {
        public LoomFront() : base("Loom Front")
        {
            AddVersion("loom_front")
                .WithDefaultModel<Java.Models.Block.Loom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LoomFront>();
        }
    }
}
