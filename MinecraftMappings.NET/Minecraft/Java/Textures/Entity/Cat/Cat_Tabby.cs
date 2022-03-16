using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Tabby : JavaEntityTexture
    {
        public Cat_Tabby() : base("Cat, Tabby")
        {
            AddVersion("tabby")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Tabby>();
        }
    }
}
