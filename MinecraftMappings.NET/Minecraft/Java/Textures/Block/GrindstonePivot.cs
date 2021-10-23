using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrindstonePivot : JavaBlockTexture
    {
        public GrindstonePivot() : base("Grindstone Pivot")
        {
            AddVersion("grindstone_pivot")
                .WithDefaultModel<Java.Models.Block.Grindstone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrindstonePivot>();
        }
    }
}
