using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TargetSide : JavaBlockTexture
    {
        public TargetSide() : base("Target Side")
        {
            AddVersion("target_side");
                //.WithDefaultModel<Java.Models.Block.Target>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TargetSide>();
        }
    }
}
