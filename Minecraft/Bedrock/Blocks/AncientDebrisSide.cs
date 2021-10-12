using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class AncientDebrisSide : BedrockBlockData
    {
        public const string BlockId = "ancient_debris_side";
        public const string BlockName = "Ancient Debris Side";


        public AncientDebrisSide() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = Java.Textures.Block.AncientDebrisSide.BlockId;
                version.MinVersion = new GameVersion(1, 16);
            });
        }
    }
}
