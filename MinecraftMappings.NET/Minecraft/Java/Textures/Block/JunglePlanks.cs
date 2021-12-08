using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JunglePlanks : JavaBlockTexture
    {
        public JunglePlanks() : base("Jungle Planks")
        {
            AddVersion("jungle_planks");
                //.WithDefaultModel<Java.Models.Block.JunglePlanks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.JunglePlanks>();
        }
    }
}
