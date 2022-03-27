using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakPlanks : JavaBlockTexture
    {
        public DarkOakPlanks() : base("Dark Oak Planks")
        {
            AddVersion("dark_oak_planks")
                .WithDefaultModel<Java.Models.Block.DarkOakPlanks>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PlanksBigOak>();
        }
    }
}
