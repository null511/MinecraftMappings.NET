using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Siamese : JavaEntityTexture
    {
        public Cat_Siamese() : base("Cat, Siamese")
        {
            AddVersion("siamese")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Siamese>();
        }
    }
}
