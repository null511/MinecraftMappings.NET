using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLogTop : JavaBlockData
    {
        public const string BlockId = "acacia_log_top";
        public const string BlockName = "Acacia Log Top";


        public AcaciaLogTop() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToBedrockId = BedrockBlocks.LogAcaciaTop.BlockId;
            });
        }
    }
}
