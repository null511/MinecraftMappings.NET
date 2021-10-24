using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ComposterBottom : JavaBlockTexture
    {
        public ComposterBottom() : base("Composter Bottom")
        {
            AddVersion("composter_bottom")
                .WithDefaultModel<Java.Models.Block.Composter>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ComposterBottom>();
        }
    }
}
