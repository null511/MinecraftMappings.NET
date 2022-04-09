using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CommandBlock_Back : JavaBlockTexture
    {
        public CommandBlock_Back() : base("Command Block, Back")
        {
            AddVersion("command_block_back")
                .WithDefaultModel<Java.Models.Block.CommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
