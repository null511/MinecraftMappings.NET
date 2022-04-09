using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RepeatingCommandBlock_Front : JavaBlockTexture
    {
        public RepeatingCommandBlock_Front() : base("Repeating Command Block, Front")
        {
            AddVersion("repeating_command_block_front")
                .WithDefaultModel<Java.Models.Block.RepeatingCommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
