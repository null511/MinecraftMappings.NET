using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class StoneAndesite : BedrockBlockData
    {
        public const string BlockId = "stone_andesite";
        public const string BlockName = "Stone Andesite";


        public StoneAndesite() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = Andesite.BlockId,
            });
        }
    }
}
