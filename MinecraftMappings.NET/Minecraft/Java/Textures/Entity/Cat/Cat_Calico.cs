using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Calico : JavaEntityTexture
    {
        public Cat_Calico() : base("Cat, Calico")
        {
            AddVersion("calico")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Calico>();
        }
    }
}
