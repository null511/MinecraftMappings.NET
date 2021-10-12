using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class MushroomBrown : BedrockBlockData
    {
        public const string BlockId = "mushroom_brown";
        public const string BlockName = "Mushroom Brown";


        public MushroomBrown() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = BrownMushroom.BlockId;
            });
        }
    }
}
