using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CommandBlock_Front : JavaBlockTexture
    {
        public CommandBlock_Front() : base("Command Block, Front")
        {
            AddVersion("command_block_front")
                .WithDefaultModel<Java.Models.Block.CommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
