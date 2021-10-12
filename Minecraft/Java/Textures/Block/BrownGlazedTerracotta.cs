using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownGlazedTerracotta : JavaBlockData
    {
        public const string BlockId = "brown_glazed_terracotta";
        public const string BlockName = "Brown Glazed Terracotta";


        public BrownGlazedTerracotta() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToBedrockId = BedrockBlocks.GlazedTerracottaBrown.BlockId;
            });
        }
    }
}
