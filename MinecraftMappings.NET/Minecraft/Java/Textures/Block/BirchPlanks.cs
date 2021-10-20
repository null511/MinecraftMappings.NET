using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchPlanks : JavaBlockTexture
    {
        public BirchPlanks() : base("Birch Planks")
        {
            AddVersion("birch_planks")
                .WithDefaultModel<Java.Models.Block.BirchPlanks>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PlanksBirch>();
        }
    }
}
