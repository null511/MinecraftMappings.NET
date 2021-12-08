using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HornCoralBlock : JavaBlockTexture
    {
        public HornCoralBlock() : base("Horn Coral Block")
        {
            AddVersion("horn_coral_block");
                //.WithDefaultModel<Java.Models.Block.HornCoralBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HornCoralBlock>();
        }
    }
}
