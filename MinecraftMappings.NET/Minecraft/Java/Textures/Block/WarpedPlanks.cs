using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedPlanks : JavaBlockTexture
    {
        public WarpedPlanks() : base("Warped Planks")
        {
            AddVersion("warped_planks")
                .WithDefaultModel<Java.Models.Block.WarpedPlanks>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedPlanks>();
        }
    }
}
