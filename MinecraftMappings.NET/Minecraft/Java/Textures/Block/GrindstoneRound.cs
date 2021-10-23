using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrindstoneRound : JavaBlockTexture
    {
        public GrindstoneRound() : base("Grindstone Round")
        {
            AddVersion("grindstone_round")
                .WithDefaultModel<Java.Models.Block.Grindstone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrindstoneRound>();
        }
    }
}
