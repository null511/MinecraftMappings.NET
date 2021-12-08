using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonPlanks : JavaBlockTexture
    {
        public CrimsonPlanks() : base("Crimson Planks")
        {
            AddVersion("crimson_planks");
                //.WithDefaultModel<Java.Models.Block.CrimsonPlanks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonPlanks>();
        }
    }
}
