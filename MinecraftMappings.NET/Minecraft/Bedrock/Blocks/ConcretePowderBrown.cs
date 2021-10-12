using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcretePowderBrown : BedrockBlockData
    {
        public const string BlockId = "concrete_powder_brown";
        public const string BlockName = "Concrete Powder Brown";


        public ConcretePowderBrown() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = BrownConcretePowder.BlockId;
            });
        }
    }
}
