using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakPlanks : JavaBlockTexture
    {
        public OakPlanks() : base("Oak Planks")
        {
            AddVersion("oak_planks")
                .WithDefaultModel<Java.Models.Block.OakPlanks>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.OakPlanks>();
        }
    }
}
