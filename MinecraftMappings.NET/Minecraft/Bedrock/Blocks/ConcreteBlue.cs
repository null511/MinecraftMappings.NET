using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcreteBlue : BedrockBlockData
    {
        public const string BlockId = "concrete_blue";
        public const string BlockName = "Concrete Blue";


        public ConcreteBlue() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = BlueConcrete.BlockId;
            });
        }
    }
}
