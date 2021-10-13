using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorTop : JavaBlockTexture
    {
        public BirchDoorTop() : base("Birch Door, Top")
        {
            AddVersion("birch_door_top")
                .WithDefaultModel<Java.Models.Block.BirchDoorTop>()
                .MapsToBedrockBlock<BedrockBlocks.DoorBirchUpper>();
        }
    }
}
