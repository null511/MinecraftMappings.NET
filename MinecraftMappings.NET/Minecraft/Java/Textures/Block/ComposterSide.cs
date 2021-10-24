using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ComposterSide : JavaBlockTexture
    {
        public ComposterSide() : base("Composter Side")
        {
            AddVersion("composter_side")
                .WithDefaultModel<Java.Models.Block.Composter>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ComposterSide>();
        }
    }
}
