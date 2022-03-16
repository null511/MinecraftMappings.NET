using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Ragdoll : JavaEntityTexture
    {
        public Cat_Ragdoll() : base("Cat, Ragdoll")
        {
            AddVersion("ragdoll")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Ragdoll>();
        }
    }
}
