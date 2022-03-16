using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_White : JavaEntityTexture
    {
        public Cat_White() : base("Cat, White")
        {
            AddVersion("white")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_White>();
        }
    }
}
