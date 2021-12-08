using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NoteBlock : JavaBlockTexture
    {
        public NoteBlock() : base("NoteBlock")
        {
            AddVersion("note_block");
                //.WithDefaultModel<Java.Models.Block.NoteBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NoteBlock>();
        }
    }
}
