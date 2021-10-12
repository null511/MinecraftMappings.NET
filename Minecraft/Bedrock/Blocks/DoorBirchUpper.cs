using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class DoorBirchUpper : BedrockBlockData
    {
        public const string BlockId = "door_birch_upper";
        public const string BlockName = "Door Birch Upper";


        public DoorBirchUpper() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BirchDoorTop.BlockId,
            });
        }
    }
}
