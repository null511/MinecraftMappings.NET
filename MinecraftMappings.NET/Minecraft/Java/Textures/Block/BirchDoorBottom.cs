using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorBottom : JavaBlockTexture
    {
        public BirchDoorBottom() : base("Birch Door Bottom")
        {
            AddVersion("birch_door_bottom")
                .WithDefaultModel<Java.Models.Block.BirchDoorBottom>()
                .MapsToBedrockBlock<BedrockBlocks.DoorBirchLower>();
        }
    }
}
