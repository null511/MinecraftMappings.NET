using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrindstoneRound : BedrockBlockTexture
    {
        public GrindstoneRound() : base("Grindstone Round")
        {
            AddVersion("grindstone_round")
                .MapsToJavaBlock<Java.Textures.Block.GrindstoneRound>();
        }
    }
}
