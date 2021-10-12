using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorBottom : JavaBlockData
    {
        public const string BlockId = "birch_door_bottom";
        public const string BlockName = "Birch Door Bottom";


        public BirchDoorBottom() : base(BlockName)
        {
            Versions.Add(new JavaBlockDataVersion {
                Id = BlockId,
                MapsToBedrockId = BedrockBlocks.DoorBirchLower.BlockId,
            });
        }
    }
}
