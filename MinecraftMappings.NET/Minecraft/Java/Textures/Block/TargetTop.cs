using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TargetTop : JavaBlockTexture
    {
        public TargetTop() : base("Target Top")
        {
            AddVersion("target_top");
                //.WithDefaultModel<Java.Models.Block.Target>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TargetTop>();
        }
    }
}
