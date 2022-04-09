using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RepeatingCommandBlock_Back : JavaBlockTexture
    {
        public RepeatingCommandBlock_Back() : base("Repeating Command Block, Back")
        {
            AddVersion("repeating_command_block_back")
                .WithDefaultModel<Java.Models.Block.RepeatingCommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
