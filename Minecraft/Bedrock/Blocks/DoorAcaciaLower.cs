using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class DoorAcaciaLower : BedrockBlockData
    {
        public const string BlockId = "door_acacia_lower";
        public const string BlockName = "Door Acacia Lower";


        public DoorAcaciaLower() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = AcaciaDoorBottom.BlockId,
            });
        }
    }
}
