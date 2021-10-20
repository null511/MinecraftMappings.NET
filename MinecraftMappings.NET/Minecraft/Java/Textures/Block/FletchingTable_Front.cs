using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FletchingTable_Front : JavaBlockTexture
    {
        public FletchingTable_Front() : base("Fletching Table, Front")
        {
            AddVersion("fletching_table_front")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.FletchingTable>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FletchingTable_Front>();
        }
    }
}
